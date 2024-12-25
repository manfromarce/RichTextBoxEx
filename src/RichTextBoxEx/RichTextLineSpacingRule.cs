using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichTextBoxEx;

// See bLineSpacingRule on https://learn.microsoft.com/en-us/windows/win32/api/richedit/ns-richedit-paraformat2#members)
public enum RichTextLineSpacingRule : byte
{
    /// <summary>
    /// Single spacing.
    /// The LineSpacing property will be ignored if this rule is active.
    /// </summary>
    Single = 0,

    /// <summary>
    /// One-and-a-half spacing. 
    /// The LineSpacing property will be ignored if this rule is active.
    /// </summary>
    OneAndHalf = 1,

    /// <summary>
    /// Double spacing.
    /// The LineSpacing property will be ignored if this rule is active.
    /// </summary>
    Double = 2,

    /// <summary>
    /// LineSpacing is interpreted as the spacing from one line to the next, 
    /// in twips (1/1440 inches). 
    /// However, the control displays single-spaced text if 
    /// LineSpacing is less than single spacing.
    Minimum = 3,

    /// <summary>
    /// LineSpacing is interpreted as the spacing from one line to the next, 
    /// in twips (1/1440 inches). 
    /// The control uses the exact spacing specified, 
    /// even if less than single spacing.
    /// </summary>
    Exact = 4,

    /// <summary>
    /// The value of LineSpacing / 20 is the spacing, in lines, 
    /// from one line to the next. 
    /// Thus, setting dyLineSpacing to 20 produces single-spaced text, 
    /// 40 is double spaced, 60 is triple spaced, and so on.
    /// </summary>
    Multiple = 5
}
