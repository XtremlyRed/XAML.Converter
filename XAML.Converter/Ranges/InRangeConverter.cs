using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace XAML.Converter;

/// <summary>
///  a <see langword="class"/> of <see cref="InRangeConverter"/>
/// </summary>
public class InRangeConverter : TrueFalseConverter<object>
{
    /// <summary>
    /// min value
    /// </summary>
    public double MinValue { get; set; }

    /// <summary>
    /// max value
    /// </summary>
    public double MaxValue { get; set; }

    /// <summary>
    /// include equals
    /// </summary>

    public bool IncludeEquals { get; set; }

    /// <summary>
    /// value convert
    /// </summary>
    /// <param name="value"></param>
    /// <param name="targetType"></param>
    /// <param name="parameter"></param>
    /// <param name="culture"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    protected override object? Convert(object value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is sbyte or byte or short or ushort or int or uint or long or ulong or float or double or decimal)
        {
            var dValue = System.Convert.ToDouble(value);

            if (IncludeEquals && dValue.CompareTo(MinValue) >= 0 && MaxValue.CompareTo(dValue) >= 0)
            {
                return True;
            }
            else if (dValue.CompareTo(MinValue) > 0 && MaxValue.CompareTo(dValue) > 0)
            {
                return True;
            }

            return False;
        }

        throw new ArgumentException("invalid number type");
    }
}
