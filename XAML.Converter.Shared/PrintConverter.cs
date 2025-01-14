using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace XAML.Converter;

/// <summary>
/// a class of <see cref="PrintConverter"/>
/// </summary>
public class PrintConverter : IValueConverter
{
    [DebuggerBrowsable(Never)]
    static Func<object, string>? func;

    /// <summary>
    /// object to stirng
    /// </summary>
    /// <param name="func"></param>
    public static void SetObjectToStringConverter(Func<object, string> func)
    {
        PrintConverter.func = func;
    }

    /// <summary>
    /// printable
    /// </summary>
    public bool Printable { get; set; }

    object? IValueConverter.Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (Printable)
        {
            var display = func?.Invoke(value!) ?? value;
            Trace.WriteLine(display);
        }

        return value;
    }

    object? IValueConverter.ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return value;
    }
}
