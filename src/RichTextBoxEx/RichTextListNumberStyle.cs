using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichTextBoxEx;

public enum RichTextListNumberStyle
{
    RightParenthesis = 0x000,
    DoubleParenthesis = 0x100,
    Period = 0x200,
    Plain = 0x300,
    NoNumber = 0x400,
    //NewNumber = 0x8000 // Starts a new number with wNumberingStart
}
