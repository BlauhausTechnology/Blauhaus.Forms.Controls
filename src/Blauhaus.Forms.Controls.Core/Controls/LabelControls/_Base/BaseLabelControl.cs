using System;
using System.Linq.Expressions;
using Blauhaus.Common.Utils.Extensions;
using Blauhaus.Forms.Controls.Core.Extensions;
using Xamarin.Forms;

namespace Blauhaus.Forms.Controls.Core.Controls.LabelControls._Base
{
    public abstract class BaseLabelControl<TControl> : Label where TControl : BaseLabelControl<TControl>
    {
        
        protected TapGestureRecognizer TapGestureRecognizer;

        public TControl WithText(string text)
        {
            Text = text;
            return this as TControl;
        }

        public TControl WithFontSize(double size)
        {
            FontSize = size;
            return this as TControl;
        }
        public TControl WithTextColor(Color color)
        {
            TextColor = color;
            return this as TControl;
        }
        
        public TControl WithLineBreakMode(LineBreakMode value)
        {
            LineBreakMode = value;
            return this as TControl;
        }

        public TControl BindTapCommand(string viewModelPropertyName)
        {
            TapGestureRecognizer =  new TapGestureRecognizer();
            TapGestureRecognizer.SetBinding(TapGestureRecognizer.CommandProperty, viewModelPropertyName);
            GestureRecognizers.Add(TapGestureRecognizer);
            return this as TControl;
        }

        public TControl WithHorizontalTextAlignment(TextAlignment alignment)
        {
            HorizontalTextAlignment = alignment;
            return this as TControl;
        }

        public TControl WithVerticalTextAlignment(TextAlignment alignment)
        {
            VerticalTextAlignment = alignment;
            return this as TControl;
        }
        
        
        public TControl BindText<TViewModel>(Expression<Func<TViewModel, string>> viewModelProperty)
        {
            this.SetBinding(TextProperty, viewModelProperty.ToPropertyName());
            return this as TControl;
        }

        public TControl BindText(string viewModelPropertyName)
        {
            this.SetBinding(TextProperty, viewModelPropertyName);
            return this as TControl;
        }        
        
        public TControl WithFont(FontDefinition fontDefinition)
        {

            if (fontDefinition != null)
            {
                if (Device.RuntimePlatform == "UWP")
                {
                    var font = $"Assets/Fonts/{fontDefinition.FileName}.ttf#{fontDefinition.FontName}";
                    FontFamily = font;
                }

                else if (Device.RuntimePlatform == "Android")
                {
                    var font = $"{fontDefinition.FileName}.ttf#{fontDefinition.FileName}";
                    FontFamily = font;
                }

                else if (Device.RuntimePlatform == "iOS")
                {
                    FontFamily = fontDefinition.PostScriptName;
                }

            }

            return this as TControl;
        }
        
    }
}