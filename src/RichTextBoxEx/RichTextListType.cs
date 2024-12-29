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
    Sequence = 7,
    NumberedCircle = 8,
    NumberedBlackCircleWingding = 9,
    NumberedWhiteCircleWingding = 10,
    NumberedArabicWide = 11,
    NumberedChS = 12,
    NumberedChT = 13,
    NumberedJpnChs = 14,
    NumberedJpnKor = 15,
    NumberedArabic1 = 16,
    NumberedArabic2 = 17,
    NumberedHebrew = 18,
    NumberedThaiAlpha = 19,
    NumberedThaiNum = 20,
    NumberedHindiAlpha = 21,
    NumberedHindiAlpha1 = 22,
    NumberedHindiNum = 23
}

public static class RichTextListHelper
{
    public static bool IsNumbered(RichTextListType listType)
    {
        return IsNumbered((int)listType);
    }

    public static bool IsNumbered(int listType)
    {
        return listType > 1 && listType <= 23;
    }
}
