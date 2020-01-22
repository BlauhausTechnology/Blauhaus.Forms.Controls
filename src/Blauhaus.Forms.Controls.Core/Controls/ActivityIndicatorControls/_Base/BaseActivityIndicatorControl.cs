using System;
using System.Linq.Expressions;
using Blauhaus.Common.Utils.Extensions;
using Blauhaus.Forms.Controls.Core.Colours;
using Xamarin.Forms;

namespace Blauhaus.Forms.Controls.Core.Controls.ActivityIndicatorControls._Base
{



    public abstract class BaseActivityIndicatorControl<TActivityIndicator> : ActivityIndicator where TActivityIndicator : BaseActivityIndicatorControl<TActivityIndicator>
    {

        public TActivityIndicator BindIsRunning<TViewModel>(Expression<Func<TViewModel, bool>> viewModelProperty)
        {
            this.SetBinding(IsRunningProperty, viewModelProperty.ToPropertyName());
            return this as TActivityIndicator;
        }

        public TActivityIndicator BindIsRunning(string viewModelPropertyName)
        {
            this.SetBinding(IsRunningProperty, viewModelPropertyName);
            return this as TActivityIndicator;
        }

        public TActivityIndicator WithColor(Color color)
        {
            this.Color = color;
            return this as TActivityIndicator;
        }
    }
}