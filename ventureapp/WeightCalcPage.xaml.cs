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
    /// Interaction logic for WeigthCalcPage.xaml
    /// </summary>
    public partial class WeigthCalcPage : Page
    {
        public WeigthCalcPage()
        {
            InitializeComponent();
        }
        private void WeightCalcHome_Button_Clicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MainPage.xaml", UriKind.Relative));
        }

        private void WeightCalcReal_Button_Clicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("WeightCalcRealPage.xaml", UriKind.Relative));
        }

        private void WeightCalcInfo_Button_Clicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("WeightCalcInfoPage.xaml", UriKind.Relative));
        }
    }
}
