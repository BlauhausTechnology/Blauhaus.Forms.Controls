namespace Blauhaus.Forms.Controls.Core.Controls.LabelControls._Base
{
    public class FontDefinition
    {
        public FontDefinition(string fileName, string fontName, string postScriptName = "")
        {
            FileName = fileName;
            FontName = fontName;
            PostScriptName = string.IsNullOrEmpty(postScriptName) ? fileName : postScriptName;
        }

        /// <summary>
        /// Name of the .ttf file (without the extension)
        /// File must be in:
        /// - Assets/Fonts/ on UWP with build action of Content
        /// - Assets on Android with a build action of AndroidAsset
        /// - Resources on iOS and must be registered in Info.plist as <key>UIAppFonts</key><array><string>{FileName}.ttf</string></array>
        /// </summary>
        public string FileName { get; }

        /// <summary>
        /// Open the font in windows and get the "Font name:" property
        /// </summary>
        public string FontName { get; }


        /// <summary>
        /// Install font on mac, open in Font Book, click I and get PostScript name
        /// Mostly this is the same as FileName but not always!
        /// </summary>
        public string PostScriptName { get; }
    }
}