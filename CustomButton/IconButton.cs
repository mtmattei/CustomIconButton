using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uno.Themes;


namespace CustomButton;
public class IconButton : Button
{
    public static readonly DependencyProperty IconProperty =
        DependencyProperty.Register(nameof(Icon), typeof(ImageSource), typeof(IconButton), new PropertyMetadata(null));

    public ImageSource Icon
    {
        get => (ImageSource)GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }

    public IconButton()
    {
        DefaultStyleKey = typeof(IconButton);
    }
}
