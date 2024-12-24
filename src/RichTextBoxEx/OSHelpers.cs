using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichTextBoxEx;
public static class OSHelpers
{
    public static bool IsWindows8OrNewer()
    {
        var version = Environment.OSVersion.Version;
        return version.Major >= 6 && version.Minor >= 2;
    }
}
