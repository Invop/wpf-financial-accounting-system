using System.Windows;

namespace wpf_financial_accounting_system.Helpers;

public static class FontAwesomeHelper
{
    public static readonly DependencyProperty IconProperty =
        DependencyProperty.RegisterAttached(
            "Icon",
            typeof(string),
            typeof(FontAwesomeHelper),
            new PropertyMetadata(string.Empty));

    public static string GetIcon(UIElement element)
    {
        return (string)element.GetValue(IconProperty);
    }

    public static void SetIcon(UIElement element, string value)
    {
        element.SetValue(IconProperty, value);
    }
}
