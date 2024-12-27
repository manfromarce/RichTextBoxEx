using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichTextBoxEx;

public abstract class RichTextLineSpacing 
{
    /// <summary>
    /// Get or set the spacing rule 
    /// (0 = single, 1 = one-and-a-half, 2 = double,
    /// 3 = minimum, 4 = exact, 5 = multiple)
    /// </summary>
    internal byte SpacingRule { get; set; } = 0;

    /// <summary>
    /// Get or set the spacing value in twips (for Exact and Minimum modes) or lines * 20 (for Multiple mode).
    /// This property is not relevant for Single, OneAndHalf and Double spacing modes.
    /// </summary>
    internal int SpacingValue { get; set; } = 1;
}

/// <summary>
/// Single line spacing
/// </summary>
public class SingleLineSpacing : RichTextLineSpacing 
{ 
    /// <summary>
    /// Create a new single spacing rule.
    /// </summary>
    public SingleLineSpacing()
    {
        SpacingRule = 0;
    }
}

/// <summary>
/// One-and-a-half spacing
/// </summary>
public class OneAndHalfLineSpacing : RichTextLineSpacing
{
    /// <summary>
    /// Create a new one-and-a-half spacing rule.
    /// </summary>
    public OneAndHalfLineSpacing()
    {
        SpacingRule = 1;
    }
}

/// <summary>
/// Double spacing
/// </summary>
public class DoubleLineSpacing : RichTextLineSpacing
{
    /// <summary>
    /// Create a new double spacing rule.
    /// </summary>
    public DoubleLineSpacing()
    {
        SpacingRule = 2;
    }
}

/// <summary>
/// Value is interpreted as the spacing from one line to the next, in points. 
/// However, the control displays single-spaced text if value is less than single spacing.
/// </summary>
public class MinimumLineSpacing : RichTextLineSpacing
{
    /// <summary>
    /// Create a new minimum line spacing rule. 
    /// Value is interpreted as the spacing from one line to the next, in points. 
    /// However, the control displays single-spaced text if value is less than single spacing.
    /// </summary>
    /// <param name="value">Line spacing value in points (must be greater than 0).</param>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public MinimumLineSpacing(int value)
    {
        if (value <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(value), "Spacing value must be greater than zero for Minimum, Exact and Multiple spacing modes.");
        }
        SpacingRule = 3;
        SpacingValue = value * 20; // Convert points to twips
    }

    internal MinimumLineSpacing()
    {
        SpacingRule = 3;
    }

    /// <summary>
    /// Get the line spacing value in points.
    /// </summary>
    public int Value
    {
        get
        {
            return SpacingValue / 20; // Convert twips to points.
        }
    }
}

/// <summary>
/// Value is interpreted as the spacing from one line to the next, in points. 
/// The control uses the exact spacing specified, even if less than single spacing.
/// </summary>
public class ExactLineSpacing : RichTextLineSpacing
{
    /// <summary>
    /// Create a new exact line spacing rule. 
    /// Value is interpreted as the spacing from one line to the next, in points. 
    /// The control uses the exact spacing specified, even if less than single spacing.
    /// </summary>
    /// <param name="value">Line spacing value in points (must be greater than 0).</param>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public ExactLineSpacing(int value)
    {
        if (value <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(value), "Spacing value must be greater than zero for Minimum, Exact and Multiple spacing modes.");
        }
        SpacingRule = 4;
        SpacingValue = value * 20; // Convert points to twips
    }

    internal ExactLineSpacing()
    {
        SpacingRule = 4;
    }

    /// <summary>
    /// Get the line spacing value in points.
    /// </summary>
    public int Value
    {
        get
        {
            return SpacingValue / 20; // Convert twips to points
        }
    }
}

/// <summary>
/// Value is interpreted as the spacing in lines (1, 1.5, 2, 3...) from one line to the next.
/// </summary>
public class MultipleLineSpacing : RichTextLineSpacing
{
    /// <summary>
    /// Create a new multiple line spacing rule. 
    /// Value is interpreted as the spacing in lines (1, 1.5, 2, 3...) from one line to the next.
    /// </summary>
    /// <param name="value">Line spacing value in lines (must be greater than 0).</param>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public MultipleLineSpacing(decimal value)
    {
        if (value <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(value), "Spacing value must be greater than zero for Minimum, Exact and Multiple spacing modes.");
        }
        SpacingRule = 5;
        SpacingValue = (int)(value * 20); // Convert lines to multiplier
    }

    internal MultipleLineSpacing()
    {
        SpacingRule = 5;
    }

    /// <summary>
    /// Get the line spacing value in lines.
    /// </summary>
    public decimal Value
    {
        get
        {
            return decimal.Divide(SpacingValue, 20); // Convert multiplier (lines * 20) to lines
        }
    }
}