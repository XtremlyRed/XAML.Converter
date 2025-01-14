namespace XAML.Converter;

/// <summary>
/// a class of <see cref="ColorExtension"/>
/// </summary>
public class ColorExtension
#if __WPF__ || __AVALONIA__
    : MarkupExtension
#elif __MAUI__
    : IMarkupExtension
#endif

{
    /// <summary>
    /// Initializes a new instance of the <see cref="ColorExtension"/> class.
    /// </summary>
    public ColorExtension() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="ColorExtension"/> class.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="r"></param>
    /// <param name="g"></param>
    /// <param name="b"></param>
    public ColorExtension(byte a, byte r, byte g, byte b)
    {
        A = a;
        R = r;
        G = g;
        B = b;
    }

    /// <summary>
    /// r channel
    /// </summary>
    public byte R { get; set; }

    /// <summary>
    /// g channel
    /// </summary>
    public byte G { get; set; }

    /// <summary>
    /// b channel
    /// </summary>
    public byte B { get; set; }

    /// <summary>
    /// a channel
    /// </summary>
    public byte A { get; set; } = 0xff;

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
#if __WPF__
        return new Color()
        {
            A = A,
            R = R,
            G = G,
            B = B,
        };
#elif __AVALONIA__
        return new Color(A, R, G, B);
#elif __MAUI__
        return new Color(R, G, B, A);
#else
        throw new NotSupportedException();
#endif
    }
}
