using Blauhaus.Forms.Controls.Core.Colours;
using Blauhaus.Forms.Controls.Core.Controls.ButtonControls.Base;

namespace Blauhaus.Forms.Controls.Core.Controls.ButtonControls
{
    public class SecondaryButtonControl : BaseMaterialButonControl<ButtonControl>
    {
        public SecondaryButtonControl(IMaterialPalette materialPalette) : base(materialPalette)
        {
            BackgroundColor = MaterialPalette.Secondary;
            TextColor = MaterialPalette.Primary;
        }
    }
}