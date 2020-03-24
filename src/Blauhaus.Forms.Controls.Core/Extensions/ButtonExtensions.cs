using Blauhaus.Forms.Controls.Core.Controls.LabelControls._Base;
using Xamarin.Forms;

namespace Blauhaus.Forms.Controls.Core.Extensions
{
    public static class ButtonExtensions
    {
        public static Button Font(this Button button, FontDefinition fontDefinition)
        {

            if (fontDefinition != null)
            {
                if (Device.RuntimePlatform == "UWP")
                {
                    var font = $"Assets/Fonts/{fontDefinition.FileName}.ttf#{fontDefinition.FontName}";
                    button.FontFamily = font;
                }

                else if (Device.RuntimePlatform == "Android")
                {
                    var font = $"{fontDefinition.FileName}.ttf#{fontDefinition.FileName}";
                    button.FontFamily = font;
                }

                else if (Device.RuntimePlatform == "iOS")
                {
                    button.FontFamily = fontDefinition.PostScriptName;
                }

            }
            return button;
        }
    }
}