using Xamarin.Forms;

namespace Blauhaus.Forms.Controls.Core.Controls.LayoutControls
{
    public class StacklayoutControl : StackLayout
    {
        public StacklayoutControl()
        {
            VerticalOptions = LayoutOptions.FillAndExpand;
            HorizontalOptions = LayoutOptions.FillAndExpand;
        }


        public StacklayoutControl WithChild(View child)
        {
            Children.Add(child);
            return this;
        }
        public StacklayoutControl WithSpacing(double value)
        {
            Spacing = value;
            return this;
        }
        public StacklayoutControl WithPadding(double value)
        {
            Padding = value;
            return this;
        }
        public StacklayoutControl WithPadding(double left, double top, double right, double bottom)
        {
            Padding = new Thickness(left, right, top, bottom);
            return this;
        }
        public StacklayoutControl WithPadding(double horizontal, double vertical)
        {
            Padding = new Thickness(horizontal, vertical);
            return this;
        }

        public StacklayoutControl WithOrientation(StackOrientation value)
        {
            Orientation = value;
            return this;
        }

    }
}