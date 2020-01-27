using System;
using Xamarin.Forms;

namespace Blauhaus.Forms.Controls.Core.Controls.CollectionViewControls._Base
{
    public abstract class BaseCollectionViewControl<TControl> : CollectionView where TControl : BaseCollectionViewControl<TControl>
    {
        public TControl WithEmptyView(View view)
        {
            EmptyView = view;
            return this as TControl;
        }
        
        public TControl WithHeaderView(View view)
        {
            Header = view;
            return this as TControl;
        }
        public TControl WithFooterView(View view)
        {
            Footer = view;
            return this as TControl;
        }

        public TControl WithSelectionMode(SelectionMode value)
        {
            SelectionMode = value;
            return this as TControl;
        }
        public TControl WithItemTemplate(DataTemplate value)
        {
            ItemTemplate = value;
            return this as TControl;
        }

        public TControl WithItemTemplate(Func<object> value)
        {
            ItemTemplate = new DataTemplate(value);
            return this as TControl;
        }
        
        public TControl WithItemSizingStrategy(ItemSizingStrategy value)
        {
            ItemSizingStrategy = value;
            return this as TControl;
        }
        
        public TControl BindItemsSource(string viewModelPropertyName)
        {
            SetBinding(ItemsSourceProperty, new Binding(viewModelPropertyName, BindingMode.OneWay));
            return this as TControl;
        }


        public TControl BindSelectedItem(string viewModelPropertyName)
        {
            SetBinding(SelectedItemProperty, new Binding(viewModelPropertyName, BindingMode.TwoWay));
            return this as TControl;
        }

        public TControl BindSelectedItems(string viewModelPropertyName)
        {
            SetBinding(SelectedItemsProperty, new Binding(viewModelPropertyName, BindingMode.TwoWay));
            return this as TControl;
        }
    }
}