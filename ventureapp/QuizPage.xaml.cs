﻿using System;
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
    /// Interaction logic for QuizPage.xaml
    /// </summary>
    public partial class QuizPage : Page
    {
        public QuizPage()
        {
            InitializeComponent();
        }

        private void Home_Button_Clicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MainPage.xaml", UriKind.Relative));
        }
    }
}
