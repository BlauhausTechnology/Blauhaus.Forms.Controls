using Blauhaus.Forms.Controls.Core.Colours;
using Blauhaus.Forms.Controls.Core.Controls.ActivityIndicatorControls._Base;

namespace Blauhaus.Forms.Controls.Core.Controls.ActivityIndicatorControls
{
    public class PrimaryActivityIndicatorControlControl : BaseMaterialActivityIndicatorControlControl<PrimaryActivityIndicatorControlControl>
    {
        public PrimaryActivityIndicatorControlControl(IMaterialPalette materialPalette) : base(materialPalette)
        {
            WithColor(MaterialPalette.Primary);
        }
    }
}