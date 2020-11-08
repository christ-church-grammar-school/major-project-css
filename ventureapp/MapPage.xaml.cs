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
using Microsoft.Maps.MapControl.WPF;

namespace ventureapp
{
    /// <summary>
    /// Interaction logic for MapPage.xaml
    /// </summary>

    public partial class MapPage : Page
    {
        //DISCLAIMER: Map routes are not 100% accurate and are based on the 2019 Venture Routes

        //Had to do it this way as list/dictionary wouldnt work with the map control for some reason 

        //latitude
        double lat1;
        double lat2;
        double lat3;
        double lat4;
        double lat5;
        double lat6;
        double lat7;
        double lat8;
        double lat9;
        double lat10;
        double lat11;

        //longitude
        double lon1;
        double lon2;
        double lon3;
        double lon4;
        double lon5;
        double lon6;
        double lon7;
        double lon8;
        double lon9;
        double lon10;
        double lon11;

        public MapPage()
        {
            InitializeComponent();

        }

        private void Home_Button_Clicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MainPage.xaml", UriKind.Relative));
        }

        private void selectGroupOne(object sender, RoutedEventArgs e)
        {
            double lat1 = -35.04561701;
            double lat2 = -35.0251870416;
            double lat3 = -34.995122;
            double lat4 = -34.90980847;
            double lat5 = -34.94438834;
            double lat6 = -34.9473262;
            double lat7 = -34.93350587;
            double lat8 = -34.878491;
            double lat9 = -34.856539;
            double lat10 = -34.72002785;
            double lat11 = -34.839546;

            double lon1 = 116.86047197;
            double lon2 = 116.8105040118;
            double lon3 = 116.652399;
            double lon4 = 116.62224326;
            double lon5 = 116.56595377;
            double lon6 = 116.48409594;
            double lon7 = 116.38294808;
            double lon8 = 116.31175999;
            double lon9 = 116.231534;
            double lon10 = 116.17334534;
            double lon11 = 116.021281;

            MapPolyline polyline = new MapPolyline();
            polyline.Stroke = new SolidColorBrush(Colors.Blue);
            polyline.StrokeThickness = 5;
            polyline.Opacity = 0.7;
            polyline.Locations = new LocationCollection() {
            new Location(lat1, lon1),
            new Location(lat2, lon2),
            new Location(lat3, lon3),
            new Location(lat4, lon4),
            new Location(lat5, lon5),
            new Location(lat6, lon6),
            new Location(lat7, lon7),
            new Location(lat8, lon8),
            new Location(lat9, lon9),
            new Location(lat10, lon10),
            new Location(lat11, lon11)};

            myMap.Children.Add(polyline);

        }

        private void selectGroupTwo(object sender, RoutedEventArgs e)
        {
            double lat1 = -35.04750998;
            double lat2 = -34.97418945;
            double lat3 = -34.969752;
            double lat4 = -35.01144231;
            double lat5 = -35.023998;
            double lat6 = -35.00417571;
            double lat7 = -34.94401359;
            double lat8 = -34.87034395;
            double lat9 = -34.76383762;
            double lat10 = -34.82967806;
            double lat11 = -34.78398604;

            double lon1 = 116.87899003;
            double lon2 = 116.9031911;
            double lon3 = 116.801495;
            double lon4 = 116.64429775;
            double lon5 = 116.571663;
            double lon6 = 116.50976376;
            double lon7 = 116.44405718;
            double lon8 = 116.37227607;
            double lon9 = 116.37762565;
            double lon10 = 116.1925907;
            double lon11 = 116.21805003;

            MapPolyline polyline = new MapPolyline();
            polyline.Stroke = new SolidColorBrush(Colors.Blue);
            polyline.StrokeThickness = 5;
            polyline.Opacity = 0.7;
            polyline.Locations = new LocationCollection() {
            new Location(lat1, lon1),
            new Location(lat2, lon2),
            new Location(lat3, lon3),
            new Location(lat4, lon4),
            new Location(lat5, lon5),
            new Location(lat6, lon6),
            new Location(lat7, lon7),
            new Location(lat8, lon8),
            new Location(lat9, lon9),
            new Location(lat10, lon10),
            new Location(lat11, lon11)};

            myMap.Children.Add(polyline);
        }

