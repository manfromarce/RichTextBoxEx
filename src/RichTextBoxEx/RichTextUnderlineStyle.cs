using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichTextBoxEx;

public enum RichTextUnderlineStyle
{
    // internal use only:
    // CF1Underline = 0xFF,
    // Invert = 0xFE,
    None = 0x00,
    Single = 0x01,
    Dash = 0x05,
    DashDot = 0x06,
    DashDotDot = 0x07,
    Dotted = 0x04,
    Double = 0x03, // documentation says "displayed as Single", but works in recent RichEdit versions
    Wave = 0x08,
    DoubleWave = 0x0b, // displayed as Wave
    HeavyWave = 0x0c, // displayed as Wave
    Hairline = 0x0a, // displayed as Single
    LongDash = 0x0d, // displayed as Dash
    Thick = 0x09, // documentation says "displayed as Single", but works in recent RichEdit versions
    ThickDash = 0x0e, // displayed as Dash
    ThickDashDot = 0x0f, // displayed as DashDot
    ThickDashDotDot = 0x10, // displayed as DashDotDot
    ThickDotted = 0x11, // displayed as Dotted
    ThickLongDash = 0x12, // documentation says "displayed as Dash", but seems to be displayed as DashDot
    WordOnly = 0x02 // like Single, but excludes whitespace in recent RichEdit versions
}
