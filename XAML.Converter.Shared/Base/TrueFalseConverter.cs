using System.ComponentModel;

namespace XAML.Converter;

/// <summary>
/// a class of <see cref="TrueFalseConverter{T}"/>
/// </summary>
/// <seealso cref="IValueConverter" />

[EditorBrowsable(EditorBrowsableState.Never)]
public abstract class TrueFalseConverter<T> : ValueConverterBase<T>, IValueConverter
{
    /// <summary>
    /// true value
    /// </summary>
    public object? True { get; set; }

    /// <summary>
    ///  false value
    /// </summary>
    public object? False { get; set; }
}