        private void selectGroupThree(object sender, RoutedEventArgs e)
        {
            double lat1 = -34.76383762;
            double lat2 = -34.856539;
            double lat3 = -34.90051587;
            double lat4 = -34.93678839;
            double lat5 = -35.00447276;
            double lat6 = -35.030016;
            double lat7 = -34.995122;
            double lat8 = -34.95018745;
            double lat9 = -34.97418945;
            double lat10 = -35.04750998;
            double lat11 = -35.040161;

            double lon1 = 116.37762565;
            double lon2 = 116.231534;
            double lon3 = 116.30374529;
            double lon4 = 116.4187616;
            double lon5 = 116.51203944;
            double lon6 = 116.574646;
            double lon7 = 116.652399;
            double lon8 = 116.81094222;
            double lon9 = 116.9031911;
            double lon10 = 116.87899003;
            double lon11 = 116.930422;

            MapPolyline polyline = new MapPolyline();
            polyline.Stroke = new SolidColorBrush(Colors.Blue);
            polyline.StrokeThickness = 5;
            polyline.Opacity = 0.7;
            polyline.Locations = new LocationCollection() {
            new Location(lat1, lon1),
            new Location(lat2, lon2),
            new Location(lat3, lon3),
            new Location(lat4, lon4),
            new Location(lat5, lon5),
            new Location(lat6, lon6),
            new Location(lat7, lon7),
            new Location(lat8, lon8),
            new Location(lat9, lon9),
            new Location(lat10, lon10),
            new Location(lat11, lon11)};

            myMap.Children.Add(polyline);
        }

        private void selectGroupFour(object sender, RoutedEventArgs e)
        {
            double lat1 = -34.82967806;
            double lat2 = -34.76383762;
            double lat3 = -34.83271935;
            double lat4 = -34.94438834;
            double lat5 = -34.98033472;
            double lat6 = -35.00447276;
            double lat7 = -35.030016;
            double lat8 = -34.995122;
            double lat9 = -34.95018745;
            double lat10 = -34.97418945;
            double lat11 = -34.99223253;

            double lon1 = 116.1925907;
            double lon2 = 116.37762565;
            double lon3 = 116.51377693;
            double lon4 = 116.56595377;
            double lon5 = 116.5251935;
            double lon6 = 116.51203944;
            double lon7 = 116.574646;
            double lon8 = 116.652399;
            double lon9 = 116.81094222;
            double lon10 = 116.9031911;
            double lon11 = 116.89080104;

            MapPolyline polyline = new MapPolyline();
            polyline.Stroke = new SolidColorBrush(Colors.Blue);
            polyline.StrokeThickness = 5;
            polyline.Opacity = 0.7;
            polyline.Locations = new LocationCollection() {
            new Location(lat1, lon1),
            new Location(lat2, lon2),
            new Location(lat3, lon3),
            new Location(lat4, lon4),
            new Location(lat5, lon5),
            new Location(lat6, lon6),
            new Location(lat7, lon7),
            new Location(lat8, lon8),
            new Location(lat9, lon9),
            new Location(lat10, lon10),
            new Location(lat11, lon11)};

            myMap.Children.Add(polyline);
        }

