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
            new PropertyMetadata(null));  // PropertyChanged callback no longer needed

    public IconSource IconSource
    {
        get => (IconSource)GetValue(IconSourceProperty);
        set => SetValue(IconSourceProperty, value);
    }

    public IconButton()
    {
        DefaultStyleKey = typeof(IconButton);
    }
}
