using System;
using Blauhaus.Forms.Controls.Core.Converters;
using Xamarin.Forms;

namespace Blauhaus.Forms.Controls.Core.Extensions
{
    public static class ViewExtensions
    {
        public static TControl WithHorizontalOptions<TControl>(this TControl control, LayoutOptions value) where TControl : View
        {
            control.HorizontalOptions = value;
            return control;
        }
        public static TControl WithVerticalOptions<TControl>(this TControl control, LayoutOptions value) where TControl : View
        {
            control.VerticalOptions = value;
            return control;
        }

        public static TControl BindBackgroundColourToBool<TControl>(this TControl control, string viewModelBoolenPropertyName, 
            Color trueColor, Color falseColor) where TControl : VisualElement
        {
            control.SetBinding(VisualElement.BackgroundColorProperty, new Binding(viewModelBoolenPropertyName, BindingMode.OneWay, new BoolToColorConverter(
                trueColor, falseColor)));
            return control;
        }

        public static TControl WithPadding<TControl>(this TControl control, double padding) where TControl : Layout
        {
            control.Padding = padding;
            return control;
        }

        public static TControl WithTapGestureRecognizer<TControl>(this TControl control, string viewModelCommandName) where TControl : View
        {
            var tgr = new TapGestureRecognizer();
            tgr.SetBinding(TapGestureRecognizer.CommandProperty, viewModelCommandName);
            control.GestureRecognizers.Add(tgr);
            return control;
        }
        
        public static TControl BindIsVisibleToStringNotEmpty<TControl>(
            this TControl control,
            string viewModelPropertyName)
            where TControl : VisualElement
        {
            control.SetBinding(VisualElement.IsVisibleProperty, viewModelPropertyName, BindingMode.Default, new StringNotEmptyToBoolConverter(), (string) null);
            return control;
        }

        
        public static TControl OnTap<TControl>(this TControl control, Action action) where TControl : View
        {
            var tgr = new TapGestureRecognizer {Command = new Command(action)};
            control.GestureRecognizers.Add(tgr);
            return control;
        }

    }
}