        private void selectGroupFive(object sender, RoutedEventArgs e)
        {
            double lat1 = -34.9998158;
            double lat2 = -35.03882088;
            double lat3 = -35.033431;
            double lat4 = -35.04750998;
            double lat5 = -34.97418945;
            double lat6 = -34.95018745;
            double lat7 = -35.01144231;
            double lat8 = -35.023998;
            double lat9 = -35.00417571;
            double lat10 = -34.94401359;
            double lat11 = -34.91574202;

            double lon1 = 117.208564;
            double lon2 = 117.16019777;
            double lon3 = 117.067981;
            double lon4 = 116.87899003;
            double lon5 = 116.9031911;
            double lon6 = 116.81094222;
            double lon7 = -35.01144231;
            double lon8 = -35.023998;
            double lon9 = 116.64429775;
            double lon10 = 116.44405718;
            double lon11 = 116.62224326;

            MapPolyline polyline = new MapPolyline();
            polyline.Stroke = new SolidColorBrush(Colors.Blue);
            polyline.StrokeThickness = 5;
            polyline.Opacity = 0.7;
            polyline.Locations = new LocationCollection() {
            new Location(lat1, lon1),
            new Location(lat2, lon2),
            new Location(lat3, lon3),
            new Location(lat4, lon4),
            new Location(lat5, lon5),
            new Location(lat6, lon6),
            new Location(lat7, lon7),
            new Location(lat8, lon8),
            new Location(lat9, lon9),
            new Location(lat10, lon10),
            new Location(lat11, lon11)};

            myMap.Children.Add(polyline);
        }

        private void selectGroupSix(object sender, RoutedEventArgs e)
        {
            double lat1 = -34.97418945;
            double lat2 = -34.969752;
            double lat3 = -35.01144231;
            double lat4 = -35.023998;
            double lat5 = -35.00417571;
            double lat6 = -34.94401359;
            double lat7 = -34.87034395;
            double lat8 = -34.76383762;
            double lat9 = -34.82967806;
            double lat10 = -34.72002785;
            double lat11 = -34.78398604;

            double lon1 = 116.9031911;
            double lon2 = -34.969752;
            double lon3 = 116.64429775;
            double lon4 = 116.571663;
            double lon5 = 116.50976376;
            double lon6 = 116.44405718;
            double lon7 = 116.37227607;
            double lon8 = 116.37762565;
            double lon9 = 116.1925907;
            double lon10 = 116.17334534;
            double lon11 = 116.21805003;

            MapPolyline polyline = new MapPolyline();
            polyline.Stroke = new SolidColorBrush(Colors.Blue);
            polyline.StrokeThickness = 5;
            polyline.Opacity = 0.7;
            polyline.Locations = new LocationCollection() {
            new Location(lat1, lon1),
            new Location(lat2, lon2),
            new Location(lat3, lon3),
            new Location(lat4, lon4),
            new Location(lat5, lon5),
            new Location(lat6, lon6),
            new Location(lat7, lon7),
            new Location(lat8, lon8),
            new Location(lat9, lon9),
            new Location(lat10, lon10),
            new Location(lat11, lon11)};

            myMap.Children.Add(polyline);
        }

        private void selectGroupSeven(object sender, RoutedEventArgs e)
        {
            double lat1 = -34.49983265;
            double lat2 = -34.55931131;
            double lat3 = -34.66401989;
            double lat4 = -34.97418945;
            double lat5 = -34.82967806;
            double lat6 = -34.90051587;
            double lat7 = -34.93678839;
            double lat8 = -35.00447276;
            double lat9 = -35.023998;
            double lat10 = -34.995122;
            double lat11 = -34.98732003;

            double lon1 = -34.49983265;
            double lon2 = -34.55931131;
            double lon3 = -34.66401989;
            double lon4 = -34.72002785;
            double lon5 = -34.82967806;
            double lon6 = -34.90051587;
            double lon7 = -34.93678839;
            double lon8 = -35.00447276;
            double lon9 = -35.023998;
            double lon10 = -34.995122;
            double lon11 = -34.98732003;

            MapPolyline polyline = new MapPolyline();
            polyline.Stroke = new SolidColorBrush(Colors.Blue);
            polyline.StrokeThickness = 5;
            polyline.Opacity = 0.7;
            polyline.Locations = new LocationCollection() {
            new Location(lat1, lon1),
            new Location(lat2, lon2),
            new Location(lat3, lon3),
            new Location(lat4, lon4),
            new Location(lat5, lon5),
            new Location(lat6, lon6),
            new Location(lat7, lon7),
            new Location(lat8, lon8),
            new Location(lat9, lon9),
            new Location(lat10, lon10),
            new Location(lat11, lon11)};

            myMap.Children.Add(polyline);
        }

