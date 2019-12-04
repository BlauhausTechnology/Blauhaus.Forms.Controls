using System;
using System.Linq.Expressions;
using System.Windows.Input;
using Blauhaus.Common.Utils.Extensions;
using Prism.Commands;
using Xamarin.Forms;

namespace Blauhaus.Forms.Controls.Core.Controls.ButtonControls.Base
{
    public abstract class BaseButtonControl<TButtonControl> : Button where TButtonControl : BaseButtonControl<TButtonControl>
    {

        public TButtonControl BindCommand<TViewModel>(Expression<Func<TViewModel, ICommand>> viewModelProperty)
        {
            var propertyName = viewModelProperty.ToPropertyName();
            this.SetBinding(CommandProperty, propertyName);
            return this as TButtonControl;
        }

        public TButtonControl BindCommand(string viewModelPropertyName)
        {
            this.SetBinding(CommandProperty, viewModelPropertyName);
            return this as TButtonControl;
        }

        public TButtonControl BindVisibilityToCommandCanExecute(string viewModelPropertyName)
        {
            this.SetBinding(IsVisibleProperty, $"{viewModelPropertyName}.{nameof(DelegateCommand.CanExecute)}");
            return this as TButtonControl;
        }

        public TButtonControl WithLabel(string label)
        {
            Text = label.ToUpperInvariant();
            return this as TButtonControl;
        }

    }
}