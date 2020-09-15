using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ventureapp
{
    /// <summary>
    /// Interaction logic for WeightCalcRealPage.xaml
    /// </summary>
    public partial class WeightCalcRealPage : Page
    {
        public WeightCalcRealPage()
        {
            InitializeComponent();

            Dictionary<string, string> items = new Dictionary<string, string>();

            items.Add("Sleeping Bag", "sb");
            items.Add("Sleeping Mat", "sm");
            items.Add("Ground Sheet", "gs");
            items.Add("Torch", "t");
            items.Add("Water Bottle(s)", "wb");
            items.Add("Shirts", "s");
            items.Add("Shorts/Pants", "s/p");
            items.Add("Jackets/Jumpers", "j/j");
            items.Add("Hootchie", "h");
            items.Add("Contraband", "c");
            KeyValuePair<string, string> pair;
        }
        private void WeightCalcBack_Button_Clicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("WeightCalcPage.xaml", UriKind.Relative));
        }

        private void WeightCalcHome_Button_Clicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MainPage.xaml", UriKind.Relative));
        }
    }
}
