using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichTextBoxEx;

public enum RichTextFontStretch : int
{
    UltraCondensed = -4,
    ExtraCondensed = -3,
    Condensed = -2,
    SemiCondensed = -1,
    Normal = 0,
    SemiExpanded = 1,
    Expanded = 2,
    ExtraExpanded = 3,
    UltraExpanded = 4,
    MaxExpanded = 6
}
