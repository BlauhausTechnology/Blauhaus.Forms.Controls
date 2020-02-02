using Blauhaus.Forms.Controls.Core.Converters;
using Xamarin.Forms;

namespace Blauhaus.Forms.Controls.Core.Extensions
{
    public static class VisualElementExtensions
    {
        public static TControl WithBackgroundColour<TControl>(this TControl control, Color color) where TControl : VisualElement
        {
            control.BackgroundColor = color;
            return control;
        }

        public static TControl WithHeightRequest<TControl>(this TControl control, double value) where TControl : VisualElement
        {
            control.HeightRequest = value;
            return control;
        }
        
        public static TControl WithWidthRequest<TControl>(this TControl control, double value) where TControl : VisualElement
        {
            control.WidthRequest = value;
            return control;
        }

        public static TControl BindIsVisible<TControl>(this TControl control, string viewModelPropertyName) where TControl : VisualElement
        {
            control.SetBinding(VisualElement.IsVisibleProperty, viewModelPropertyName);
            return control;
        }
        
        public static TControl BindIsVisibleInverse<TControl>(this TControl control, string viewModelPropertyName) where TControl : VisualElement
        {
            control.SetBinding(VisualElement.IsVisibleProperty, viewModelPropertyName, BindingMode.Default, new BoolInverseConverter());
            return control;
        }

    }
}