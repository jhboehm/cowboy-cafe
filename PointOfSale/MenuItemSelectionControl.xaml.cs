using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;

namespace PointOfSale.CustomizationScreens
{
    /// <summary>
    /// Interaction logic for MenuItemSelection.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }
        public void OnAddOrderItemButtonClicked(object sender)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if(DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch (button.Tag) 
                    {
                        case "CowpokeChili":
                            var item = new CowpokeChili();
                            var screen = new CowpokeChiliCustimization();
                            order.Add(item);
                            orderControl.SwapScreen(new CowpokeChiliCustomization(item));
                            break;

                    }

                }
            }
        }
    }
}
