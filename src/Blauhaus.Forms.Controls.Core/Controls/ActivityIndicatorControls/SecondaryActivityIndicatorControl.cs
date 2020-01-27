using Blauhaus.Forms.Controls.Core.Colours;
using Blauhaus.Forms.Controls.Core.Controls.ActivityIndicatorControls._Base;

namespace Blauhaus.Forms.Controls.Core.Controls.ActivityIndicatorControls
{
    public class SecondaryActivityIndicatorControl : BaseMaterialActivityIndicatorControlControl<SecondaryActivityIndicatorControl>
    {
        public SecondaryActivityIndicatorControl(IMaterialPalette materialPalette) : base(materialPalette)
        {
            WithColor(MaterialPalette.Secondary);
        }
    }
}