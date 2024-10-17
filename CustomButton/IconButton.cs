using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uno.Themes;


namespace CustomButton;
public class IconButton : Button
{
    public static readonly DependencyProperty IconSourceProperty =
       DependencyProperty.Register(nameof(IconSource), typeof(IconSource), typeof(IconButton),
                new PropertyMetadata(null, OnIconSourceChanged));


    public IconSource IconSource
    {
        get => (IconSource)GetValue(IconSourceProperty);
        set => SetValue(IconSourceProperty, value);
    }

    public IconButton()
    {
        DefaultStyleKey = typeof(IconButton);
    }

    protected override void OnApplyTemplate()
    {
        base.OnApplyTemplate();
        UpdateIcon();
    }

    private static void OnIconSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is IconButton iconButton)
        {
            iconButton.UpdateIcon();
        }
    }

    private void UpdateIcon()
    {
        if (GetTemplateChild("IconElement") is IconSourceElement iconElement)
        {
            iconElement.IconSource = IconSource;
        }
    }
}

