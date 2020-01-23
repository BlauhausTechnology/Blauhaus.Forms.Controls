using Blauhaus.Forms.Controls.Core.Colours;
using Blauhaus.Forms.Controls.Core.Controls.ActivityIndicatorControls._Base;

namespace Blauhaus.Forms.Controls.Core.Controls.ActivityIndicatorControls
{
    public class PrimaryActivityIndicatorControl : BaseMaterialActivityIndicatorControlControl<PrimaryActivityIndicatorControl>
    {
        public PrimaryActivityIndicatorControl(IMaterialPalette materialPalette) : base(materialPalette)
        {
            WithColor(MaterialPalette.Primary);
        }
    }
}