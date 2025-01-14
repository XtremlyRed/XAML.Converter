using System.Windows;

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
#if __WPF__
        return (Color)ColorConverter.ConvertFromString(from);
#elif __AVALONIA__
        return Color.Parse(from);
#elif __MAUI__
        return Color.FromArgb(from);
#endif

        throw new NotImplementedException();
    }
}
