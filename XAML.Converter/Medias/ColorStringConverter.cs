using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace XAML.Converter;

/// <summary>
/// a class of <see cref="ColorStringConverter"/>
/// </summary>
public class ColorStringConverter : MediaConverter<string, Color>
{
    /// <summary>
    /// convert from
    /// </summary>
    /// <param name="from"></param>
    /// <returns></returns>
    protected override Color ConvertFrom(string from)
    {
        return (Color)ColorConverter.ConvertFromString(from);
    }
}
