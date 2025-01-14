using System.Diagnostics;
using System.Globalization;
using System.Windows;

namespace XAML.Converter;

/// <summary>
///   a class of <see cref="FuncConverter"/>
/// </summary>
public class FuncConverter : IValueConverter
{
    [DebuggerBrowsable(Never)]
    private readonly Func<object, Type, object, CultureInfo, object>? converter1;

    [DebuggerBrowsable(Never)]
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

    object IValueConverter.Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (converter1 is not null)
        {
            return converter1(value!, targetType, parameter!, culture);
        }

        if (converter2 is not null)
        {
            return converter2(value!, targetType, parameter!);
        }
#if __WPF__
        return DependencyProperty.UnsetValue;
#elif __AVALONIA__
        return AvaloniaProperty.UnsetValue;
#elif __MAUI__
        return BindableProperty.UnsetValue;
#endif

        throw new NotImplementedException();
    }

    object IValueConverter.ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
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
