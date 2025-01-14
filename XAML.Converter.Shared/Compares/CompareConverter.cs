using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Windows;

namespace XAML.Converter;

/// <summary>
/// a class of <see cref="CompareConverter"/>
/// </summary>
public abstract class CompareConverter : TrueFalseConverter<IComparable>
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    private readonly CompareMode compareMode;

    /// <summary>
    /// create a new instance of <see cref="CompareConverter"/>
    /// </summary>
    /// <param name="compareMode"></param>
    protected CompareConverter(CompareMode compareMode)
    {
        this.compareMode = compareMode;
    }

    /// <summary>
    /// Gets or sets the compare value.
    /// </summary>
    /// <value>
    /// The compare value.
    /// </value>
    public IComparable? Input { get; set; }

    /// <summary>
    ///
    /// </summary>
    /// <param name="value"></param>
    /// <param name="targetType"></param>
    /// <param name="parameter"></param>
    /// <param name="culture"></param>
    /// <returns></returns>
    protected override object? Convert(IComparable value, Type targetType, object? parameter, CultureInfo culture)
    {
        bool condiction = Match(value, Input, compareMode);

        return condiction ? True : False;
    }

    /// <summary>
    /// Matches the specified value.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="comparer">The comparer.</param>
    /// <param name="compareMode">The compare mode.</param>
    /// <returns></returns>
    public static bool Match(IComparable? value, IComparable? comparer, CompareMode? compareMode)
    {
        return compareMode switch
        {
            CompareMode.Equal => value!.CompareTo(comparer) == 0,
            CompareMode.NotEqual => value!.CompareTo(comparer) != 0,
            CompareMode.GreaterThan => value!.CompareTo(comparer) > 0,
            CompareMode.GreaterThanOrEqual => value!.CompareTo(comparer) >= 0,
            CompareMode.LessThan => value!.CompareTo(comparer) < 0,
            CompareMode.LessThanOrEqual => value!.CompareTo(comparer) <= 0,
            _ => true,
        };
    }
}

/// <summary>
/// compare mode
/// </summary>
public enum CompareMode
{
    /// <summary>
    /// equal
    /// </summary>
    Equal,

    /// <summary>
    /// not equal
    /// </summary>
    NotEqual,

    /// <summary>
    /// greater than
    /// </summary>
    GreaterThan,

    /// <summary>
    /// greater than or equal
    /// </summary>
    GreaterThanOrEqual,

    /// <summary>
    /// less than
    /// </summary>
    LessThan,

    /// <summary>
    /// less than or equal
    /// </summary>
    LessThanOrEqual,
}
