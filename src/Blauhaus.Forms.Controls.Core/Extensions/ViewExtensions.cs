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


    }
}