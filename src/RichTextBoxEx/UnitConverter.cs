using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichTextBoxEx;

public enum Unit
{
    Centimeters,
    Millimeters,
    Inches,
    Points,
    DeviceIndipendentUnits,
    Pixels,
    Picas,
    HundrethsOfInch,
    Twips,
    Himetrics,
    Emus
}

public static class UnitConverter
{
    public const double inchToCm = 2.54;
    public const double inchToMm = 25.4;
    public const double inchToPt = 72.0;
    public const double inchToDiu = 96.0; // Used by WPF
    public const double inchToPicas = 6.0;
    public const double inchToHundrethsOfInch = 100.0; // Used by Windows Forms
    public const double inchToTwips = 1440.0; // 1/20th of point // 1 DXA (used by Open XML) is also the same
    public const double inchToHimetrics = 2540.0; // 1 Himetric = 1/100 mm
    public const double emusToInch = 1/914400; // 1 EMU = 1/914400 of inch or 1/360000 of cm; used by Open XML

    public static double ConvertUnits(double value, Unit inputUnit, Unit outputUnit, int dpi = 96)
    {
        
        // Convert input value to inches
        double inches = inputUnit switch
        {
            Unit.Centimeters => value / inchToCm,
            Unit.Millimeters => value / inchToMm,
            Unit.Inches => value,
            Unit.Points => value / inchToPt,
            Unit.DeviceIndipendentUnits => value / inchToDiu,
            Unit.Pixels => value / dpi,
            Unit.Picas => value / inchToPicas,
            Unit.HundrethsOfInch => value / inchToHundrethsOfInch,
            Unit.Twips => value / inchToTwips,
            Unit.Himetrics => value / inchToHimetrics,
            Unit.Emus => value * emusToInch,
            _ => throw new ArgumentException("Unexpected input unit.")
        };

        // Convert inches to output unit
        return outputUnit switch
        {
            Unit.Centimeters => inches * inchToCm,
            Unit.Millimeters => inches * inchToMm,
            Unit.Inches => inches,
            Unit.Points => inches * inchToPt,
            Unit.DeviceIndipendentUnits => inches * inchToDiu,
            Unit.Pixels => inches * dpi,
            Unit.Picas => inches * inchToPicas,
            Unit.HundrethsOfInch => value * inchToHundrethsOfInch,
            Unit.Twips => value * inchToTwips,
            Unit.Himetrics => value * inchToHimetrics,
            Unit.Emus => value / emusToInch,
            _ => throw new ArgumentException("Unexpected output unit.")
        };
    }

    public static Size ConvertSize(Size a4Size, Unit inputUnit, Unit outputUnit, int dpi = 96)
    {
        return new Size((int)ConvertUnits(a4Size.Width, inputUnit, outputUnit, dpi),
                        (int)ConvertUnits(a4Size.Height, inputUnit, outputUnit, dpi));
    }
}
