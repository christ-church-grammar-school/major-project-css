using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;


namespace ventureapp
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            DateTime daysLeft = DateTime.Parse("9/8/2021 12:00:01 AM");
            DateTime startDate = DateTime.Now;
            TimeSpan t = daysLeft - startDate;
            string countDown = string.Format("{0} Days, {1} Hours, {2} Minutes, {3} Seconds.", t.Days, t.Hours, t.Minutes, t.Seconds);
            timer.Text = countDown;
        }

        private void Map_Button_Clicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MapPage.xaml", UriKind.Relative));
        }

        private void Food_Button_Clicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("FoodPage.xaml", UriKind.Relative));
        }

        private void FirstAid_Button_Clicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("FirstAidPage.xaml", UriKind.Relative));
        }

        private void Calc_Button_Clicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("WeightCalcPage.xaml", UriKind.Relative));
        }

        private void Quiz_Button_Clicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("QuizPage.xaml", UriKind.Relative));
        }
    }
}
