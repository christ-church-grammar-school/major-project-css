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

            items.Add("Sleeping Bag", "10kg");
            items.Add("Sleeping Mat", "20kg");
            items.Add("Ground Sheet", "30kg");
            items.Add("Torch", "40kg");
            items.Add("Water Bottle(s)", "50kg");
            items.Add("Shirts", "60kg");
            items.Add("Shorts/Pants", "70kg");
            items.Add("Jackets/Jumpers", "80kg");
            items.Add("Hootchie", "90kg");
            items.Add("Contraband", "100kg");
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
