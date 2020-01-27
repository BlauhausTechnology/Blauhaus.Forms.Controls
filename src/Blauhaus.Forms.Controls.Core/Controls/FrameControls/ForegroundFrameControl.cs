using Blauhaus.Forms.Controls.Core.Colours;
using Blauhaus.Forms.Controls.Core.Controls.FrameControls._Base;

namespace Blauhaus.Forms.Controls.Core.Controls.FrameControls
{
    public class ForegroundFrameControl : BaseMaterialFrameControl<ForegroundFrameControl>
    {
        public ForegroundFrameControl(IMaterialPalette materialPalette) : base(materialPalette)
        {
            WithBackgroundColor(MaterialPalette.AppForeground);
            WithHasShadow(false);
            
        }
    }
}