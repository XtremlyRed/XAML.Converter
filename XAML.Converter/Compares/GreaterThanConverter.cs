using System.Windows;

namespace XAML.Converter;

/// <summary>
/// a class of <see cref="GreaterThanConverter"/>
/// </summary>
/// <seealso cref="CompareConverter" />
public class GreaterThanConverter : CompareConverter
{
    /// <summary>
    /// create a new instance of <see cref="GreaterThanConverter"/>
    /// </summary>
    public GreaterThanConverter()
        : base(CompareMode.GreaterThan) { }
}

/// <summary>
/// a class of <see cref="GreaterThanToVisitilityConverter"/>
/// </summary>
/// <seealso cref="GreaterThanToVisitilityConverter" />
public class GreaterThanToVisitilityConverter : CompareConverter
{
    /// <summary>
    /// create a new instance of <see cref="EqualConverter"/>
    /// </summary>
    public GreaterThanToVisitilityConverter()
        : base(CompareMode.GreaterThan)
    {
        True = Visibility.Visible;
        False = Visibility.Collapsed;
    }
}
