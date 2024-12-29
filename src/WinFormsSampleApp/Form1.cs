using System.Diagnostics;
using System.Runtime.InteropServices;
using RichTextBoxEx;

namespace WinFormsSampleApp;

public partial class Form1 : Form
{
    private string CurrentFilePath = string.Empty;

    private bool _updateFont = false;


    public Form1()
    {
        InitializeComponent();
        foreach (var font in FontFamily.Families)
        {
            fontComboBox.Items.Add(font.Name);
        }
        // Set default values before the SelectionChanged events triggers
        fontComboBox.Text = richTextBoxEx1.Font.Name;
        fontSizeComboBox.Text = richTextBoxEx1.Font.SizeInPoints.ToString();
        _updateFont = true;
    }

    private void richTextBoxEx1_LinkClicked(object sender, LinkClickedEventArgs e)
    {
        using (var p = new Process()
        {
            StartInfo = new ProcessStartInfo()
            {
                FileName = e.LinkText,
                UseShellExecute = true
            }
        })
        {
            try
            {
                p.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var form = new Form1();
        form.Show();
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
        {
            bool isRtf = Path.GetExtension(openFileDialog1.FileName).ToLower() == ".rtf";
            richTextBoxEx1.LoadFile(openFileDialog1.FileName, isRtf ? RichTextBoxStreamType.RichText : RichTextBoxStreamType.PlainText);
            CurrentFilePath = openFileDialog1.FileName;
        }
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(CurrentFilePath))
        {
            bool isRtf = Path.GetExtension(CurrentFilePath).ToLower() == ".rtf";
            richTextBoxEx1.SaveFile(CurrentFilePath, isRtf ? RichTextBoxStreamType.RichText : RichTextBoxStreamType.PlainText);
        }
        else
        {
            saveAsToolStripMenuItem_Click(sender, e);
        }
    }

    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
        {
            bool isRtf = Path.GetExtension(saveFileDialog1.FileName).ToLower() == ".rtf";
            richTextBoxEx1.SaveFile(saveFileDialog1.FileName, isRtf ? RichTextBoxStreamType.RichText : RichTextBoxStreamType.PlainText);
            CurrentFilePath = saveFileDialog1.FileName;
        }
    }

