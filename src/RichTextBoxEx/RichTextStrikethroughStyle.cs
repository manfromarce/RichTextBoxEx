using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace RichTextBoxEx;

public enum RichTextStrikethroughStyle
{    
    Non,
    Single,
    [SupportedOSPlatform("windows8.0")]
    Double
}
