using Blauhaus.Forms.Controls.Core.Colours;

namespace Blauhaus.Forms.Controls.Core.Controls.ButtonControls.Base
{
    public class BaseMaterialButonControl<TControl> : BaseButtonControl<TControl> where TControl : BaseButtonControl<TControl>
    {
        protected readonly IMaterialPalette MaterialPalette;

        public BaseMaterialButonControl(IMaterialPalette materialPalette)
        {
            MaterialPalette = materialPalette;
        }
    }
}