        private void selectGroupEight(object sender, RoutedEventArgs e)
        {
            double lat1 = -34.995122;
            double lat2 = -35.023998;
            double lat3 = -35.00417571;
            double lat4 = -34.94401359;
            double lat5 = -34.87034395;
            double lat6 = -34.76383762;
            double lat7 = -34.82967806;
            double lat8 = -34.72002785;
            double lat9 = -34.66401989;
            double lat10 = -34.55931131;
            double lat11 = -34.51197522;

            double lon1 = 116.652399;
            double lon2 = 116.571663;
            double lon3 = 116.50976376;
            double lon4 = 116.44405718;
            double lon5 = 116.37227607;
            double lon6 = 116.37762565;
            double lon7 = 116.1925907;
            double lon8 = 116.17334534;
            double lon9 = 116.11854781;
            double lon10 = 116.17455137;
            double lon11 = 116.16417149;

            MapPolyline polyline = new MapPolyline();
            polyline.Stroke = new SolidColorBrush(Colors.Blue);
            polyline.StrokeThickness = 5;
            polyline.Opacity = 0.7;
            polyline.Locations = new LocationCollection() {
            new Location(lat1, lon1),
            new Location(lat2, lon2),
            new Location(lat3, lon3),
            new Location(lat4, lon4),
            new Location(lat5, lon5),
            new Location(lat6, lon6),
            new Location(lat7, lon7),
            new Location(lat8, lon8),
            new Location(lat9, lon9),
            new Location(lat10, lon10),
            new Location(lat11, lon11)};

            myMap.Children.Add(polyline);
        }

        private void selectGroupNine(object sender, RoutedEventArgs e)
        {
            double lat1 = -35.033431;
            double lat2 = -35.04750998;
            double lat3 = -34.97418945;
            double lat4 = -34.95018745;
            double lat5 = -35.01144231;
            double lat6 = -35.023998;
            double lat7 = -35.00417571;
            double lat8 = -34.94401359;
            double lat9 = -34.87034395;
            double lat10 = -34.76383762;
            double lat11 = -34.76513387;

            double lon1 = 117.067981;
            double lon2 = 116.87899003;
            double lon3 = 116.9031911;
            double lon4 = 116.81094222;
            double lon5 = 116.64429775;
            double lon6 = 116.571663;
            double lon7 = 116.50976376;
            double lon8 = 116.44405718;
            double lon9 = 116.37227607;
            double lon10 = 116.37762565;
            double lon11 = 116.32294702;

            MapPolyline polyline = new MapPolyline();
            polyline.Stroke = new SolidColorBrush(Colors.Blue);
            polyline.StrokeThickness = 5;
            polyline.Opacity = 0.7;
            polyline.Locations = new LocationCollection() {
            new Location(lat1, lon1),
            new Location(lat2, lon2),
            new Location(lat3, lon3),
            new Location(lat4, lon4),
            new Location(lat5, lon5),
            new Location(lat6, lon6),
            new Location(lat7, lon7),
            new Location(lat8, lon8),
            new Location(lat9, lon9),
            new Location(lat10, lon10),
            new Location(lat11, lon11)};

            myMap.Children.Add(polyline);
        }

        private void selectGroupTen(object sender, RoutedEventArgs e)
        {
            double lat1 = -34.84135003;
            double lat2 = -34.878491;
            double lat3 = -34.93678839;
            double lat4 = -35.00447276;
            double lat5 = -34.995122;
            double lat6 = -35.0251870416;
            double lat7 = -35.02210074;
            double lat8 = -35.04750998;
            double lat9 = -35.033431;
            double lat10 = -35.033431;
            
            double lon1 = 116.11995002;
            double lon2 = 116.31175999;
            double lon3 = 116.4187616;
            double lon4 = 116.51203944;
            double lon5 = 116.652399;
            double lon6 = 116.8105040118;
            double lon7 = 116.81942789;
            double lon8 = 116.87899003;
            double lon9 = 117.067981;
            double lon10 = 117.101798;
            
            MapPolyline polyline = new MapPolyline();
            polyline.Stroke = new SolidColorBrush(Colors.Blue);
            polyline.StrokeThickness = 5;
            polyline.Opacity = 0.7;
            polyline.Locations = new LocationCollection() {
            new Location(lat1, lon1),
            new Location(lat2, lon2),
            new Location(lat3, lon3),
            new Location(lat4, lon4),
            new Location(lat5, lon5),
            new Location(lat6, lon6),
            new Location(lat7, lon7),
            new Location(lat8, lon8),
            new Location(lat9, lon9),
            new Location(lat10, lon10)};

            myMap.Children.Add(polyline);
        }

