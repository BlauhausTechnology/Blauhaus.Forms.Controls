using Blauhaus.Forms.Controls.Core.Controls.LabelControls._Base;
using Xamarin.Forms;

namespace Blauhaus.Forms.Controls.Core.Extensions
{
    public static class LabelExtensions
    {
        public static Label Font(this Label label, FontDefinition fontDefinition)
        {

            if (fontDefinition != null)
            {
                if (Device.RuntimePlatform == "UWP")
                {
                    var font = $"Assets/Fonts/{fontDefinition.FileName}.ttf#{fontDefinition.FontName}";
                    label.FontFamily = font;
                }

                else if (Device.RuntimePlatform == "Android")
                {
                    var font = $"{fontDefinition.FileName}.ttf#{fontDefinition.FileName}";
                    label.FontFamily = font;
                }

                else if (Device.RuntimePlatform == "iOS")
                {
                    label.FontFamily = fontDefinition.PostScriptName;
                }

            }
            return label;
        }
    }
}