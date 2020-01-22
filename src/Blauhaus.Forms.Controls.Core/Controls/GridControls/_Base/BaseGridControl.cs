using Blauhaus.Forms.Controls.Core.Extensions;
using Xamarin.Forms;

namespace Blauhaus.Forms.Controls.Core.Controls.GridControls._Base
{
    public abstract class BaseGridControl<TControl> : Grid where TControl : BaseGridControl<TControl>
    {
        protected BaseGridControl()
        {
            this.WithHorizontalOptions(LayoutOptions.FillAndExpand);
            this.WithVerticalOptions(LayoutOptions.FillAndExpand);
        }

        public TControl WithSpacing(double rowspacing, double columnSpacing)
        {
            RowSpacing = rowspacing;
            ColumnSpacing = columnSpacing;
            return this as TControl;
        }

        public TControl WithRowDefinition(GridUnitType unitType, double height)
        {
            RowDefinitions.Add(new RowDefinition{Height = new GridLength(height, unitType)});
            return this as TControl;
        }
        
        public  TControl WithColumnDefinition(GridUnitType unitType, double width)
        {
            ColumnDefinitions.Add(new ColumnDefinition{Width= new GridLength(width, unitType)});
            return this as TControl;
        }

        public TControl WithGridItem(View item, int column, int row)
        {
            Children.Add(item, column, row);
            return this as TControl;
        }

    }
}