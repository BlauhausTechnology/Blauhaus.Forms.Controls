using Blauhaus.Forms.Controls.Core.Controls.LabelControls._Base;
using Xamarin.Forms;

namespace Blauhaus.Forms.Controls.Core.Extensions
{
    public static class EntryExtensions
    {
        public static Entry Font(this Entry entry, FontDefinition fontDefinition)
        {

            if (fontDefinition != null)
            {
                if (Device.RuntimePlatform == "UWP")
                {
                    var font = $"Assets/Fonts/{fontDefinition.FileName}.ttf#{fontDefinition.FontName}";
                    entry.FontFamily = font;
                }

                else if (Device.RuntimePlatform == "Android")
                {
                    var font = $"{fontDefinition.FileName}.ttf#{fontDefinition.FileName}";
                    entry.FontFamily = font;
                }

                else if (Device.RuntimePlatform == "iOS")
                {
                    entry.FontFamily = fontDefinition.PostScriptName;
                }

            }
            return entry;
        }
    }
}