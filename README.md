# XAML.Converter


### `Converter` for WPF

#### 1. BoolConverter

`binding value` must be of type ***`System.Boolean`***, otherwise **Binding.DoNothing** will be output

```xml
Xaml code

<Grid>
    <Grid.Resources>
        <BoolConverter
            x:Key="BoolConverter"
            False="false value"
            True="true vallue" />
        <BoolConverter
            x:Key="BoolToVisibilityConverter"
            False="{x:Static Visibility.Collapsed}"
            True="{x:Static Visibility.Visible}" />
    </Grid.Resources>
    <TextBlock Text="{Binding Result, Converter={StaticResource BoolConverter}}" />
    <TextBlock Visibility="{Binding Result, Converter={StaticResource BoolToVisibilityConverter}}" />
</Grid>
```

```csharp
CSharp code
public bool Result { get; set; } = true;
```

#### 2. CompareConverter 

* EqualConverter
* GreaterThanConverter
* GreaterThanOrEqualConverter
* LessThanConverter
* LessThanOrEqualConverter
* NotEqualConverter
 

#### 3. EnumConverter

* EnumDescriptionConverter
* EnumDisplayNameConverter

#### 4. MediaConverter

* BrushStringConverter
* ColorStringConverter


#### 5. EnumerableConverter

* LengthConverter
* NullOrEmptyConverter
* NotNullOrEmptyConverter

#### 6. ObjectConverter

* NotNullConverter 
* NullConverter

#### 7. EnumConverter

* NotNullOrWhiteSpaceConverter
* NullOrWhiteSpaceConverter

#### 8. RangeConverter

* InRangeConverter
* OutOfRangeConverter

#### 9. RangeConverter

* CompositeConverter
* FuncConverter

