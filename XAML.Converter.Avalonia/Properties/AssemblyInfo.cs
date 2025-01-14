global using System;
global using System.ComponentModel;
global using static System.Diagnostics.DebuggerBrowsableState;
global using System.Linq;
global using System.Runtime.InteropServices;
global using Avalonia;
global using Avalonia.Data;
global using Avalonia.Data.Converters;
global using Avalonia.Markup;
global using Avalonia.Media;
global using Avalonia.Metadata;
global using Application = Avalonia.Application;
global using BF = System.Reflection.BindingFlags;
global using Binding = Avalonia.Data.Binding;
global using Brush = Avalonia.Media.Brush;
global using Brushes = Avalonia.Media.Brushes;
global using Button = Avalonia.Controls.Button;
global using Color = Avalonia.Media.Color;
global using ComboBox = Avalonia.Controls.ComboBox;
global using ContentPropertyAttribute = XAML.Converter.ContentPropertyAttribute;
global using DBA = System.Diagnostics.DebuggerBrowsableAttribute;
global using IValueConverter = Avalonia.Data.Converters.IValueConverter;
global using MarkupExtension = Avalonia.Markup.Xaml.MarkupExtension;
global using Panel = Avalonia.Controls.Panel;
global using Point = Avalonia.Point;
global using Size = Avalonia.Size;
global using TextBox = Avalonia.Controls.TextBox;
global using UserContorl = Avalonia.Controls.UserControl;

[assembly: XmlnsDefinition("http://schemas.microsoft.com/winfx/2006/xaml/presentation", "XAML.Converter")]
[assembly: XmlnsDefinition("https://github.com/xtremlyred/XAML.Converter", "XAML.Converter")]
[assembly: XmlnsPrefix("XAML.Converter", "converter")]

namespace System.Runtime.CompilerServices
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal class IsExternalInit { }
}

namespace XAML.Converter
{
    /// <summary>
    /// content property
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [AttributeUsage(AttributeTargets.Class)]
    public class ContentPropertyAttribute : Attribute
    {
        /// <summary>
        /// content property
        /// </summary>
        public string ContentProperty { get; }

        /// <summary>
        ///
        /// </summary>
        /// <param name="contentProperty"></param>
        public ContentPropertyAttribute(string contentProperty)
        {
            ContentProperty = contentProperty;
        }
    }
}
