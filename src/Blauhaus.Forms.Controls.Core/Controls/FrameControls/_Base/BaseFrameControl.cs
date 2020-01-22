using Blauhaus.Forms.Controls.Core.Colours;
using Blauhaus.Ioc.Abstractions;
using Xamarin.Forms;

namespace Blauhaus.Forms.Controls.Core.Controls.FrameControls._Base
{
    public abstract class BaseFrameControl<TFrameControl> : Frame where TFrameControl : BaseFrameControl<TFrameControl>
    {

        public TFrameControl WithContent(View content)
        {
            Content = content;
            return this as TFrameControl;
        }

        public TFrameControl WithCornerRadius(float radius)
        {
            CornerRadius = radius;
            return this as TFrameControl;
        }
        public TFrameControl WithBackgroundColor(Color value)
        {
            BackgroundColor = value;
            return this as TFrameControl;
        }

        public TFrameControl WithHasShadow(bool value)
        {
            HasShadow = value;
            return this as TFrameControl;
        }
        
        public TFrameControl WithPadding(float value)
        {
            Padding = value;
            return this as TFrameControl;
        }

        public TFrameControl WithPadding(Thickness value)
        {
            Padding = value;
            return this as TFrameControl;
        }
    }
}