using Xamarin.Forms;

namespace Blauhaus.Forms.Controls.Core.Controls.LayoutControls
{
    public class FlexlayoutControl : FlexLayout
    {
        public FlexlayoutControl WithDirection(FlexDirection direction)
        {
            Direction = direction;
            return this;
        }

        public FlexlayoutControl WithAlignItems(FlexAlignItems value)
        {
            AlignItems = value;
            return this;
        }
        

        public FlexlayoutControl WithAlignContent(FlexAlignContent value)
        {
            AlignContent = value;
            return this;
        }

        public FlexlayoutControl WithJustifyContent(FlexJustify value)
        {
            JustifyContent = value;
            return this;
        }
    }
}