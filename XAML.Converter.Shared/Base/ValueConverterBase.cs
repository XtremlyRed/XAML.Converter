using System.ComponentModel;
using System.Globalization;
using System.Windows;

namespace XAML.Converter;

/// <summary>
/// a class of <see cref="ValueConverterBase{T,TP}"/>
/// </summary>
/// <seealso cref="IValueConverter" />
public abstract partial class ValueConverterBase<Input, InputParameter> :
#if __WPF__ || __AVALONIA__
    MarkupExtension,
#elif __MAUI__
    IMarkupExtension,
#endif

        IValueConverter
{
    /// <summary>
    /// Converts the specified value.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="targetType">Type of the target.</param>
    /// <param name="parameter">The parameter.</param>
    /// <param name="culture">The culture.</param>
    /// <returns></returns>
    protected abstract object? Convert(Input value, Type targetType, InputParameter? parameter, CultureInfo culture);

    object? IValueConverter.Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        var targetValue = InputConvert(value);
        var targetParameter = InputParameterConvert(parameter);
        return this.Convert(targetValue, targetType, targetParameter, culture);
    }

    /// <summary>
    ///  type verify
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    protected virtual Input InputConvert(object? value)
    {
        if (value is not Input targetValue)
        {
            throw new ArgumentException($"current value type is not {typeof(Input).FullName}");
        }

        return targetValue;
    }

    /// <summary>
    /// type verify
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    protected virtual InputParameter InputParameterConvert(object? value)
    {
        if (value is not InputParameter targetValue)
        {
            throw new ArgumentException($"current value type is not {typeof(InputParameter).FullName}");
        }

        return targetValue;
    }

    /// <summary>
    /// Converts the back.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="targetType">Type of the target.</param>
    /// <param name="parameter">The parameter.</param>
    /// <param name="culture">The culture.</param>
    /// <returns></returns>
    protected virtual object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotSupportedException();
    }

    object? IValueConverter.ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return ConvertBack(value, targetType, parameter, culture);
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="serviceProvider"></param>
    /// <returns></returns>
    public
#if __WPF__ || __AVALONIA__
    override
#endif

    object ProvideValue(IServiceProvider serviceProvider)
    {
        return this;
    }
}

/// <summary>
/// a class of <see cref="ValueConverterBase{T}"/>
/// </summary>
/// <seealso cref="IValueConverter" />
public abstract class ValueConverterBase<T> : ValueConverterBase<T, object>, IValueConverter { }
