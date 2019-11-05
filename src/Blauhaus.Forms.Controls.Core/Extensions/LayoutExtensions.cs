using System;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using Xamarin.Forms;

namespace Blauhaus.Forms.Controls.Core.Extensions
{
    public static class LayoutExtensions
    {
        public static TControl WithItemTemplate<TControl>(this TControl control, DataTemplate dataTemplate) where TControl : Layout
        {
            BindableLayout.SetItemTemplate(control, dataTemplate);
            return control;
        }


        public static TControl BindItemsSource<TControl, TViewModel, T>(this TControl control, Expression<Func<TViewModel, ObservableCollection<T>>> viewModelProperty) where TControl : Layout
        {
            control.SetBinding(BindableLayout.ItemsSourceProperty, viewModelProperty.ToPropertyName());
            return control;
        }

        public static TControl BindItemsSource<TControl>(this TControl control, string viewModelPropertyName) where TControl : Layout
        {
            control.SetBinding(BindableLayout.ItemsSourceProperty, viewModelPropertyName);
            return control;
        }

    }
}