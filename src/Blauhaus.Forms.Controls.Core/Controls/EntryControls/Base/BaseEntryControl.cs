using System;
using System.Linq.Expressions;
using Blauhaus.Common.Utils.Extensions;
using Blauhaus.Forms.Controls.Core.Extensions;
using Xamarin.Forms;

namespace Blauhaus.Forms.Controls.Core.Controls.EntryControls.Base
{
    public abstract class BaseEntryControl<TEntryControl> : Entry where TEntryControl : BaseEntryControl<TEntryControl>
    {
        protected BaseEntryControl()
        {
            IsTextPredictionEnabled = false;
            IsSpellCheckEnabled = false;
        }

        public TEntryControl WithPlaceholder(string placeholder)
        {
            Placeholder = placeholder;
            return this as TEntryControl;
        }
        
        public TEntryControl WithKeyboard(Keyboard keyboard)
        {
            Keyboard = keyboard;
            return this as TEntryControl;
        }
        public TEntryControl WithIsPassword(bool isPassword)
        {
            IsPassword = isPassword;
            return this as TEntryControl;
        }
        
        public TEntryControl BindText<TViewModel>(Expression<Func<TViewModel, string>> viewModelProperty)
        {
            this.SetBinding(TextProperty, viewModelProperty.ToPropertyName());
            return this as TEntryControl;
        }

        public TEntryControl BindText(string viewModelPropertyName)
        {
            this.SetBinding(TextProperty, viewModelPropertyName);
            return this as TEntryControl;
        }
    }
}