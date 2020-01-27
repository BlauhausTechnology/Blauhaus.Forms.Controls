using Blauhaus.Forms.Controls.Core.Colours;

namespace Blauhaus.Forms.Controls.Core.Controls.FrameControls._Base
{
    public abstract class BaseMaterialFrameControl<TControl> : BaseFrameControl<TControl> where TControl : BaseMaterialFrameControl<TControl>
    {
        protected readonly IMaterialPalette MaterialPalette;

        protected BaseMaterialFrameControl(IMaterialPalette materialPalette)
        {
            MaterialPalette = materialPalette;
        }
    }
}