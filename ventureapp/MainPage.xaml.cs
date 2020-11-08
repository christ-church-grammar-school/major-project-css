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
using System.Windows.Threading;
using System.ComponentModel;
using CefSharp.Wpf;
using CefSharp;
using System.Reflection;
using System.IO;

namespace ventureapp
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private readonly BackgroundWorker worker = new BackgroundWorker();

        public MainPage()
        {
            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.ProgressChanged += Worker_ProgressChanged;
            worker.WorkerReportsProgress = true;
            InitializeComponent();
            worker.RunWorkerAsync();
        }

        static string ConvertSectoDay(int n)
        {
            int day = n / (24 * 3600);
            n %= 24 * 3600;
            int hour = n / 3600;
            n %= 3600;
            int minutes = n / 60;
            n %= 60;
            int seconds = n;
            return (day + ":" + hour + ":" + minutes + ":" + seconds);
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            timer.Text = ConvertSectoDay(e.ProgressPercentage);
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            DateTime daysLeft = DateTime.Parse("17/11/2020 07:00:00 AM");
            int i = 1;
            while (i > 0)
            {
                DateTime startDate = DateTime.Now;
                TimeSpan t = daysLeft - startDate;
                string countDown = string.Format("{0} Days, {1} Hours, {2} Minutes, {3} Seconds.", t.Days, t.Hours, t.Minutes, t.Seconds);
                e.Result = countDown;
                worker.ReportProgress((int)t.TotalSeconds);
                Thread.Sleep(1000);
            }
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timer.Text = e.Result.ToString();
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
