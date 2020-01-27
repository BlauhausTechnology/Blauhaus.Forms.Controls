using Blauhaus.Forms.Controls.Core.Colours;
using Blauhaus.Forms.Controls.Core.Controls.ButtonControls.Base;

namespace Blauhaus.Forms.Controls.Core.Controls.ButtonControls
{
    public class PrimaryButtonControl : BaseMaterialButonControl<ButtonControl>
    {
        public PrimaryButtonControl(IMaterialPalette materialPalette) : base(materialPalette)
        {
            BackgroundColor = MaterialPalette.Primary;
            TextColor = MaterialPalette.PrimaryText;
        }
    }
}