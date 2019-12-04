using System;
using System.Linq.Expressions;
using System.Windows.Input;
using Prism.Commands;
using Reveye.Client.Extensions;
using Reveye.Client.Services.Config;
using Reveye.Client.Services.Config.AppColours;
using Xamarin.Forms;

namespace Reveye.Client.Controls.ButtonControls.Base
{
    public abstract class BaseButtonControl<TButtonControl> : Button where TButtonControl : BaseButtonControl<TButtonControl>
    {
        protected IAppColours AppColours;

        protected BaseButtonControl(IAppConfigService appConfigService)
        {
            AppColours = appConfigService.AppColours;
        }

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