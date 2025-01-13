using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace XAML.Converter;

/// <summary>
///   a class of <see cref="FuncConverter"/>
/// </summary>
public class FuncConverter : IValueConverter
{
    private readonly Func<object, Type, object, CultureInfo, object>? converter1;
    private readonly Func<object, Type, object, object>? converter2;

    /// <summary>
    /// Initializes a new instance of the <see cref="FuncConverter"/> class.
    /// </summary>
    public FuncConverter(Func<object, Type, object, CultureInfo, object> converter1)
    {
        this.converter1 = converter1;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FuncConverter"/> class.
    /// </summary>
    public FuncConverter(Func<object, Type, object, object> converter2)
    {
        this.converter2 = converter2;
    }

    object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (converter1 is not null)
        {
            return converter1(value, targetType, parameter, culture);
        }

        if (converter2 is not null)
        {
            return converter2(value, targetType, parameter);
        }

        return DependencyProperty.UnsetValue;
    }

    object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FuncConverter"/> class.
    /// </summary>
    /// <param name="converter1"></param>

    public static implicit operator FuncConverter(Func<object, Type, object, CultureInfo, object> converter1)
    {
        _ = converter1 ?? throw new ArgumentNullException(nameof(converter1));

        return new FuncConverter(converter1);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FuncConverter"/> class.
    /// </summary>
    /// <param name="converter2"></param>

    public static implicit operator FuncConverter(Func<object, Type, object, object> converter2)
    {
        _ = converter2 ?? throw new ArgumentNullException(nameof(converter2));

        return new FuncConverter(converter2);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FuncConverter"/> class.
    /// </summary>
    /// <param name="converter2"></param>
    public static IValueConverter Create(Func<object, Type, object, object> converter2)
    {
        _ = converter2 ?? throw new ArgumentNullException(nameof(converter2));

        return new FuncConverter(converter2);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FuncConverter"/> class.
    /// </summary>
    /// <param name="converter1"></param>
    public static IValueConverter Create(Func<object, Type, object, CultureInfo, object> converter1)
    {
        _ = converter1 ?? throw new ArgumentNullException(nameof(converter1));

        return new FuncConverter(converter1);
    }
}
