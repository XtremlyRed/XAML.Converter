using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAML.Converter;

/// <summary>
/// a class of <see cref="BrushExtension"/>
/// </summary>
public class BrushExtension
#if __WPF__ || __AVALONIA__
    : MarkupExtension
#elif __MAUI__
    : IMarkupExtension
#endif

{
    /// <summary>
    /// Initializes a new instance of the <see cref="BrushExtension"/> class.
    /// </summary>
    public BrushExtension() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="BrushExtension"/> class.
    /// </summary>
    /// <param name="color">The color.</param>
    public BrushExtension(Color color)
    {
        Color = color;
    }

    /// <summary>
    /// color.
    /// </summary>
    public Color Color { get; set; } = default!;

#if __WPF__ || __AVALONIA__
    /// <summary>
    /// opacity.
    /// </summary>
    public double Opacity { get; set; } = 1;
#endif

    /// <summary>
    /// provide value
    /// </summary>
    /// <param name="serviceProvider"> </param>
    public
#if __WPF__ || __AVALONIA__
    override
#endif

    object ProvideValue(IServiceProvider serviceProvider)
    {
#if __WPF__ || __AVALONIA__
        return new SolidColorBrush(Color) { Opacity = Opacity };
#elif __MAUI__
        return new SolidColorBrush(Color);
#endif

        throw new NotSupportedException();
    }
}
