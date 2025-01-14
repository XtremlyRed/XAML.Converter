namespace XAML.Converter;

using System.Windows;

/// <summary>
/// a class of <see cref="BrushStringConverter"/>
/// </summary>
public class BrushStringConverter : MediaConverter<string, Brush>
{
#if __WPF__
    static BrushConverter brushConverter = new BrushConverter();
#endif

    /// <summary>
    /// convert from
    /// </summary>
    /// <param name="from"></param>
    /// <returns></returns>
    protected override Brush ConvertFrom(string from)
    {
#if __WPF__
        return (Brush)brushConverter.ConvertFrom(from)!;
#elif __AVALONIA__
        return new SolidColorBrush(Color.Parse(from));
#elif __MAUI__
        return new SolidColorBrush(Color.FromArgb(from));
#else
        throw new NotImplementedException();
#endif
    }
}
