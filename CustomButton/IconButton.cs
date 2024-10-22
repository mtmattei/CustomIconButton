using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uno.Themes;
using Microsoft.UI.Xaml.Media.Animation;



namespace CustomButton;

public class IconButton : Button
{
    public static readonly DependencyProperty IconSourceProperty =
        DependencyProperty.Register(nameof(IconSource), typeof(IconSource), typeof(IconButton),
            new PropertyMetadata(null));

    public static readonly DependencyProperty IconSizeProperty =
        DependencyProperty.Register(nameof(IconSize), typeof(double), typeof(IconButton),
            new PropertyMetadata(20.0));

    public IconSource IconSource
    {
        get => (IconSource)GetValue(IconSourceProperty);
        set => SetValue(IconSourceProperty, value);
    }

    public double IconSize
    {
        get => (double)GetValue(IconSizeProperty);
        set => SetValue(IconSizeProperty, value);
    }

    public IconButton()
    {
        DefaultStyleKey = typeof(IconButton);
    }
}
