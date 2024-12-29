using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;
using System.Windows.Forms;
using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.Graphics.Gdi;
using Windows.Win32.Graphics.GdiPlus;
using Windows.Win32.System.Ole;
using Windows.Win32.UI.Controls.RichEdit;

namespace RichTextBoxEx;

public class RichTextBoxEx : RichTextBox
{
    public const uint WM_REFLECT_NOTIFY = 0x2000 + PInvoke.WM_NOTIFY;

    #region Native helpers

    private HWND hwnd => (HWND)this.Handle;

    private CHARFORMAT2W CreateCharFormat2()
    {
        return new CHARFORMAT2W()
        {
            Base = new CHARFORMATW()
            {
                cbSize = (uint)Marshal.SizeOf(typeof(CHARFORMAT2W))
            }
        };
    }

    private PARAFORMAT2 CreateParaFormat2()
    {
        return new PARAFORMAT2()
        {
            Base = new PARAFORMAT()
            {
                cbSize = (uint)Marshal.SizeOf(typeof(PARAFORMAT2))
            }
        };
    }

    private LRESULT SendMessage<T>(HWND hWnd, uint msg, WPARAM wParam, ref T lParam) where T : struct
    {
        IntPtr lParamPtr = IntPtr.Zero;
        try
        {
            lParamPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(T)));
            Marshal.StructureToPtr(lParam, lParamPtr, false);
            var result = PInvoke.SendMessage(hWnd, msg, wParam, lParamPtr);
            lParam = Marshal.PtrToStructure<T>(lParamPtr);
            return result;
        }
        finally
        {
            if (lParamPtr != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(lParamPtr);
            }
        }
    }

    private LRESULT SendMessage<T>(HWND hWnd, uint msg, ref T wParam, LPARAM lParam) where T : struct
    {
        IntPtr wParamPtr = IntPtr.Zero;
        try
        {
            wParamPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(T)));
            Marshal.StructureToPtr(wParam, wParamPtr, false);
            var result = PInvoke.SendMessage(hWnd, msg, (nuint)wParamPtr, lParam);
            wParam = Marshal.PtrToStructure<T>(wParamPtr);
            return result;
        }
        finally
        {
            if (wParamPtr != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(wParamPtr);
            }
        }
    }

    #endregion

    static RichTextBoxEx()
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
    }

    public RichTextBoxEx() : base()
    {
        Multiline = true;
        DetectUrls = false;
        HideSelection = false;
        AcceptsTab = true;   
        ShowSelectionMargin = true;
    }

    protected override void WndProc(ref Message m)
    {
        switch ((uint)m.Msg)
        {
            case PInvoke.WM_SETCURSOR:
                // This enables resize cursor for pictures and table rows / columns, 
                // but breaks the internal WM_SETCURSOR used by RichTextBox to set the hand cursor on link,
                // we need to restore it by handling EN_LINK (see below).
                DefWndProc(ref m);
                break;
            case WM_REFLECT_NOTIFY:
                var pNMHDR = (Windows.Win32.UI.Controls.NMHDR)Marshal.PtrToStructure(m.LParam, typeof(Windows.Win32.UI.Controls.NMHDR));
                if (pNMHDR.code == PInvoke.EN_LINK)
                {
                    var pENLINK = (ENLINK)Marshal.PtrToStructure(m.LParam, typeof(ENLINK));
                    if (pENLINK.msg == PInvoke.WM_LBUTTONDOWN && 
                        ((!RequireCtrlForLinkClick) || ModifierKeys == Keys.Control))
                    {
                        // Link has been clicked and Ctrl is pressed or RequireCtrlForLinkClick is disabled.
                        base.WndProc(ref m);
                    }
                    else if(pENLINK.msg == PInvoke.WM_SETCURSOR && 
                            RequireCtrlForLinkClick && ModifierKeys != Keys.Control)
                    {
                        // Disables hand cursor if Ctrl is not pressed and RequireCtrlForLinkClick is enabled.
                        base.WndProc(ref m);
                    }
                }
                else
                {
                    // The message is not EN_LINK, keep other features as they are.
                    base.WndProc(ref m);
                }
                break;
            case PInvoke.WM_PAINT:
                base.WndProc(ref m);
                // TODO: pagination here
                break;
            default:
                base.WndProc(ref m);
                break;
        }
    }

    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams _params = base.CreateParams;
            // Ensure to use the most recent RichEdit version shipping with Windows.
            _params.ClassName = "RICHEDIT50W";
            return _params;
        }
    }

    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);

        // Enable advanced typography
        PInvoke.SendMessage(hwnd, PInvoke.EM_SETTYPOGRAPHYOPTIONS, PInvoke.TO_ADVANCEDTYPOGRAPHY, (int)PInvoke.TO_ADVANCEDTYPOGRAPHY);
        
        // Enable math
        PInvoke.SendMessage(hwnd, PInvoke.EM_SETEDITSTYLEEX, PInvoke.SES_EX_NOMATH, 0);
        
        // Set 1 as default starting number for lists
        // (can be changed using SelectionListStartingNumber).
        var pf = CreateParaFormat2();
        pf.Base.dwMask = PARAFORMAT_MASK.PFM_NUMBERINGSTART;
        pf.wNumberingStart = 1;
        SendMessage(hwnd, PInvoke.EM_SETPARAFORMAT, PInvoke.SPF_SETDEFAULT, ref pf);
        
        if (!base.AutoWordSelection)
        {
            // Fixes a bug with word selection
            base.AutoWordSelection = true;
            base.AutoWordSelection = false;
        }
    }

    #region Font formatting

    /// <summary>
    /// Gets or sets the font family name of the current text selection or insertion point.
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string SelectionFontName
    {
        get
        {
            var cf = CreateCharFormat2();
            cf.Base.dwMask = CFM_MASK.CFM_FACE;
            var rv = SendMessage(hwnd, PInvoke.EM_GETCHARFORMAT, PInvoke.SCF_SELECTION, ref cf);
            return cf.Base.szFaceName.ToString();
        }
        set
        {
            var cf = CreateCharFormat2();
            cf.Base.dwMask = CFM_MASK.CFM_FACE;
            cf.Base.szFaceName = value;
            SendMessage(hwnd, PInvoke.EM_SETCHARFORMAT, PInvoke.SCF_SELECTION, ref cf);
        }
    }

    /// <summary>
    /// Gets or sets the font size in points of the current text selection or insertion point.
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public float SelectionFontSize
    {
        get
        {
            var cf = CreateCharFormat2();
            cf.Base.dwMask = CFM_MASK.CFM_SIZE;
            var rv = SendMessage(hwnd, PInvoke.EM_GETCHARFORMAT, PInvoke.SCF_SELECTION, ref cf);
            return cf.Base.yHeight / 20.0f; // Convert twips to points
        }
        set
        {
            var cf = CreateCharFormat2();
            cf.Base.dwMask = CFM_MASK.CFM_SIZE;
            cf.Base.yHeight = (int)(value * 20); // Convert points to twips
            SendMessage(hwnd, PInvoke.EM_SETCHARFORMAT, PInvoke.SCF_SELECTION, ref cf);
        }
    }

    /// <summary>
    /// Gets or sets if the bold effect is enabled for the current text selection or insertion point.
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool SelectionIsBold
    {
        get
        {
            var cf = CreateCharFormat2();
            cf.Base.dwMask = CFM_MASK.CFM_BOLD;
            var rv = SendMessage(hwnd, PInvoke.EM_GETCHARFORMAT, PInvoke.SCF_SELECTION, ref cf);
            return cf.Base.dwEffects.HasFlag(CFE_EFFECTS.CFE_BOLD);
        }
        set
        {
            var cf = CreateCharFormat2();
            cf.Base.dwMask = CFM_MASK.CFM_BOLD;
            if (value)
            {
                cf.Base.dwEffects = CFE_EFFECTS.CFE_BOLD;
            }
            SendMessage(hwnd, PInvoke.EM_SETCHARFORMAT, PInvoke.SCF_SELECTION, ref cf);
        }
    }

    /// <summary>
    /// Gets or sets if the italic effect is enabled for the current text selection or insertion point.
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool SelectionIsItalic
    {
        get
        {
            var cf = CreateCharFormat2();
            cf.Base.dwMask = CFM_MASK.CFM_ITALIC;
            var rv = SendMessage(hwnd, PInvoke.EM_GETCHARFORMAT, PInvoke.SCF_SELECTION, ref cf);
            return cf.Base.dwEffects.HasFlag(CFE_EFFECTS.CFE_ITALIC);
        }
        set
        {
            var cf = CreateCharFormat2();
            cf.Base.dwMask = CFM_MASK.CFM_ITALIC;
            if (value)
            {
                cf.Base.dwEffects = CFE_EFFECTS.CFE_ITALIC;
            }
            SendMessage(hwnd, PInvoke.EM_SETCHARFORMAT, PInvoke.SCF_SELECTION, ref cf);
        }
    }

    /// <summary>
    /// Gets or sets if the strikethrough effect is enabled for the current text selection or insertion point.
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool SelectionIsStrikethrough
    {
        get
        {
            var cf = CreateCharFormat2();
            cf.Base.dwMask = CFM_MASK.CFM_STRIKEOUT;
            var rv = SendMessage(hwnd, PInvoke.EM_GETCHARFORMAT, PInvoke.SCF_SELECTION, ref cf);
            return cf.Base.dwEffects.HasFlag(CFE_EFFECTS.CFE_STRIKEOUT);
        }
        set
        {
            var cf = CreateCharFormat2();
            cf.Base.dwMask = CFM_MASK.CFM_STRIKEOUT;
            if (value)
            {
                cf.Base.dwEffects = CFE_EFFECTS.CFE_STRIKEOUT;
            }
            SendMessage(hwnd, PInvoke.EM_SETCHARFORMAT, PInvoke.SCF_SELECTION, ref cf);
        }
    }

    /// <summary>
    /// Gets or sets the underline type (including None) for the current text selection or insertion point.
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public RichTextUnderlineStyle SelectionUnderlineStyle
    {
        get
        {
            var cf = CreateCharFormat2();
            cf.Base.dwMask = CFM_MASK.CFM_UNDERLINETYPE;
            var rv = SendMessage(hwnd, PInvoke.EM_GETCHARFORMAT, PInvoke.SCF_SELECTION, ref cf);
            if (!cf.Base.dwEffects.HasFlag(CFE_EFFECTS.CFE_UNDERLINE))
            {
                return RichTextUnderlineStyle.None;
            }
            else
            {
                return (RichTextUnderlineStyle)cf.bUnderlineType;
            }
        }
        set
        {
            var cf = CreateCharFormat2();
            cf.Base.dwMask = CFM_MASK.CFM_UNDERLINETYPE;
            cf.bUnderlineType = (byte)value;
            SendMessage(hwnd, PInvoke.EM_SETCHARFORMAT, PInvoke.SCF_SELECTION, ref cf);
        }
    }

    /// <summary>
    /// Gets or sets the underline color for the current text selection or insertion point (same as text color by default).
    /// </summary>
    [Browsable(false)]
    [SupportedOSPlatform("windows8.0")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public RichTextUnderlineColor SelectionUnderlineColor
    {
        get
        {
            var cf = CreateCharFormat2();
            cf.Base.dwMask = CFM_MASK.CFM_UNDERLINE | CFM_MASK.CFM_UNDERLINETYPE;
            var rv = SendMessage(hwnd, PInvoke.EM_GETCHARFORMAT, PInvoke.SCF_SELECTION, ref cf);
            return (RichTextUnderlineColor)cf.bUnderlineColor;
        }
        set
        {
            var cf = CreateCharFormat2();
            cf.Base.dwMask = CFM_MASK.CFM_UNDERLINE | CFM_MASK.CFM_UNDERLINETYPE;
            var rv = SendMessage(hwnd, PInvoke.EM_GETCHARFORMAT, PInvoke.SCF_SELECTION, ref cf);            
            cf.bUnderlineColor = (byte)value;
            SendMessage(hwnd, PInvoke.EM_SETCHARFORMAT, PInvoke.SCF_SELECTION, ref cf);
        }
    }

    /// <summary>
    /// Gets or sets if the superscript or subscript effects are enabled for the current text selection or insertion point.
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public RichTextScriptStyle SelectionScriptStyle
    {
        get
        {
            var cf = CreateCharFormat2();
            cf.Base.dwMask = CFM_MASK.CFM_SUBSCRIPT | CFM_MASK.CFM_SUPERSCRIPT;
            var rv = SendMessage(hwnd, PInvoke.EM_GETCHARFORMAT, PInvoke.SCF_SELECTION, ref cf);
            if (cf.Base.dwEffects.HasFlag(CFE_EFFECTS.CFE_SUBSCRIPT))
            {
                return RichTextScriptStyle.Subscript;
            }
            else if (cf.Base.dwEffects.HasFlag(CFE_EFFECTS.CFE_SUPERSCRIPT))
            {
                return RichTextScriptStyle.Superscript;
            }
            return RichTextScriptStyle.Normal;
        }
        set
        {
            var cf = CreateCharFormat2();
            cf.Base.dwMask = CFM_MASK.CFM_SUBSCRIPT | CFM_MASK.CFM_SUPERSCRIPT;
            switch (value)
            {
                case RichTextScriptStyle.Subscript:
                    cf.Base.dwEffects = CFE_EFFECTS.CFE_SUBSCRIPT;
                    break;
                case RichTextScriptStyle.Superscript:
                    cf.Base.dwEffects = CFE_EFFECTS.CFE_SUPERSCRIPT;
                    break;
                case RichTextScriptStyle.Normal:
                    cf.Base.dwEffects = 0;
                    break;
            }
            SendMessage(hwnd, PInvoke.EM_SETCHARFORMAT, PInvoke.SCF_SELECTION, ref cf);
        }
    }

    /// <summary>
    /// Gets or sets if the Small caps or All caps effects are enabled for the current text selection or insertion point.
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public RichTextCapStyle SelectionCapStyle
    {
        get
        {
            var cf = CreateCharFormat2();
            cf.Base.dwMask = CFM_MASK.CFM_SMALLCAPS | CFM_MASK.CFM_ALLCAPS;
            var rv = SendMessage(hwnd, PInvoke.EM_GETCHARFORMAT, PInvoke.SCF_SELECTION, ref cf);
            if (cf.Base.dwEffects.HasFlag(CFE_EFFECTS.CFE_ALLCAPS))
            {
                return RichTextCapStyle.AllCaps;
            }
            else if (cf.Base.dwEffects.HasFlag(CFE_EFFECTS.CFE_SMALLCAPS))
            {
                return RichTextCapStyle.SmallCaps;
            }
            return RichTextCapStyle.Standard;
        }
        set
        {
            var cf = CreateCharFormat2();
            cf.Base.dwMask = CFM_MASK.CFM_SMALLCAPS | CFM_MASK.CFM_ALLCAPS;
            switch (value)
            {
                case RichTextCapStyle.AllCaps:
                    cf.Base.dwEffects = CFE_EFFECTS.CFE_ALLCAPS;
                    break;
                case RichTextCapStyle.SmallCaps:
                    cf.Base.dwEffects = CFE_EFFECTS.CFE_SMALLCAPS;
                    break;
                case RichTextCapStyle.Standard:
                    cf.Base.dwEffects = 0;
                    break;
            }
            SendMessage(hwnd, PInvoke.EM_SETCHARFORMAT, PInvoke.SCF_SELECTION, ref cf);
        }
    }

    /// <summary>
    /// Gets or sets the characters spacing for the current text selection or insertion point.
    /// Displayed text typically has an intercharacter spacing value of zero. 
    /// Positive values expand the spacing, and negative values compress it.
    /// It can be set to a <see cref="RichTextFontStretch"/> value or custom float value 
    /// (in this case values between -4 and 4 are recommended for most fonts.)
    /// Note: some fonts don't support spacing.
    /// </summary>
    [Browsable(false)]
    [SupportedOSPlatform("windows8.0")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public float SelectionFontStretch
    {
        get
        {
            GetSelectedTextRangeFont().GetSpacing(out float spacing);
            return spacing * 2;
        }
        set
        {
            var font = GetSelectedTextRangeFont();
            font.SetSpacing(value / 2);
            SetSelectedTextRangeFont(font);
        }
    }

    /// <summary>
    /// Gets or sets whether the selected characters have a shadow effect.
    /// </summary>
    [Browsable(false)]
    [SupportedOSPlatform("windows8.0")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool SelectionShadow
    {
        get
        {
            GetSelectedTextRangeFont().GetShadow(out var isShadow);
            return isShadow == (int)tomConstants.tomTrue;
        }
        set
        {
            var font = GetSelectedTextRangeFont();
            font.SetShadow(value ? (int)tomConstants.tomTrue :
                       (int)tomConstants.tomFalse);           
            SetSelectedTextRangeFont(font);
        }
    }

    #endregion

    #region Paragraph formatting

    /// <summary>
    /// Gets or sets the alignment (left, center, right or justified) of paragraphs containing the current selection or insertion point.
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public new RichTextAlignment SelectionAlignment
    {
        get
        {
            var pf = CreateParaFormat2();
            pf.Base.dwMask = PARAFORMAT_MASK.PFM_ALIGNMENT;
            SendMessage(hwnd, PInvoke.EM_GETPARAFORMAT, 0, ref pf);
            return (RichTextAlignment)pf.Base.wAlignment;
        }
        set
        {
            var pf = CreateParaFormat2();
            pf.Base.dwMask = PARAFORMAT_MASK.PFM_ALIGNMENT;
            pf.Base.wAlignment = (PARAFORMAT_ALIGNMENT)value;
            SendMessage(hwnd, PInvoke.EM_SETPARAFORMAT, 0, ref pf);
        }
    }

    /// <summary>
    ///  The distance (in points) between the left edge of the RichTextBox control and
    ///  the left edge of the selected paragraph(s).
    /// </summary>
    public new int SelectionIndent
    {
        get
        {
            var pf = CreateParaFormat2();
            pf.Base.dwMask = PARAFORMAT_MASK.PFM_STARTINDENT;
            SendMessage(hwnd, PInvoke.EM_GETPARAFORMAT, 0, ref pf);
            return pf.Base.dxStartIndent / 20;
        }
        set
        {
            var pf = CreateParaFormat2();
            pf.Base.dwMask = PARAFORMAT_MASK.PFM_STARTINDENT;
            pf.Base.dxStartIndent = value * 20;
            SendMessage(hwnd, PInvoke.EM_SETPARAFORMAT, 0, ref pf);
        }
    }

    /// <summary>
    ///  The distance (in points) between the right edge of the RichTextBox control and
    ///  the right edge of the selected paragraph(s).
    /// </summary>
    public new int SelectionRightIndent
    {
        get
        {
            var pf = CreateParaFormat2();
            pf.Base.dwMask = PARAFORMAT_MASK.PFM_RIGHTINDENT;
            SendMessage(hwnd, PInvoke.EM_GETPARAFORMAT, 0, ref pf);
            return pf.Base.dxRightIndent / 20;
        }
        set
        {
            var pf = CreateParaFormat2();
            pf.Base.dwMask = PARAFORMAT_MASK.PFM_RIGHTINDENT;
            pf.Base.dxRightIndent = value * 20;
            SendMessage(hwnd, PInvoke.EM_SETPARAFORMAT, 0, ref pf);
        }
    }

    /// <summary>
    /// The distance (in points) between the left edge of the first line of text
    /// in the selected paragraph(s) (as specified by the SelectionIndent property)
    /// and the left edge of subsequent lines of text in the same paragraph(s).
    /// If the value is negative, the first line should be indented of at least the same amount in order to
    /// display the subsequent lines as outdented.
    /// </summary>
    public new int SelectionHangingIndent
    {
        get
        {
            var pf = CreateParaFormat2();
            pf.Base.dwMask = PARAFORMAT_MASK.PFM_OFFSET;
            SendMessage(hwnd, PInvoke.EM_GETPARAFORMAT, 0, ref pf);
            return pf.Base.dxOffset / 20;
        }
        set
        {
            var pf = CreateParaFormat2();
            pf.Base.dwMask = PARAFORMAT_MASK.PFM_OFFSET;
            pf.Base.dxOffset = value * 20;
            SendMessage(hwnd, PInvoke.EM_SETPARAFORMAT, 0, ref pf);
        }
    }

    /// <summary>
    /// Gets or sets the space before the current paragraph in typographic points (1/72 of inches).
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public int SelectionParagraphSpaceBefore
    {
        get
        {
            var pf = CreateParaFormat2();
            pf.Base.dwMask = PARAFORMAT_MASK.PFM_SPACEBEFORE;
            SendMessage(hwnd, PInvoke.EM_GETPARAFORMAT, 0, ref pf);
            return pf.dySpaceBefore / 20;
        }
        set
        {
            var pf = CreateParaFormat2();
            pf.Base.dwMask = PARAFORMAT_MASK.PFM_SPACEBEFORE;
            pf.dySpaceBefore = value * 20;
            SendMessage(hwnd, PInvoke.EM_SETPARAFORMAT, 0, ref pf);
        }
    }

    /// <summary>
    /// Gets or sets the space after the current paragraph in typographic points (1/72 of inches).
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public int SelectionParagraphSpaceAfter
    {
        get
        {
            var pf = CreateParaFormat2();
            pf.Base.dwMask = PARAFORMAT_MASK.PFM_SPACEAFTER;
            SendMessage(hwnd, PInvoke.EM_GETPARAFORMAT, 0, ref pf);
            return pf.dySpaceAfter / 20;
        }
        set
        {
            var pf = CreateParaFormat2();
            pf.Base.dwMask = PARAFORMAT_MASK.PFM_SPACEAFTER;
            pf.dySpaceAfter = value * 20;
            SendMessage(hwnd, PInvoke.EM_SETPARAFORMAT, 0, ref pf);
        }
    }

    /// <summary>
    /// Gets or sets the line spacing for the current paragraph.
    /// This value is interpreted based on the SelectionLineSpacingRule property.
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public RichTextLineSpacing SelectionLineSpacing
    {
        // https://learn.microsoft.com/en-us/windows/win32/api/richedit/ns-richedit-paraformat2#members
        get
        {
            var pf = CreateParaFormat2();
            pf.Base.dwMask = PARAFORMAT_MASK.PFM_LINESPACING;
            SendMessage(hwnd, PInvoke.EM_GETPARAFORMAT, 0, ref pf);
            switch (pf.bLineSpacingRule)
            {
                case 0:
                    return new SingleLineSpacing();
                case 1:
                    return new OneAndHalfLineSpacing();
                case 2:
                    return new DoubleLineSpacing();
                // For the following case, don't use the public constructor as it expects a value in points,
                // but set the internal value in twips directly.
                case 3:
                    return new MinimumLineSpacing() { SpacingValue = pf.dyLineSpacing };
                case 4:
                    return new ExactLineSpacing() { SpacingValue = pf.dyLineSpacing };
                case 5:
                    return new MultipleLineSpacing() { SpacingValue = pf.dyLineSpacing };
                default:
                    return new SingleLineSpacing();
            }
        }
        set
        {
            var pf = CreateParaFormat2();
            pf.Base.dwMask = PARAFORMAT_MASK.PFM_LINESPACING;
            pf.bLineSpacingRule = value.SpacingRule;
            pf.dyLineSpacing = value.SpacingValue;
            SendMessage(hwnd, PInvoke.EM_SETPARAFORMAT, 0, ref pf);
        }
    }

    #endregion

    #region Default paragraph formatting

    private int _defaultLeftIndent = 0;
    private int _defaultRightIndent = 0;
    private int _defaultHangingIndent = 0;
    private int _defaultSpaceBefore = 0;
    private int _defaultSpaceAfter = 0;
    private RichTextLineSpacing? _defaultLineSpacing = null;

    /// <summary>
    ///  The default distance (in points) between the left edge of the RichTextBox control and
    ///  the left edge of new paragraphs.
    /// </summary>
    public int DefaultIndent
    {
        get
        {
            return _defaultLeftIndent;
        }
        set
        {
            _defaultLeftIndent = value * 20;
            var pf = CreateParaFormat2();
            pf.Base.dwMask = PARAFORMAT_MASK.PFM_STARTINDENT;
            pf.Base.dxStartIndent = _defaultLeftIndent;
            SendMessage(hwnd, PInvoke.EM_SETPARAFORMAT, PInvoke.SPF_SETDEFAULT, ref pf);
        }
    }

    /// <summary>
    ///  The default distance (in points) between the right edge of the RichTextBox control and
    ///  the right edge of new paragraphs.
    /// </summary>
    public int DefaultRightIndent
    {
        get
        {
            return _defaultRightIndent;
        }
        set
        {
            _defaultRightIndent = value * 20;
            var pf = CreateParaFormat2();
            pf.Base.dwMask = PARAFORMAT_MASK.PFM_RIGHTINDENT;
            pf.Base.dxRightIndent = _defaultRightIndent;
            SendMessage(hwnd, PInvoke.EM_SETPARAFORMAT, PInvoke.SPF_SETDEFAULT, ref pf);
        }
    }

    /// <summary>
    /// The default distance (in points) between the left edge of the first line of text
    /// for new parapraphs (as specified by the SelectionIndent property)
    /// and the left edge of subsequent lines of text in the same paragraph(s).
    /// If the value is negative, the first line should be indented of at least the same amount in order to
    /// display the subsequent lines as outdented.
    /// </summary>
    public int DefaultHangingIndent
    {
        get
        {
            return _defaultHangingIndent;
        }
        set
        {
            _defaultHangingIndent = value * 20;
            var pf = CreateParaFormat2();
            pf.Base.dwMask = PARAFORMAT_MASK.PFM_OFFSET;
            pf.Base.dxOffset = _defaultHangingIndent;
            SendMessage(hwnd, PInvoke.EM_SETPARAFORMAT, PInvoke.SPF_SETDEFAULT, ref pf);
        }
    }

    /// <summary>
    /// Gets or sets the default space before paragraphs in typographic points (1/72 of inches).
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public int DefaultParagraphSpaceBefore
    {
        get
        {
            return _defaultSpaceBefore;
        }
        set
        {
            _defaultSpaceBefore = value * 20;
            var pf = CreateParaFormat2();
            pf.Base.dwMask = PARAFORMAT_MASK.PFM_SPACEBEFORE;
            pf.dySpaceBefore = _defaultSpaceBefore;
            SendMessage(hwnd, PInvoke.EM_SETPARAFORMAT, PInvoke.SPF_SETDEFAULT, ref pf);
        }
    }

    /// <summary>
    /// Gets or sets the default space after paragraphs in typographic points (1/72 of inches).
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public int DefaultParagraphSpaceAfter
    {
        get
        {
            return _defaultSpaceAfter;
        }
        set
        {
            _defaultSpaceAfter = value * 20;
            var pf = CreateParaFormat2();
            pf.Base.dwMask = PARAFORMAT_MASK.PFM_SPACEAFTER;
            pf.dySpaceAfter = _defaultSpaceAfter;
            SendMessage(hwnd, PInvoke.EM_SETPARAFORMAT, PInvoke.SPF_SETDEFAULT, ref pf);
        }
    }
   
    /// <summary>
    /// Gets or sets the default line spacing for paragraphs.
    /// This value is interpreted based on the DefaultLineSpacingRule property.
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public RichTextLineSpacing DefaultLineSpacing
    {
        get
        {
            return _defaultLineSpacing ?? new SingleLineSpacing();
        }
        set
        {
            _defaultLineSpacing = value;
            var pf = CreateParaFormat2();
            pf.Base.dwMask = PARAFORMAT_MASK.PFM_LINESPACING;
            pf.bLineSpacingRule = value.SpacingRule;
            pf.dyLineSpacing = value.SpacingValue;
            SendMessage(hwnd, PInvoke.EM_SETPARAFORMAT, PInvoke.SPF_SETDEFAULT, ref pf);
        }
    }

    #endregion

    #region Lists

    /// <summary>
    /// Gets or sets the list type (none, bulleted, numbered, letter-numbered) for the current selection or insertion point.
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public RichTextListType SelectionListType
    {
        get
        {
            var pf = CreateParaFormat2();
            pf.Base.dwMask = PARAFORMAT_MASK.PFM_NUMBERING;
            SendMessage(hwnd, PInvoke.EM_GETPARAFORMAT, 0, ref pf);
            // Check if value is in the standard list types enum.
            if ((int)pf.Base.wNumbering <= 23)
            {
                return (RichTextListType)pf.Base.wNumbering;
            }
            else
            {
                return RichTextListType.Bullet;
            }
        }
        set
        {
            if (value != SelectionListType)
            {
                var pf = CreateParaFormat2();
                pf.Base.dwMask = PARAFORMAT_MASK.PFM_NUMBERING;
                switch (value)
                {
                    case RichTextListType.None:
                        pf.Base.wNumbering = 0;
                        break;
                    default:
                        pf.Base.wNumbering = (PARAFORMAT_NUMBERING)value;
                        break;
                }
                SendMessage(hwnd, PInvoke.EM_SETPARAFORMAT, 0, ref pf);
            }
        }
    }  
    
    /// <summary>
    /// Get or sets the char to use for bulleted lists. 
    /// When retrieving the value, returns '\0' (NUL) if the current paragraph or insertion point is not a bulleted list.
    /// When setting the value, the paragraph is converted to a bulleted list and a valid non-control char must be used.
    /// </summary>
    public char SelectionListBulletChar
    {
        get
        {
            var pf = CreateParaFormat2();
            pf.Base.dwMask = PARAFORMAT_MASK.PFM_NUMBERING;
            SendMessage(hwnd, PInvoke.EM_GETPARAFORMAT, 0, ref pf);
            // Check if value is in the standard list types enum.            
            if (pf.Base.wNumbering == PARAFORMAT_NUMBERING.PFN_BULLET)
            {
                // Default bullet list
                return '•';
            }
            else if ((int)pf.Base.wNumbering <= 23)
            {
                // Not a bulleted list
                return '\0';
            }
            else
            {
                // Custom char
                return (char)pf.Base.wNumbering;
            }
        }
        set
        {
            // Control chars are not valid for bulleted lists.
            if (value < 0x21 || (value > 0x7E && value < 0xA1))
            {
                throw new Exception("Invalid bullet char.");
            }
            else
            {
                var pf = CreateParaFormat2();
                pf.Base.dwMask = PARAFORMAT_MASK.PFM_NUMBERING;
                pf.Base.wNumbering = (PARAFORMAT_NUMBERING)value;
                SendMessage(hwnd, PInvoke.EM_SETPARAFORMAT, 0, ref pf);
            }
        }
    }

    /// <summary>
    /// Gets or sets the number style (plain, period or parenthesis) for list items containing the current selection or insertion point.
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public RichTextListNumberStyle SelectionListNumberStyle
    {
        get
        {
            var pf = CreateParaFormat2();
            pf.Base.dwMask = PARAFORMAT_MASK.PFM_NUMBERINGSTYLE;
            SendMessage(hwnd, PInvoke.EM_GETPARAFORMAT, 0, ref pf);
            return (RichTextListNumberStyle)pf.wNumberingStyle;
        }
        set
        {
            var pf = CreateParaFormat2();
            pf.Base.dwMask = PARAFORMAT_MASK.PFM_NUMBERINGSTYLE;
            pf.wNumberingStyle = (PARAFORMAT_NUMBERING_STYLE)value;
            SendMessage(hwnd, PInvoke.EM_SETPARAFORMAT, 0, ref pf);
        }
    }

    /// <summary>
    /// Gets or sets the first number of the numbered list starting at the current selection or insertion point 
    /// (1 by default).
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DefaultValue(1)]
    public ushort SelectionListStartingNumber
    {
        get
        {
            var pf = CreateParaFormat2();
            pf.Base.dwMask = PARAFORMAT_MASK.PFM_NUMBERINGSTART;
            SendMessage(hwnd, PInvoke.EM_GETPARAFORMAT, 0, ref pf);
            return pf.wNumberingStart;
        }
        set
        {
            var pf = CreateParaFormat2();
            pf.Base.dwMask = PARAFORMAT_MASK.PFM_NUMBERINGSTART;
            pf.wNumberingStart = value;
            SendMessage(hwnd, PInvoke.EM_SETPARAFORMAT, 0, ref pf);
        }
    }

    /// <summary>
    /// Gets or sets bullet-text distance (in points) 
    /// for list items containing the current selection or insertion point.
    /// New subsequent list items inherit this property.
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ushort SelectionBulletTextDistance
    {
        get
        {
            var pf = CreateParaFormat2();
            pf.Base.dwMask = PARAFORMAT_MASK.PFM_NUMBERINGTAB;
            SendMessage(hwnd, PInvoke.EM_GETPARAFORMAT, 0, ref pf);
            return (ushort)(pf.wNumberingTab / 20);
        }
        set
        {
            var pf = CreateParaFormat2();
            pf.Base.dwMask = PARAFORMAT_MASK.PFM_NUMBERINGTAB;
            pf.wNumberingTab = (ushort)(value * 20);
            SendMessage(hwnd, PInvoke.EM_SETPARAFORMAT, 0, ref pf);
        }
    }

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("SelectionListType should be used instead of SelectionBullet.")]
    public new bool SelectionBullet
    {
        get
        {
            return SelectionListType != RichTextListType.None;
        }
        set 
        {
            // Call the base class as it uses an internal value for BulletIndent.
            // The SelectionListType property does not consider BulletIndent,
            // as the bullet-text distance is set using a separate PARAFORMAT member (wNumberingTab).
            base.SelectionBullet = value;
        }
    }

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("SelectionBulletTextDistance and SelectionIndent should be used instead of BulletIndent.")]
    public new int BulletIndent
    {
        get
        {
            return base.BulletIndent;
        }
        set
        {            
            base.BulletIndent = value;
        }
    }

    #endregion

    #region Hyperlinks

    /// <summary>
    /// Gets or sets if the LinkClicked event and the hand cursor should only be triggered when Ctrl is pressed.
    /// </summary>
    public bool RequireCtrlForLinkClick { get; set; } = false;

    /// <summary>
    /// Gets or sets the hyperlink URL for the current selection. 
    /// If an empty string is set, any hyperlink is removed from the selection leaving the displayed text as is.
    /// If selection is empty but the caret is inside an hyperlink, that hyperlink is assumed as selection and the URL can be retrieved, changed or removed.
    /// If selection is empty and the caret is not inside an hyperlink, setting this property has no effect (you should select a range first).
    /// </summary>
    [Browsable(false)]
    [SupportedOSPlatform("windows8.0")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string SelectionHyperlinkUrl
    {
        get
        {
            var ptr = IntPtr.Zero;
            unsafe
            {
                IntPtr* pBstr = &ptr;
                GetSelectedTextRange().GetURL((BSTR*)pBstr);
            }
            return ptr == IntPtr.Zero ? string.Empty : Marshal.PtrToStringBSTR(ptr).Trim('"');
        }
        set
        {
            if (this.SelectionLength > 0 || SelectionHyperlinkUrl != string.Empty)
            {
                string url = $"\"{value}\"";
                var range = GetSelectedTextRange();
                if (range != null)
                {
                    unsafe
                    {
                        var ptr = Marshal.StringToBSTR(url);
                        range.SetURL((BSTR)ptr);
                    }
                }
            }
        }
    }

    /// <summary>
    /// Gets or sets the display text for the hyperlink contained in the current selection or insertion point (if any).
    /// This may not be the same as SelectedVisibleText if selection is collapsed to caret or only part of the hyperlink is selected.
    /// </summary>
    [Browsable(false)]
    [SupportedOSPlatform("windows8.0")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string SelectionHyperlinkDisplayText
    {
        get 
        {
            var ptr = IntPtr.Zero;
            var range = GetSelectedTextRange();
            if (range != null)
            {
                ((ITextRange)range).Expand((int)tomConstants.tomLink, out int delta);
                unsafe
                {
                    IntPtr* pBstr = &ptr;
                    range.GetText2((int)tomConstants.tomNoHidden, (BSTR*)pBstr);
                }
            }
            return ptr == IntPtr.Zero ? string.Empty : Marshal.PtrToStringBSTR(ptr);
        }
        set
        {
            var range = GetSelectedTextRange();
            range.Expand((int)tomConstants.tomLink, out int delta);
            if (range != null && !string.IsNullOrEmpty(value))
            {
                unsafe
                {
                    var ptr = Marshal.StringToBSTR(value);
                    range.SetText((BSTR)ptr);
                }
            }
        }
    }

    /// <summary>
    /// Checks whether the current selection or insertion point has an hyperlink.
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool SelectionHasLink
    {
        get
        {
            var cf = CreateCharFormat2();
            cf.Base.dwMask = CFM_MASK.CFM_LINK | CFM_MASK.CFM_LINKPROTECTED;
            SendMessage(hwnd, PInvoke.EM_GETCHARFORMAT, PInvoke.SCF_SELECTION, ref cf);
            return cf.Base.dwEffects.HasFlag(CFM_MASK.CFM_LINK) ||
                   cf.Base.dwEffects.HasFlag(CFE_EFFECTS.CFE_LINKPROTECTED);
        }
    }

    /// <summary>
    /// Gets all the text in the RichTextBox control, without hidden text.
    /// </summary>
    [SupportedOSPlatform("windows8.0")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string VisibleText
    {
        get
        {
            var ptr = IntPtr.Zero;
            unsafe
            {
                IntPtr* pBstr = &ptr;
                GetDocumentTextRange().GetText2((int)tomConstants.tomNoHidden, (BSTR*)pBstr);
            }
            return ptr == IntPtr.Zero ? string.Empty : Marshal.PtrToStringBSTR(ptr);
        }
    }

    /// <summary>
    /// Gets the selected text of the current selection, without hidden text.
    /// </summary>
    [SupportedOSPlatform("windows8.0")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string SelectedVisibleText
    {
        get
        {
            var ptr = IntPtr.Zero;
            unsafe
            {
                IntPtr* pBstr = &ptr;
                GetSelectedTextRange().GetText2((int)tomConstants.tomNoHidden, (BSTR*)pBstr);
            }
            return ptr == IntPtr.Zero ? string.Empty : Marshal.PtrToStringBSTR(ptr);
        }
    }

    #endregion

    #region Images

    // Constants for image insertion
    private const int MM_ISOTROPIC = 7; // keep 1:1 aspect ratio
    private const int MM_ANISOTROPIC = 8; // adjust x and y separately
    private const int HMM_PER_INCH = 2540; // himetrics per inch
    private const int TWIPS_PER_INCH = 1440; // twips per inch

    /// <summary>
    /// Inserts an image, replacing the current selection if any.
    /// </summary>
    public void InsertImage(string filePath)
    {
        InsertImage(Image.FromFile(filePath));
    }

    /// <summary>
    /// Inserts an image, replacing the current selection if any.
    /// </summary>
    public void InsertImage(Stream stream)
    {
        InsertImage(Image.FromStream(stream));
    }

    /// <summary>
    /// Inserts an image, replacing the current selection if any.
    /// </summary>
    public void InsertImage(byte[] bytes)
    {
        using (var ms = new MemoryStream(bytes))
        {
            InsertImage(Image.FromStream(ms));
        }
    }

    /// <summary>
    /// Inserts an image, replacing the current selection if any.
    /// </summary>
    public void InsertImage(Image image)
    {
        InsertImage(image, image.Width, image.Height);
    }

    /// <summary>
    /// Inserts an image, replacing the current selection if any, using the specified width and height.
    /// </summary>
    public void InsertImage(string filePath, int width, int height)
    {
        InsertImage(Image.FromFile(filePath), width, height);
    }

    /// <summary>
    /// Inserts an image, replacing the current selection if any, using the specified width and height.
    /// </summary>
    public void InsertImage(Stream stream, int width, int height)
    {
        InsertImage(Image.FromStream(stream), width, height);
    }

    /// <summary>
    /// Inserts an image, replacing the current selection if any, using the specified width and height.
    /// </summary>
    public void InsertImage(byte[] bytes, int width, int height)
    {
        using (var ms = new MemoryStream(bytes))
        {
            InsertImage(Image.FromStream(ms), width, height);
        }
    }

    /// <summary>
    /// Inserts an image, replacing the current selection if any, using the specified width and height.
    /// </summary>
    public void InsertImage(Image image, int width, int height)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(@"{\rtf1\ansi\ansicpg1252\deff0\deflang1033\uc1");
        sb.Append(@"{\pict\wmetafile8");
        sb.Append(GetImagePrefix(width, height));
        sb.Append(GetRtfImage(image, width, height));
        sb.Append("} }");
        this.SelectedRtf = sb.ToString();
    }

    private string GetImagePrefix(int width, int height)
    {
        // get RTF prefix for image
        StringBuilder sb = new StringBuilder();
        using (Graphics gr = this.CreateGraphics())
        {
            // current width of the image in himetrics
            int picw = (int)Math.Round((width / (double)gr.DpiX) * HMM_PER_INCH);
            sb.Append(@"\picw"); 
            sb.Append(picw);
            // current height of the image himetrics
            int pich = (int)Math.Truncate((height / (double)gr.DpiY) * HMM_PER_INCH);
            sb.Append(@"\pich"); 
            sb.Append(pich);
            // target width of the image in twips
            int picwgoal = (int)Math.Round((width / (double)gr.DpiX) * TWIPS_PER_INCH);
            sb.Append(@"\picwgoal"); 
            sb.Append(picwgoal);
            // target height of the image in twips
            int pichgoal = (int)Math.Round((height / (double)gr.DpiY) * TWIPS_PER_INCH);
            sb.Append(@"\pichgoal"); 
            sb.Append(pichgoal); 
            sb.Append(" ");
        }
        return sb.ToString();
    }

    private string GetRtfImage(Image image, int width, int height)
    {
        // Build RTF for image info
        // Store enhanced metafile in memory stream
        Metafile? mf = null;
        using (var ms = new MemoryStream())
        {
            try
            {
                StringBuilder sb = new StringBuilder(); 
                // get graphics content from RichTextBox
                using (Graphics gr = this.CreateGraphics())
                {
                    // create enhanced metafile from the graphics context
                    IntPtr hDC = gr.GetHdc();
                    mf = new Metafile(ms, hDC); gr.ReleaseHdc(hDC);
                }
                // Get a graphics context from the Enhanced Metafile
                using (Graphics gr = Graphics.FromImage(mf))
                {
                    // Draw image onto metafile
                    gr.DrawImage(image, new Rectangle(0, 0, width, height));
                }
                // Get the handle of the Enhanced Metafile
                IntPtr mfHandle = mf.GetHenhmetafile();
                // get size of buffer for metafile info

                uint _bufferSize = GdipEmfToWmfBits(mfHandle, 0, null, MM_ANISOTROPIC, (int)EmfToWmfBitsFlags.EmfToWmfBitsFlagsDefault);
                byte[] _buffer = new byte[_bufferSize];
                //byte[] _buffer = new byte[_bufferSize - 1];
                // copy metafile info into buffer and get actual size
                uint _convertedSize = GdipEmfToWmfBits(mfHandle, _bufferSize, _buffer, MM_ANISOTROPIC, EmfToWmfBitsFlags.EmfToWmfBitsFlagsDefault);
                // copy buffer contents into string of hex values
                for (int index = 0; index < _buffer.Length; index++)
                    sb.Append(string.Format("{0:X2}", _buffer[index]));
                DeleteEnhMetaFile(mfHandle); // prevents memory leak
                return sb.ToString();
            }
            finally
            {
                // handle metafile disposal
                if (mf != null)
                    mf.Dispose();
            }
        }
    }

    [DllImport("gdiplus.dll")]
    private static extern uint GdipEmfToWmfBits(IntPtr mfHandle, uint _bufferSize, byte[]? _buffer, int _mappingMode, EmfToWmfBitsFlags _flags);

    [DllImport("gdi32.dll")]
    private static extern bool DeleteEnhMetaFile(IntPtr hemf);

    #endregion

    #region Tables

    /// <summary>
    /// Inserts a table, replacing the current selection if any.
    /// </summary>
    public void InsertTable(int rows, int columns)
    {
        if (rows < 1 || columns < 1 || rows > 10 || columns > 10)
        {
            throw new Exception("Rows and columns number has to be between 1 and 10.");
        }

        var tableSb = new StringBuilder();

        //Beginning of rich text format,don't alter this line
        tableSb.Append(@"{\rtf1 ");

        //Create rows columns
        for (int i = 0; i < rows; i++)
        {
            //Start the row
            tableSb.Append(@"\trowd");

            for (int j = 1; j <= columns; j++)
            {
                //Insert cells with width = 1000. Columns can be resized at runtime
                tableSb.Append($@"\cellx{j}000");
            }

            //Append the row in StringBuilder
            tableSb.Append(@"\intbl \cell \row"); //create the row
        }

        tableSb.Append(@"\pard");

        tableSb.Append(@"}");

        var tableString = tableSb.ToString();

        SelectedRtf = tableString;

    }

    #endregion

    #region OLE

    internal ITextDocument2? ITextDocument2Value = null;
    internal IntPtr ITextDocument2Ptr = IntPtr.Zero;
    internal IRichEditOle? IRichEditOleValue = null;
    internal IntPtr IRichEditOlePtr = IntPtr.Zero;

    internal IRichEditOle? GetRichEditOleInterface()
    {
        if (this.IRichEditOleValue == null)
        {
            // Allocate the ptr that EM_GETOLEINTERFACE will fill in
            IntPtr ptr = Marshal.AllocCoTaskMem(Marshal.SizeOf(typeof(IntPtr)));  // Alloc the ptr.
            Marshal.WriteIntPtr(ptr, IntPtr.Zero);                                    // Clear it.
            try
            {
                if (PInvoke.SendMessage(hwnd, PInvoke.EM_GETOLEINTERFACE, 0, ptr) != 0)
                {
                    // Read the returned pointer
                    IntPtr pRichEdit = Marshal.ReadIntPtr(ptr);
                    try
                    {
                        if (pRichEdit != IntPtr.Zero)
                        {
                            // Query for the IRichEditOle interface
                            var guid = typeof(IRichEditOle).GUID;
                            Marshal.QueryInterface(pRichEdit, ref guid, out this.IRichEditOlePtr);

                            // Wrap it in the C# interface for IRichEditOle
                            this.IRichEditOleValue = (IRichEditOle)Marshal.GetTypedObjectForIUnknown(this.IRichEditOlePtr, typeof(IRichEditOle));

                            if (this.IRichEditOleValue == null)
                            {
                                throw new Exception("Failed to get the object wrapper for the IRichEditOle interface.");
                            }

                            guid = typeof(ITextDocument2).GUID;
                            Marshal.QueryInterface(pRichEdit, ref guid, out this.ITextDocument2Ptr);

                            // Wrap it in the C# interface for IRichEditOle
                            this.ITextDocument2Value = (ITextDocument2)Marshal.GetTypedObjectForIUnknown(this.ITextDocument2Ptr, typeof(ITextDocument2));

                            if (this.ITextDocument2Value == null)
                            {
                                throw new Exception("Failed to get the object wrapper for the ITextDocument interface.");
                            }
                        }
                        else
                        {
                            throw new Exception("Failed to get the pointer.");
                        }
                    }
                    finally
                    {
                        Marshal.Release(pRichEdit);
                    }
                }
                else
                {
                    // A 0 return value means EM_GETOLEINTERFACE failed.
                    throw new Exception("EM_GETOLEINTERFACE failed.");
                }
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine(err.ToString());
                this.ReleaseRichEditOleInterface();
            }
            finally
            {
                // Free the ptr memory
                Marshal.FreeCoTaskMem(ptr);
            }
        }

        return this.IRichEditOleValue;
    }

    internal void ReleaseRichEditOleInterface()
    {
        if (this.IRichEditOlePtr != IntPtr.Zero)
        {
            Marshal.Release(this.IRichEditOlePtr);
        }

        this.IRichEditOlePtr = IntPtr.Zero;
        this.IRichEditOleValue = null;
    }

    #endregion

    #region TOM

    [SupportedOSPlatform("windows8.0")]
    internal ITextDocument2 GetTextDocument()
    {
        if (ITextDocument2Value is null)
        {         
            var richEditOle = GetRichEditOleInterface();
            if (richEditOle == null)
            {
                throw new Exception("Unable to get IRichEditOle interface.");
            }
        }
        return ITextDocument2Value!;
    }

    [SupportedOSPlatform("windows8.0")]
    internal ITextRange2 GetDocumentTextRange()
    {
        GetTextDocument().Range2(0, -1, out ITextRange2 range);
        return range;
    }

    [SupportedOSPlatform("windows8.0")]
    internal ITextSelection2 GetSelectedTextRange()
    {
        GetTextDocument().GetSelection2(out ITextSelection2 selection);
        return selection;
    }

    [SupportedOSPlatform("windows8.0")]
    internal ITextFont2 GetSelectedTextRangeFont()
    {
        GetTextDocument().GetSelection2(out ITextSelection2 selection);
        selection.GetFont2(out ITextFont2 font);
        return font;
    }

    [SupportedOSPlatform("windows8.0")]
    internal void SetSelectedTextRangeFont(ITextFont2 font2)
    {
        GetTextDocument().GetSelection2(out ITextSelection2 selection);
        selection.SetFont2(font2);       
    }

    [SupportedOSPlatform("windows8.0")]
    internal ITextPara2 GetSelectedTextRangeParagraph()
    {
        GetTextDocument().GetSelection2(out ITextSelection2 selection);
        selection.GetPara2(out ITextPara2 paragraph);
        return paragraph;
    }

    //[SupportedOSPlatform("windows10.0")]
    //public void InsertMath(string math)
    //{
    //    var range = GetSelectedTextRange();
    //    if (range != null)
    //    {
    //        unsafe
    //        {
    //            var ptr = Marshal.StringToBSTR(math);
    //            range.SetText((BSTR)ptr);
    //        }
    //        //range.GetFont2(out var font);
    //        //font.SetMathZone((int)tomConstants.tomTrue);
    //        //range.SetFont2(font);
    //        range.BuildUpMath(0);
    //    }
    //}

    #endregion

    #region Spell check

    /// <summary>
    /// Enables or disables spell check for the current keyboard language.
    /// </summary>
    [SupportedOSPlatform("windows8.0")]
    public bool IsSpellCheckEnabled
    {
        get
        {
            var langOptions = PInvoke.SendMessage(hwnd, PInvoke.EM_GETLANGOPTIONS, 0, 0);
            return (langOptions.Value & PInvoke.IMF_SPELLCHECKING) == PInvoke.IMF_SPELLCHECKING;
        }
        set
        {
            var res = PInvoke.SendMessage(hwnd, PInvoke.EM_GETLANGOPTIONS, 0, 0);
            var langOptions = (uint)res.Value;
            if (value)
            {
                langOptions |= PInvoke.IMF_SPELLCHECKING;
            }
            else
            {
                langOptions &= ~PInvoke.IMF_SPELLCHECKING;
            }
            PInvoke.SendMessage(hwnd, PInvoke.EM_SETLANGOPTIONS, 0, (int)langOptions);
        }
    }

    #endregion

    #region Printing

    // Convert between the unit used by .NET and Windows Forms (1/100 inch) 
    // and the unit used by Win32 API calls (twips = 1/1440 inch)
    private const double anInch = 14.4;

    int checkPrint = 0;

    // Render the contents of the RichTextBox for printing
    //    Return the last character printed + 1 (printing start from this point for
    //    next page)
    public int Print(int charFrom, int charTo, PrintPageEventArgs e)
    {
        //Calculate the area to render and print
        RECT rectToPrint = new RECT(
            (int)(e.MarginBounds.Left * anInch),
            (int)(e.MarginBounds.Top * anInch),
            (int)(e.MarginBounds.Right * anInch),
            (int)(e.MarginBounds.Bottom * anInch));

        //Calculate the size of the page
        RECT rectPage = new RECT(
            (int)(e.PageBounds.Left * anInch),
            (int)(e.PageBounds.Top * anInch),
            (int)(e.PageBounds.Right * anInch),
            (int)(e.PageBounds.Bottom * anInch));

        IntPtr hdc = e.Graphics.GetHdc();

        FORMATRANGE fmtRange;
        fmtRange.chrg.cpMax = charTo;   //Indicate character from to character to 
        fmtRange.chrg.cpMin = charFrom;
        fmtRange.hdc = (Windows.Win32.Graphics.Gdi.HDC)hdc; //Use the same DC for measuring and rendering
        fmtRange.hdcTarget = (Windows.Win32.Graphics.Gdi.HDC)hdc;       //Point at printer hDC        
        fmtRange.rc = rectToPrint;      //Indicate the area on page to print
        fmtRange.rcPage = rectPage;     //Indicate size of page

        IntPtr res = IntPtr.Zero;        

        //Get the pointer to the FORMATRANGE structure in memory
        IntPtr lparam = IntPtr.Zero;
        lparam = Marshal.AllocCoTaskMem(Marshal.SizeOf(fmtRange));
        Marshal.StructureToPtr(fmtRange, lparam, false);

        //Send the rendered data for printing.
        //If wParam is not zero, the text is rendered, otherwise it is just measured.
        res = PInvoke.SendMessage(hwnd, PInvoke.EM_FORMATRANGE, 1, lparam);

        //Free the block of memory allocated
        Marshal.FreeCoTaskMem(lparam);

        //Release the device context handle obtained by a previous call
        e.Graphics.ReleaseHdc(hdc);

        //Return last + 1 character printer
        return res.ToInt32();
    }

    private PrintDocument? _printDocument = null;

    public PrintDocument? PrintDocument
    {
        get { return _printDocument; }
        set
        {
            _printDocument = value;
            if (_printDocument != null)
            {
                _printDocument.BeginPrint += new PrintEventHandler(
                    _PrintDocument_BeginPrint);
                _printDocument.PrintPage += new PrintPageEventHandler(
                    _PrintDocument_PrintPage);
            }
        }
    }

    void _PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
    {
        // Print the content of RichTextBox. Store the last character printed.
        checkPrint = this.Print(checkPrint, this.TextLength, e);

        // Check for more pages
        if (checkPrint < this.TextLength)
            e.HasMorePages = true;
        else
            e.HasMorePages = false;
    }

    void _PrintDocument_BeginPrint(object sender, PrintEventArgs e)
    {
        checkPrint = 0;
    }

    #endregion

}