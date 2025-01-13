using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Windows.Media;

namespace XAML.Converter;

/// <summary>
/// a class of <see cref="BrushExtension"/>
/// </summary>
/// <seealso cref="System.Windows.Markup.MarkupExtension" />
[MarkupExtensionReturnType(typeof(SolidColorBrush))]
public class BrushExtension : MarkupExtension
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
    public Color Color { get; set; }

    /// <summary>
    /// opacity.
    /// </summary>
    public double Opacity { get; set; } = 1;

    /// <summary>
    /// provide value
    /// </summary>
    /// <param name="serviceProvider"> </param>
    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        return new SolidColorBrush(Color) { Opacity = Opacity };
    }
}
