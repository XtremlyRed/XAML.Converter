using System.Windows;

namespace XAML.Converter;

/// <summary>
/// a class of <see cref="LessThanOrEqualConverter"/>
/// </summary>
/// <seealso cref="CompareConverter" />
public class LessThanOrEqualConverter : CompareConverter
{
    /// <summary>
    /// create a new instance of <see cref="LessThanOrEqualConverter"/>
    /// </summary>
    public LessThanOrEqualConverter()
        : base(CompareMode.LessThanOrEqual) { }
}

/// <summary>
/// a class of <see cref="LessThanOrEqualToVisitilityConverter"/>
/// </summary>
/// <seealso cref="LessThanOrEqualToVisitilityConverter" />
public class LessThanOrEqualToVisitilityConverter : CompareConverter
{
    /// <summary>
    /// create a new instance of <see cref="EqualConverter"/>
    /// </summary>
    public LessThanOrEqualToVisitilityConverter()
        : base(CompareMode.LessThanOrEqual)
    {
        True = Visibility.Visible;
        False = Visibility.Collapsed;
    }
}
