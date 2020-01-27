using Blauhaus.Forms.Controls.Core.Colours;

namespace Blauhaus.Forms.Controls.Core.Controls.ActivityIndicatorControls._Base
{
    public abstract class BaseMaterialActivityIndicatorControlControl<TActivityIndicator> : BaseActivityIndicatorControl<TActivityIndicator> where TActivityIndicator : BaseActivityIndicatorControl<TActivityIndicator>
    {
        protected readonly IMaterialPalette MaterialPalette;

        protected BaseMaterialActivityIndicatorControlControl(IMaterialPalette materialPalette)
        {
            MaterialPalette = materialPalette;
        }
    }

}