    private void saveAsCopyToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
        {
            bool isRtf = Path.GetExtension(saveFileDialog1.FileName).ToLower() == ".rtf";
            richTextBoxEx1.SaveFile(saveFileDialog1.FileName, isRtf ? RichTextBoxStreamType.RichText :
                                                                      RichTextBoxStreamType.PlainText);
        }
    }

    private void printToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (printDialog1.ShowDialog(this) == DialogResult.OK)
        {
            printDocument1.Print();
        }
    }

    private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
    {
        printPreviewDialog1.ShowDialog(this);
    }

    private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
    {
        pageSetupDialog1.ShowDialog(this);
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void undoToolStripMenuItem_Click(object sender, EventArgs e)
    {
        richTextBoxEx1.Undo();
    }

    private void redoToolStripMenuItem_Click(object sender, EventArgs e)
    {
        richTextBoxEx1.Redo();
    }

    private void cutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        richTextBoxEx1.Cut();
    }

    private void copyToolStripMenuItem_Click(object sender, EventArgs e)
    {
        richTextBoxEx1.Copy();
    }

    private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        richTextBoxEx1.Paste();
    }

    private void pasteAsPlainTextToolStripMenuItem_Click(object sender, EventArgs e)
    {
        richTextBoxEx1.Paste(DataFormats.GetFormat(DataFormats.UnicodeText));
    }

    private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
        richTextBoxEx1.SelectAll();
    }

    private void findReplaceToolStripMenuItem_Click(object sender, EventArgs e)
    {
        // TODO
    }

    private void editToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
    {
        undoToolStripMenuItem.Enabled = richTextBoxEx1.CanUndo;
        redoToolStripMenuItem.Enabled = richTextBoxEx1.CanRedo;

        bool isSelectionEmpty = richTextBoxEx1.SelectionType == RichTextBoxSelectionTypes.Empty;
        cutToolStripMenuItem.Enabled = !isSelectionEmpty;
        copyToolStripMenuItem.Enabled = !isSelectionEmpty;

        bool canPaste = Clipboard.GetDataObject() != null;
        pasteToolStripMenuItem.Enabled = canPaste;
        pasteAsPlainTextToolStripMenuItem.Enabled = canPaste;
    }

    private void viewToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
    {
        // Update checked states
        wordWrapToolStripMenuItem.Checked = richTextBoxEx1.WordWrap;
    }

    private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
    {
        richTextBoxEx1.WordWrap = !richTextBoxEx1.WordWrap;
    }

    private void optionsToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
    {
        autoWordSelectionToolStripMenuItem.Checked = richTextBoxEx1.AutoWordSelection;
        enableDragAndDropContentToolStripMenuItem.Checked = richTextBoxEx1.EnableAutoDragDrop;
        enableKeyboardShortcutsToolStripMenuItem.Checked = richTextBoxEx1.ShortcutsEnabled;
        enableSpellCheckToolStripMenuItem.Checked = richTextBoxEx1.IsSpellCheckEnabled;
        useCtrlClickForOpeningHyperlinksToolStripMenuItem.Checked = richTextBoxEx1.RequireCtrlForLinkClick;
    }

    private void enableSpellCheckToolStripMenuItem_Click(object sender, EventArgs e)
    {
        richTextBoxEx1.IsSpellCheckEnabled = !richTextBoxEx1.IsSpellCheckEnabled;
    }

    private void autoWordSelectionToolStripMenuItem_Click(object sender, EventArgs e)
    {
        richTextBoxEx1.AutoWordSelection = !richTextBoxEx1.AutoWordSelection;
    }

    private void enableDragAndDropContentToolStripMenuItem_Click(object sender, EventArgs e)
    {
        richTextBoxEx1.EnableAutoDragDrop = !richTextBoxEx1.EnableAutoDragDrop;
    }

    private void enableKeyboardShortcutsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        richTextBoxEx1.ShortcutsEnabled = !richTextBoxEx1.ShortcutsEnabled;
    }

    private void useCtrlClickForOpeningHyperlinksToolStripMenuItem_Click(object sender, EventArgs e)
    {
        richTextBoxEx1.RequireCtrlForLinkClick = !richTextBoxEx1.RequireCtrlForLinkClick;
    }

    // NOTE: don't use CheckedChanged for toolbar buttons, as it would be triggered when we set Checked in SelectionChanged
    private void boldButton_Click(object sender, EventArgs e)
    {
        if (boldButton.Checked)
        {
            richTextBoxEx1.SelectionIsBold = false;
            boldButton.Checked = false;
        }
        else
        {
            richTextBoxEx1.SelectionIsBold = true;
            boldButton.Checked = true;
        }
    }

    private void italicButton_Click(object sender, EventArgs e)
    {
        if (italicButton.Checked)
        {
            richTextBoxEx1.SelectionIsItalic = false;
            italicButton.Checked = false;
        }
        else
        {
            richTextBoxEx1.SelectionIsItalic = true;
            italicButton.Checked = true;
        }
    }

    private void underlineButton_Click(object sender, EventArgs e)
    {
        if (underlineButton.Checked)
        {
            richTextBoxEx1.SelectionUnderlineStyle = RichTextUnderlineStyle.None;
            underlineButton.Checked = false;
        }
        else
        {
            richTextBoxEx1.SelectionUnderlineStyle = RichTextUnderlineStyle.Single;
            underlineButton.Checked = true;
        }
    }

    private void strikethroughButton_Click(object sender, EventArgs e)
    {
        if (strikethroughButton.Checked)
        {
            richTextBoxEx1.SelectionIsStrikethrough = false;
            strikethroughButton.Checked = false;
        }
        else
        {
            richTextBoxEx1.SelectionIsStrikethrough = true;
            strikethroughButton.Checked = true;
        }
    }

    private void superScriptButton_Click(object sender, EventArgs e)
    {
        if (superScriptButton.Checked)
        {
            richTextBoxEx1.SelectionScriptStyle = RichTextScriptStyle.Normal;
            superScriptButton.Checked = false;
        }
        else
        {
            richTextBoxEx1.SelectionScriptStyle = RichTextScriptStyle.Superscript;
            superScriptButton.Checked = true;
            subscriptButton.Checked = false;
        }
    }

    private void subscriptButton_Click(object sender, EventArgs e)
    {
        if (subscriptButton.Checked)
        {
            richTextBoxEx1.SelectionScriptStyle = RichTextBoxEx.RichTextScriptStyle.Normal;
            subscriptButton.Checked = false;
        }
        else
        {
            richTextBoxEx1.SelectionScriptStyle = RichTextBoxEx.RichTextScriptStyle.Subscript;
            subscriptButton.Checked = true;
            superScriptButton.Checked = false;
        }
    }

    private void fontOptionsButton_Click(object sender, EventArgs e)
    {
        var dlg = new FontFormatDialog();
        // TODO: set undetermined state (three-state checkboxes) if the selection contains multiple styles
        dlg.checkBoxBold.Checked = richTextBoxEx1.SelectionIsBold;
        dlg.checkBoxItalic.Checked = richTextBoxEx1.SelectionIsItalic;
        dlg.checkBoxStrikethrough.Checked = richTextBoxEx1.SelectionIsStrikethrough;
        dlg.checkBoxShadow.Checked = richTextBoxEx1.SelectionShadow;

        var selectedUnderlineStyle = richTextBoxEx1.SelectionUnderlineStyle;
        foreach (var underlineStyle in Enum.GetValues<RichTextUnderlineStyle>())
        {
            dlg.comboBoxUnderlineType.Items.Add(underlineStyle);
            if (underlineStyle == selectedUnderlineStyle)
            {
                dlg.comboBoxUnderlineType.SelectedItem = underlineStyle;
            }
        }
        var selectedUnderlineColor = richTextBoxEx1.SelectionUnderlineColor;
        foreach (var underlineColor in Enum.GetValues<RichTextUnderlineColor>())
        {
            dlg.comboBoxUnderlineColor.Items.Add(underlineColor);
            if (underlineColor == selectedUnderlineColor)
            {
                dlg.comboBoxUnderlineColor.SelectedItem = underlineColor;
            }
        }
        var selectedFontStretch = richTextBoxEx1.SelectionFontStretch;
        foreach (var fontStretch in Enum.GetValues<RichTextFontStretch>().Order())
        {
            dlg.comboBoxFontStretch.Items.Add(fontStretch);
            if (((int)fontStretch) == selectedFontStretch)
            {
                dlg.comboBoxFontStretch.SelectedItem = fontStretch;
            }
        }
        if (dlg.comboBoxFontStretch.SelectedItem is null)
        {
            dlg.comboBoxFontStretch.Items.Add("Custom");
            dlg.comboBoxFontStretch.SelectedIndex = dlg.comboBoxFontStretch.Items.Count - 1;
        }

        var capStyle = richTextBoxEx1.SelectionCapStyle;
        dlg.checkBoxAllCaps.Checked = capStyle == RichTextCapStyle.AllCaps;
        dlg.checkBoxSmallCaps.Checked = capStyle == RichTextCapStyle.SmallCaps;
        var scriptStyle = richTextBoxEx1.SelectionScriptStyle;
        dlg.checkBoxSuperscript.Checked = scriptStyle == RichTextScriptStyle.Superscript;
        dlg.checkBoxSubscript.Checked = scriptStyle == RichTextScriptStyle.Subscript;

        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
            richTextBoxEx1.SelectionIsBold = dlg.checkBoxBold.Checked;
            richTextBoxEx1.SelectionIsItalic = dlg.checkBoxItalic.Checked;
            richTextBoxEx1.SelectionIsStrikethrough = dlg.checkBoxStrikethrough.Checked;
            richTextBoxEx1.SelectionShadow = dlg.checkBoxShadow.Checked;

            if (dlg.checkBoxSuperscript.Checked)
            {
                richTextBoxEx1.SelectionScriptStyle = RichTextScriptStyle.Superscript;
            }
            else if (dlg.checkBoxSubscript.Checked)
            {
                richTextBoxEx1.SelectionScriptStyle = RichTextScriptStyle.Subscript;
            }
            else
            {
                richTextBoxEx1.SelectionScriptStyle = RichTextScriptStyle.Normal;
            }

            if (dlg.checkBoxAllCaps.Checked)
            {
                richTextBoxEx1.SelectionCapStyle = RichTextCapStyle.AllCaps;
            }
            else if (dlg.checkBoxSmallCaps.Checked)
            {
                richTextBoxEx1.SelectionCapStyle = RichTextCapStyle.SmallCaps;
            }
            else
            {
                richTextBoxEx1.SelectionCapStyle = RichTextCapStyle.Standard;
            }
            if (Enum.TryParse(dlg.comboBoxUnderlineType.SelectedItem?.ToString(), out RichTextUnderlineStyle underlineStyle))
            {
                richTextBoxEx1.SelectionUnderlineStyle = underlineStyle;
            }
            if (Enum.TryParse(dlg.comboBoxUnderlineColor.SelectedItem?.ToString(), out RichTextUnderlineColor underlineColor))
            {
                richTextBoxEx1.SelectionUnderlineColor = underlineColor;
            }
            if (Enum.TryParse(dlg.comboBoxFontStretch.SelectedItem?.ToString(), out RichTextFontStretch fontStretch))
            {
                richTextBoxEx1.SelectionFontStretch = (float)fontStretch;
            }
            richTextBoxEx1_SelectionChanged(sender, e);
        }
    }

    private void alignLeftButton_Click(object sender, EventArgs e)
    {
        if (!alignLeftButton.Checked)
        {
            alignLeftButton.Checked = true;
            alignCenterButton.Checked = false;
            alignRightButton.Checked = false;
            alignJustifiedButton.Checked = false;
        }
        // Set alignment even if button was already checked, as selection could contain multiple alignments.
        richTextBoxEx1.SelectionAlignment = RichTextAlignment.Left;
    }

    private void alignCenterButton_Click(object sender, EventArgs e)
    {
        if (!alignCenterButton.Checked)
        {
            alignLeftButton.Checked = false;
            alignCenterButton.Checked = true;
            alignRightButton.Checked = false;
            alignJustifiedButton.Checked = false;
        }
        richTextBoxEx1.SelectionAlignment = RichTextAlignment.Center;
    }

    private void alignRightButton_Click(object sender, EventArgs e)
    {
        if (!alignRightButton.Checked)
        {
            alignLeftButton.Checked = false;
            alignCenterButton.Checked = false;
            alignRightButton.Checked = true;
            alignJustifiedButton.Checked = false;
        }
        richTextBoxEx1.SelectionAlignment = RichTextAlignment.Right;
    }

    private void alignJustifiedButton_Click(object sender, EventArgs e)
    {
        if (!alignJustifiedButton.Checked)
        {
            alignLeftButton.Checked = false;
            alignCenterButton.Checked = false;
            alignRightButton.Checked = false;
            alignJustifiedButton.Checked = true;
        }
        richTextBoxEx1.SelectionAlignment = RichTextAlignment.Justify;
    }

    private void bulletedListButton_Click(object sender, EventArgs e)
    {
        if (bulletedListButton.Checked)
        {
            richTextBoxEx1.SelectionListType = RichTextListType.None;
            bulletedListButton.Checked = false;
        }
        else
        {
            richTextBoxEx1.SelectionListType = RichTextListType.Bullet;
            bulletedListButton.Checked = true;
            numberedListButton.Checked = false;
        }
    }

    private void numberedListButton_Click(object sender, EventArgs e)
    {
        if (numberedListButton.Checked)
        {
            richTextBoxEx1.SelectionListType = RichTextListType.None;
            numberedListButton.Checked = false;
        }
        else
        {
            richTextBoxEx1.SelectionListType = RichTextListType.Number;
            numberedListButton.Checked = true;
            bulletedListButton.Checked = false;
        }
    }

    private void outdentButton_Click(object sender, EventArgs e)
    {
        // 20 points = about 1 cm
        richTextBoxEx1.SelectionIndent = Math.Max(richTextBoxEx1.SelectionIndent - 30, 0);
    }

    private void indentButton_Click(object sender, EventArgs e)
    {
        richTextBoxEx1.SelectionIndent += 30;
    }

    private void ParagraphOptionsButton_Click(object sender, EventArgs e)
    {
        var dlg = new ParagraphFormatDialog();

        dlg.alignmentComboBox.SelectedIndex = Math.Clamp((int)richTextBoxEx1.SelectionAlignment - 1, 0, dlg.alignmentComboBox.Items.Count - 1);

        dlg.leftIndentUpDown.Value = Math.Clamp(richTextBoxEx1.SelectionIndent, dlg.leftIndentUpDown.Minimum, dlg.leftIndentUpDown.Maximum);
        dlg.rightIndentUpDown.Value = Math.Clamp(richTextBoxEx1.SelectionRightIndent, dlg.rightIndentUpDown.Minimum, dlg.rightIndentUpDown.Maximum);

        var hangingIndent = richTextBoxEx1.SelectionHangingIndent;
        if (hangingIndent == 0)
        {
            dlg.specialIndentComboBox.SelectedIndex = 0;
        }
        else
        {
            if (hangingIndent < 0)
            {
                dlg.specialIndentComboBox.SelectedIndex = 1;
            }
            else if (hangingIndent > 0)
            {
                dlg.specialIndentComboBox.SelectedIndex = 2;
            }
            dlg.hangingIndentUpDown.Value = Math.Clamp(Math.Abs(hangingIndent), dlg.hangingIndentUpDown.Minimum, dlg.hangingIndentUpDown.Maximum);
        }

        dlg.spaceBeforeUpDown.Value = Math.Clamp(richTextBoxEx1.SelectionParagraphSpaceBefore, dlg.spaceBeforeUpDown.Minimum, dlg.spaceBeforeUpDown.Maximum);
        dlg.spaceAfterUpDown.Value = Math.Clamp(richTextBoxEx1.SelectionParagraphSpaceAfter, dlg.spaceAfterUpDown.Minimum, dlg.spaceAfterUpDown.Maximum);

        switch (richTextBoxEx1.SelectionLineSpacing)
        {
            case OneAndHalfLineSpacing oneAndHalfLineSpacing:
                dlg.spacingRuleComboBox.SelectedIndex = 1;
                break;
            case DoubleLineSpacing doubleLineSpacing:
                dlg.spacingRuleComboBox.SelectedIndex = 2;
                break;
            case MinimumLineSpacing minimumLineSpacing:
                dlg.spacingRuleComboBox.SelectedIndex = 3;
                dlg.lineSpacingValueUpDown.Value = Math.Clamp(minimumLineSpacing.Value, dlg.lineSpacingValueUpDown.Minimum, dlg.lineSpacingValueUpDown.Maximum);
                break;
            case ExactLineSpacing exactLineSpacing:
                dlg.spacingRuleComboBox.SelectedIndex = 4;
                dlg.lineSpacingValueUpDown.Value = Math.Clamp(exactLineSpacing.Value, dlg.lineSpacingValueUpDown.Minimum, dlg.lineSpacingValueUpDown.Maximum);
                break;
            case MultipleLineSpacing multipleLineSpacing:
                dlg.spacingRuleComboBox.SelectedIndex = 5;
                dlg.lineSpacingValueUpDown.Value = Math.Clamp(multipleLineSpacing.Value, dlg.lineSpacingValueUpDown.Minimum, dlg.lineSpacingValueUpDown.Maximum);
                break;
            case SingleLineSpacing singleLineSpacing:
            default:
                dlg.spacingRuleComboBox.SelectedIndex = 0;
                break;
        }

        foreach (var tab in richTextBoxEx1.SelectionTabs.Order().Distinct().ToArray())
        {
            dlg.tabsComboBox.Items.Add(tab);
        }

        switch (richTextBoxEx1.SelectionListType)
        {
            case RichTextListType.None:
                dlg.listTypeComboBox.SelectedIndex = 0; break;
            case RichTextListType.Bullet:
                dlg.listTypeComboBox.SelectedIndex = 1;
                var bulletChar = richTextBoxEx1.SelectionListBulletChar;
                if (bulletChar != '•')
                {
                    // Not every char is handled by the dialog at this time
                    for (int i = 0; i < dlg.listTypeComboBox.Items.Count; i++)
                    {
                        if (dlg.listTypeComboBox.Items[i] is string s && (!string.IsNullOrEmpty(s)) && s[0] == bulletChar)
                        {
                            dlg.listTypeComboBox.SelectedIndex = i;
                            break;
                        }
                    }
                }
                break;
            case RichTextListType.Number:
                dlg.listTypeComboBox.SelectedIndex = 7; break;
            case RichTextListType.LowerCaseLetter:
                dlg.listTypeComboBox.SelectedIndex = 8; break;
            case RichTextListType.UpperCaseLetter:
                dlg.listTypeComboBox.SelectedIndex = 9; break;
            case RichTextListType.LowerCaseRoman:
                dlg.listTypeComboBox.SelectedIndex = 10; break;
            case RichTextListType.UpperCaseRoman:
                dlg.listTypeComboBox.SelectedIndex = 11; break;
            case RichTextListType.NumberedCircle:
            case RichTextListType.NumberedWhiteCircleWingding:
                dlg.listTypeComboBox.SelectedIndex = 12; break;
            case RichTextListType.NumberedBlackCircleWingding:
                dlg.listTypeComboBox.SelectedIndex = 13; break;
            default:
                // Not every char is handled by the dialog at this time, select the generic "bulleted"
                dlg.listTypeComboBox.SelectedIndex = 1; break;
        }

        dlg.numberStyleComboBox.SelectedIndex = Math.Clamp((int)richTextBoxEx1.SelectionListNumberStyle, 0, dlg.numberStyleComboBox.Items.Count - 1);
        dlg.firstNumberUpDown.Value = Math.Clamp(richTextBoxEx1.SelectionListStartingNumber, dlg.firstNumberUpDown.Minimum, dlg.firstNumberUpDown.Maximum);
        dlg.bulletTextDistanceUpDown.Value = Math.Clamp(richTextBoxEx1.SelectionBulletTextDistance, dlg.bulletTextDistanceUpDown.Minimum, dlg.bulletTextDistanceUpDown.Maximum);

        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
            var alignment = (RichTextAlignment)dlg.alignmentComboBox.SelectedIndex + 1;

            var leftIndent = (int)dlg.leftIndentUpDown.Value;
            var rightIndent = (int)dlg.rightIndentUpDown.Value;
            switch (dlg.specialIndentComboBox.SelectedIndex)
            {
                case 0:
                    hangingIndent = 0;
                    break;
                case 1:
                    hangingIndent = -(int)dlg.hangingIndentUpDown.Value;
                    leftIndent = Math.Max(leftIndent, Math.Abs(hangingIndent));
                    break;
                case 2:
                    hangingIndent = (int)dlg.hangingIndentUpDown.Value;
                    break;
            }

            var spaceBefore = (int)dlg.spaceBeforeUpDown.Value;
            var spaceAfter = (int)dlg.spaceAfterUpDown.Value;

            RichTextLineSpacing lineSpacing;
            switch (dlg.spacingRuleComboBox.SelectedIndex)
            {
                case 1:
                    lineSpacing = new OneAndHalfLineSpacing();
                    break;
                case 2:
                    lineSpacing = new DoubleLineSpacing();
                    break;
                case 3:
                    lineSpacing = new MinimumLineSpacing((int)dlg.lineSpacingValueUpDown.Value);
                    break;
                case 4:
                    lineSpacing = new ExactLineSpacing((int)dlg.lineSpacingValueUpDown.Value);
                    break;
                case 5:
                    lineSpacing = new MultipleLineSpacing((int)dlg.lineSpacingValueUpDown.Value);
                    break;
                case 0:
                default:
                    lineSpacing = new SingleLineSpacing();
                    break;
            }

            var tabs = dlg.tabsComboBox.Items.OfType<int>().Order().Distinct().ToArray();

            RichTextListType? listType = null;
            char? bulletChar = null;
            if (dlg.listTypeComboBox.SelectedIndex >= 0 && dlg.listTypeComboBox.SelectedIndex <= 8)
            {
                listType = (RichTextListType)dlg.listTypeComboBox.SelectedIndex;
            }
            else if (dlg.listTypeComboBox.SelectedItem is string s && !string.IsNullOrEmpty(s))
            {
                listType = RichTextListType.Bullet;
                bulletChar = s[0];
            }
            var listNumberStyle = (RichTextListNumberStyle)dlg.numberStyleComboBox.SelectedIndex;
            var firstNumber = (ushort)dlg.firstNumberUpDown.Value;
            var bulletTextDistance = (ushort)dlg.bulletTextDistanceUpDown.Value;

            richTextBoxEx1.SelectionAlignment = alignment;

            richTextBoxEx1.SelectionIndent = leftIndent;
            richTextBoxEx1.SelectionRightIndent = rightIndent;
            richTextBoxEx1.SelectionHangingIndent = hangingIndent;

            richTextBoxEx1.SelectionLineSpacing = lineSpacing;
            richTextBoxEx1.SelectionParagraphSpaceBefore = spaceBefore;
            richTextBoxEx1.SelectionParagraphSpaceAfter = spaceAfter;

            if (dlg.defaultSettingsCheckBox.Checked)
            {
                richTextBoxEx1.DefaultLineSpacing = lineSpacing;
                richTextBoxEx1.DefaultParagraphSpaceBefore = spaceBefore;
                richTextBoxEx1.DefaultParagraphSpaceAfter = spaceAfter;
                richTextBoxEx1.DefaultIndent = leftIndent;
                richTextBoxEx1.DefaultRightIndent = rightIndent;
                richTextBoxEx1.DefaultHangingIndent = hangingIndent;
            }

            richTextBoxEx1.SelectionTabs = Array.Empty<int>();
            richTextBoxEx1.SelectionTabs = tabs;

            if (listType != null)
            {
                richTextBoxEx1.SelectionListType = listType.Value;
                if (bulletChar != null)
                {
                    richTextBoxEx1.SelectionListBulletChar = bulletChar.Value;
                }
                if (RichTextListHelper.IsNumbered(listType.Value))
                {                
                    richTextBoxEx1.SelectionListNumberStyle = listNumberStyle;
                    richTextBoxEx1.SelectionListStartingNumber = firstNumber;
                }
                if (listType != RichTextListType.None)
                {
                    richTextBoxEx1.SelectionBulletTextDistance = bulletTextDistance;
                }
            }

            richTextBoxEx1_SelectionChanged(sender, e);
        }
    }

    private void richTextBoxEx1_SelectionChanged(object sender, EventArgs e)
    {
        boldButton.Checked = richTextBoxEx1.SelectionIsBold;
        italicButton.Checked = richTextBoxEx1.SelectionIsItalic;
        underlineButton.Checked = richTextBoxEx1.SelectionUnderlineStyle != RichTextUnderlineStyle.None;
        strikethroughButton.Checked = richTextBoxEx1.SelectionIsStrikethrough;

        var scriptStyle = richTextBoxEx1.SelectionScriptStyle;
        superScriptButton.Checked = scriptStyle == RichTextScriptStyle.Superscript;
        subscriptButton.Checked = scriptStyle == RichTextScriptStyle.Subscript;

        var alignment = richTextBoxEx1.SelectionAlignment;
        alignLeftButton.Checked = alignment == RichTextAlignment.Left;
        alignCenterButton.Checked = alignment == RichTextAlignment.Center;
        alignRightButton.Checked = alignment == RichTextAlignment.Right;
        alignJustifiedButton.Checked = alignment == RichTextAlignment.Justify;

        var listType = richTextBoxEx1.SelectionListType;
        bulletedListButton.Checked = listType == RichTextListType.Bullet;
        numberedListButton.Checked = RichTextListHelper.IsNumbered(listType);

        _updateFont = false;
        fontComboBox.Text = richTextBoxEx1.SelectionFontName;
        fontSizeComboBox.Text = richTextBoxEx1.SelectionFontSize.ToString();
        _updateFont = true;
    }

    private void imageButton_Click(object sender, EventArgs e)
    {
        imageOpenFileDialog.FileName = string.Empty;
        if (imageOpenFileDialog.ShowDialog(this) == DialogResult.OK)
        {
            richTextBoxEx1.InsertImage(imageOpenFileDialog.FileName);
        }
    }

    private void tableButton_Click(object sender, EventArgs e)
    {
        var dlg = new InsertTableDialog();
        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
            richTextBoxEx1.InsertTable((int)dlg.rowsUpDown.Value,
                                       (int)dlg.columnsUpDown.Value);
        }
    }

    private void hyperlinkButton_Click(object sender, EventArgs e)
    {
        string displayText = richTextBoxEx1.SelectionHyperlinkDisplayText;
        if (displayText == string.Empty)
        {
            // If there is no hyperlink, the currently selected text (if any) is suggested.
            // If there is an existing hyperlink, SelectedVisibleText should be used rather than SelectedText (which would contain hidden RTF parts).
            displayText = richTextBoxEx1.SelectedVisibleText;
        }
        var dlg = new InsertHyperlinkDialog()
        {
            LinkDisplayText = displayText,
            LinkUrl = richTextBoxEx1.SelectionHyperlinkUrl,
        };
        // Enable button to remove the existing hyperlink, if any.
        dlg.removeButton.Enabled = !string.IsNullOrWhiteSpace(dlg.LinkUrl);
        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
            // Display text should be set before URL, because in case the hyperlink is removed,
            // SelectionHyperlinkDisplayText would no longer work (SelectedText should be used in that case).
            richTextBoxEx1.SelectionHyperlinkDisplayText = dlg.LinkDisplayText;
            richTextBoxEx1.SelectionHyperlinkUrl = dlg.LinkUrl;
        }
    }

    private void dateTimeButton_Click(object sender, EventArgs e)
    {
        var dlg = new InsertDateDialog();
        if (dlg.ShowDialog() == DialogResult.OK)
        {
            richTextBoxEx1.SelectedText = dlg.SelectedDateTime;
        }
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var dlg = new AboutBox1();
        dlg.ShowDialog(this);
    }

    private void fontColorPicker_SelectedColorChanged(object sender, EventArgs e)
    {
        richTextBoxEx1.SelectionColor = fontColorPicker.Color;
    }

    private void highlightColorPicker_SelectedColorChanged(object sender, EventArgs e)
    {
        richTextBoxEx1.SelectionBackColor = textHighlightColorPicker.Color;
    }

    private void fontComboBox_SelectedIndexChanged(object? sender, EventArgs e)
    {
        UpdateFontName();
    }

    private void fontComboBox_DropDownClosed(object sender, EventArgs e)
    {
        UpdateFontName();
    }

    private void fontSizeComboBox_TextChanged(object? sender, EventArgs e)
    {
        UpdateFontSize();
    }

    private void fontSizeComboBox_DropDownClosed(object sender, EventArgs e)
    {
        // Ensure the font size is updated when the selection contains multiple sizes
        // (TextChanged or SelectedIndexChanged won't trigger if the user re-selects the same size)
        UpdateFontSize();
    }

    private void UpdateFontName()
    {
        if (_updateFont)
        {
            string? fontName = fontComboBox.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(fontName))
            {
                richTextBoxEx1.SelectionFontName = fontName;
            }
        }
    }

    private void UpdateFontSize()
    {
        if (_updateFont && float.TryParse(fontSizeComboBox.Text, out float fontSize))
        {
            // 4 and 400 seem reasonable min and max values for now.
            fontSize = Math.Clamp(fontSize, 4, 400);
            richTextBoxEx1.SelectionFontSize = fontSize;
        }
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
        richTextBoxEx1.Focus();
    }

    private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (richTextBoxEx1.ZoomFactor < 4)
        {
            richTextBoxEx1.ZoomFactor += (float)0.15;
        }
    }

    private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (richTextBoxEx1.ZoomFactor > 0.25)
        {
            richTextBoxEx1.ZoomFactor -= (float)0.15;
        }
    }

    private void restore100ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        richTextBoxEx1.ZoomFactor = 1;
    }
}

