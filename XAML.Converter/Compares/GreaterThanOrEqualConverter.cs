using System.Windows;

namespace XAML.Converter;

/// <summary>
/// a class of <see cref="GreaterThanOrEqualConverter"/>
/// </summary>
/// <seealso cref="CompareConverter" />
public class GreaterThanOrEqualConverter : CompareConverter
{
    /// <summary>
    /// create a new instance of <see cref="GreaterThanOrEqualConverter"/>
    /// </summary>
    public GreaterThanOrEqualConverter()
        : base(CompareMode.GreaterThanOrEqual) { }
}

/// <summary>
/// a class of <see cref="GreaterThanOrEqualToVisitilityConverter"/>
/// </summary>
/// <seealso cref="GreaterThanOrEqualToVisitilityConverter" />
public class GreaterThanOrEqualToVisitilityConverter : CompareConverter
{
    /// <summary>
    /// create a new instance of <see cref="EqualConverter"/>
    /// </summary>
    public GreaterThanOrEqualToVisitilityConverter()
        : base(CompareMode.GreaterThanOrEqual)
    {
        True = Visibility.Visible;
        False = Visibility.Collapsed;
    }
}
