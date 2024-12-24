using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichTextBoxEx;

public enum RichTextListType
{
    None = 0,
    Bullet = 1,
    Number = 2,
    LowerCaseLetter = 3,
    UpperCaseLetter = 4,
    LowerCaseRoman = 5,
    UpperCaseRoman = 6,
    // Special = 7 // increments char for each item (?) - undocumented
}
