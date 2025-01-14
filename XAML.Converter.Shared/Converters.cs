using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace XAML.Converter;

/// <summary>
/// a class of <see cref="Converters"/>
/// </summary>
public static partial class Converters
{
    static object TrueObject = (object)true;
    static object FalseObject = (object)false;

    /// <summary>
    ///  <see cref="Boolean"/> reverse converter
    /// </summary>
    public static BooleanConverter BooleanReverse = new() { True = FalseObject, False = TrueObject };

    /// <summary>
    /// get enum description
    /// </summary>
    public static EnumDescriptionConverter GetEnumDescription = new();

    /// <summary>
    /// get enum display name
    /// </summary>
    public static EnumDisplayNameConverter GetEnumDisplayName = new();

#if __WPF__

    /// <summary>
    /// <see cref="string"/> to Color converter
    /// </summary>

    public static ColorStringConverter StringToColor = new();

    /// <summary>
    /// <see cref="string"/> to Brush converter
    /// </summary>

    public static BrushStringConverter StringToBrush = new();
#endif

    /// <summary>
    /// get <see cref="IEnumerable"/> count
    /// </summary>
    public static LengthConverter GetLength = new();

    /// <summary>
    /// <see cref="IEnumerable"/> <see langword="null"/> or empty to <see cref="bool"/> converter
    /// </summary>
    public static NullOrEmptyConverter IsNullOrEmpty = new() { True = TrueObject, False = FalseObject };

    /// <summary>
    /// <see cref="IEnumerable"/> not <see langword="null"/> or empty to <see cref="bool"/> converter
    /// </summary>
    public static NotNullOrEmptyConverter IsNotNullOrEmpty = new() { True = TrueObject, False = FalseObject };

    /// <summary>
    /// <see cref="string"/> <see langword="null"/> or white space to <see cref="bool"/> converter
    /// </summary>
    public static NullOrWhiteSpaceConverter IsNullOrWhiteSpace = new() { True = TrueObject, False = FalseObject };

    /// <summary>
    /// <see cref="string"/> not <see langword="null"/> or white space to <see cref="bool"/> converter
    /// </summary>
    public static NotNullOrWhiteSpaceConverter IsNotNullOrWhiteSpace = new() { True = TrueObject, False = FalseObject };

    /// <summary>
    /// <see cref="object"/> <see langword="null"/> to <see cref="bool"/> converter
    /// </summary>
    public static NullConverter IsNull = new() { True = TrueObject, False = FalseObject };

    /// <summary>
    /// <see cref="object"/> not <see langword="null"/> to <see cref="bool"/> converter
    /// </summary>
    public static NotNullConverter IsNotNull = new() { True = TrueObject, False = FalseObject };

#if __WPF__ || __MAUI__

    static object VisibleObject = (object)Visibility.Visible;
    static object CollapsedObject = (object)Visibility.Collapsed;

    /// <summary>
    /// <see cref="Boolean"/> to <see cref="Visibility"/> converter
    /// </summary>
    public static BooleanConverter BooleanToVisibility = new() { True = VisibleObject, False = CollapsedObject };

    /// <summary>
    /// <see cref="Boolean"/> to <see cref="Visibility"/> reverse converter
    /// </summary>
    public static BooleanConverter BooleanToVisibilityReverse = new() { True = CollapsedObject, False = VisibleObject };

    /// <summary>
    /// <see cref="IEnumerable"/> <see langword="null"/> or empty to <see cref="Visibility"/> converter
    /// </summary>
    public static NullOrEmptyConverter IsNullOrEmptyToVisibility = new() { True = VisibleObject, False = CollapsedObject };

    /// <summary>
    /// <see cref="IEnumerable"/> not <see langword="null"/> or empty to <see cref="Visibility"/> converter
    /// </summary>
    public static NotNullOrEmptyConverter IsNotNullOrEmptyToVisibility = new() { True = VisibleObject, False = CollapsedObject };

    /// <summary>
    /// <see cref="string"/> <see langword="null"/> or white space to <see cref="Visibility"/> converter
    /// </summary>
    public static NullOrWhiteSpaceConverter IsNullOrWhiteSpaceToVisibility = new() { True = VisibleObject, False = CollapsedObject };

    /// <summary>
    /// <see cref="string"/> not <see langword="null"/> or white space to <see cref="Visibility"/> converter
    /// </summary>
    public static NotNullOrWhiteSpaceConverter IsNotNullOrWhiteSpaceToVisibility = new() { True = VisibleObject, False = CollapsedObject };

    /// <summary>
    /// <see cref="object"/> <see langword="null"/> to <see cref="Visibility"/> converter
    /// </summary>
    public static NullConverter IsNullToVisibility = new() { True = VisibleObject, False = CollapsedObject };

    /// <summary>
    /// <see cref="object"/> not <see langword="null"/> to <see cref="Visibility"/> converter
    /// </summary>
    public static NotNullConverter IsNotNullToVisibility = new() { True = VisibleObject, False = CollapsedObject };

    /// <summary>
    /// equal to <see cref="Visibility"/> converter
    /// </summary>
    public static EqualConverter EqualToVisibility = new() { True = VisibleObject, False = CollapsedObject };

    /// <summary>
    /// greater than to <see cref="Visibility"/> converter
    /// </summary>
    public static GreaterThanConverter GreaterThanToVisibility = new() { True = VisibleObject, False = CollapsedObject };

    /// <summary>
    /// greater than or equal to <see cref="Visibility"/> converter
    /// </summary>
    public static GreaterThanOrEqualConverter GreaterThanOrEqualToVisibility = new() { True = VisibleObject, False = CollapsedObject };

    /// <summary>
    /// less than to <see cref="Visibility"/> converter
    /// </summary>
    public static LessThanConverter LessThanToVisibility = new() { True = VisibleObject, False = CollapsedObject };

    /// <summary>
    /// less than or equal to <see cref="Visibility"/> converter
    /// </summary>
    public static LessThanOrEqualConverter LessThanOrEqualToVisibility = new() { True = VisibleObject, False = CollapsedObject };

    /// <summary>
    /// not equal to <see cref="Visibility"/> converter
    /// </summary>
    public static NotEqualConverter NotEqualToVisibility = new() { True = VisibleObject, False = CollapsedObject };

#endif
}