        private void selectGroupEleven(object sender, RoutedEventArgs e)
        {
            double lat1 = -34.856539;
            double lat2 = -34.90051587;
            double lat3 = -34.8249218;
            double lat4 = -34.98033472;
            double lat5 = -35.030016;
            double lat6 = -34.995122;
            double lat7 = -34.95018745;
            double lat8 = -34.97418945;
            double lat9 = -35.04750998;
            double lat10 = -35.033431;
            double lat11 = -35.004176;

            double lon1 = 116.231534;
            double lon2 = 116.30374529;
            double lon3 = 116.00766403;
            double lon4 = 116.5251935;
            double lon5 = 116.574646;
            double lon6 = 116.6523996;
            double lon7 = 116.81094222;
            double lon8 = 116.9031911;
            double lon9 = 116.87899003;
            double lon10 = 117.067981;
            double lon11 = 117.101798;

            MapPolyline polyline = new MapPolyline();
            polyline.Stroke = new SolidColorBrush(Colors.Blue);
            polyline.StrokeThickness = 5;
            polyline.Opacity = 0.7;
            polyline.Locations = new LocationCollection() {
            new Location(lat1, lon1),
            new Location(lat2, lon2),
            new Location(lat3, lon3),
            new Location(lat4, lon4),
            new Location(lat5, lon5),
            new Location(lat6, lon6),
            new Location(lat7, lon7),
            new Location(lat8, lon8),
            new Location(lat9, lon9),
            new Location(lat10, lon10),
            new Location(lat11, lon11)};

            myMap.Children.Add(polyline);
        }

        private void selectGroup12(object sender, RoutedEventArgs e)
        {
            double lat1 = -34.969752;
            double lat2 = -35.01144231;
            double lat3 = -35.023998;
            double lat4 = -35.00417571;
            double lat5 = -34.94401359;
            double lat6 = -34.87034395;
            double lat7 = -34.76383762;
            double lat8 = -34.82967806;
            double lat9 = -34.84135003;
            double lat10 = -34.66401989;
            double lat11 = -34.6330667;

            double lon1 = 116.801495;
            double lon2 = 116.64429775;
            double lon3 = 116.574646;
            double lon4 = 116.50976376;
            double lon5 = 116.44405718;
            double lon6 = 116.37227607;
            double lon7 = 116.37762565;
            double lon8 = 116.1925907;
            double lon9 = 116.17334534;
            double lon10 = 116.11854781;
            double lon11 = 116.12740989;

            MapPolyline polyline = new MapPolyline();
            polyline.Stroke = new SolidColorBrush(Colors.Blue);
            polyline.StrokeThickness = 5;
            polyline.Opacity = 0.7;
            polyline.Locations = new LocationCollection() {
            new Location(lat1, lon1),
            new Location(lat2, lon2),
            new Location(lat3, lon3),
            new Location(lat4, lon4),
            new Location(lat5, lon5),
            new Location(lat6, lon6),
            new Location(lat7, lon7),
            new Location(lat8, lon8),
            new Location(lat9, lon9),
            new Location(lat10, lon10),
            new Location(lat11, lon11)};

            myMap.Children.Add(polyline);
        }
    }
}

/*
double lat1;
double lat2;
double lat3;
double lat4;
double lat5;
double lat6;
double lat7;
double lat8;
double lat9;
double lat10;
double lat11;

double lon1;
double lon2;
double lon3;
double lon4;
double lon5;
double lon6;
double lon7;
double lon8;
double lon9;
double lon10;
double lon11;
*/

