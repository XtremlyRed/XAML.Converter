using System.Windows;

namespace XAML.Converter;

/// <summary>
/// a class of <see cref="LessThanConverter"/>
/// </summary>
/// <seealso cref="CompareConverter" />
public class LessThanConverter : CompareConverter
{
    /// <summary>
    /// create a new instance of <see cref="LessThanConverter"/>
    /// </summary>
    public LessThanConverter()
        : base(CompareMode.LessThan) { }
}

/// <summary>
/// a class of <see cref="LessThanToVisitilityConverter"/>
/// </summary>
/// <seealso cref="LessThanToVisitilityConverter" />
public class LessThanToVisitilityConverter : CompareConverter
{
    /// <summary>
    /// create a new instance of <see cref="EqualConverter"/>
    /// </summary>
    public LessThanToVisitilityConverter()
        : base(CompareMode.LessThan)
    {
        True = Visibility.Visible;
        False = Visibility.Collapsed;
    }
}
