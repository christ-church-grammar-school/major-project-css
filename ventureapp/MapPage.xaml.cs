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
             lat1 = -35.04561701;
             lat2 = -35.0251870416;
             lat3 = -34.995122;
             lat4 = -34.90980847;
             lat5 = -34.94438834;
             lat6 = -34.9473262;
             lat7 = -34.93350587;
             lat8 = -34.878491;
             lat9 = -34.856539;
             lat10 = -34.72002785;
             lat11 = -34.839546;

             lon1 = 116.86047197;
             lon2 = 116.8105040118;
             lon3 = 116.652399;
             lon4 = 116.62224326;
             lon5 = 116.56595377;
             lon6 = 116.48409594;
             lon7 = 116.38294808;
             lon8 = 116.31175999;
             lon9 = 116.231534;
             lon10 = 116.17334534;
             lon11 = 116.021281;

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
             lat1 = -35.04750998;
             lat2 = -34.97418945;
             lat3 = -34.969752;
             lat4 = -35.01144231;
             lat5 = -35.023998;
             lat6 = -35.00417571;
             lat7 = -34.94401359;
             lat8 = -34.87034395;
             lat9 = -34.76383762;
             lat10 = -34.82967806;
             lat11 = -34.78398604;

             lon1 = 116.87899003;
             lon2 = 116.9031911;
             lon3 = 116.801495;
             lon4 = 116.64429775;
             lon5 = 116.571663;
             lon6 = 116.50976376;
             lon7 = 116.44405718;
             lon8 = 116.37227607;
             lon9 = 116.37762565;
             lon10 = 116.1925907;
             lon11 = 116.21805003;

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
             lat1 = -34.76383762;
             lat2 = -34.856539;
             lat3 = -34.90051587;
             lat4 = -34.93678839;
             lat5 = -35.00447276;
             lat6 = -35.030016;
             lat7 = -34.995122;
             lat8 = -34.95018745;
             lat9 = -34.97418945;
             lat10 = -35.04750998;
             lat11 = -35.040161;

             lon1 = 116.37762565;
             lon2 = 116.231534;
             lon3 = 116.30374529;
             lon4 = 116.4187616;
             lon5 = 116.51203944;
             lon6 = 116.574646;
             lon7 = 116.652399;
             lon8 = 116.81094222;
             lon9 = 116.9031911;
             lon10 = 116.87899003;
             lon11 = 116.930422;

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
             lat1 = -34.82967806;
             lat2 = -34.76383762;
             lat3 = -34.83271935;
             lat4 = -34.94438834;
             lat5 = -34.98033472;
             lat6 = -35.00447276;
             lat7 = -35.030016;
             lat8 = -34.995122;
             lat9 = -34.95018745;
             lat10 = -34.97418945;
             lat11 = -34.99223253;

             lon1 = 116.1925907;
             lon2 = 116.37762565;
             lon3 = 116.51377693;
             lon4 = 116.56595377;
             lon5 = 116.5251935;
             lon6 = 116.51203944;
             lon7 = 116.574646;
             lon8 = 116.652399;
             lon9 = 116.81094222;
             lon10 = 116.9031911;
             lon11 = 116.89080104;

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
             lat1 = -34.9998158;
             lat2 = -35.03882088;
             lat3 = -35.033431;
             lat4 = -35.04750998;
             lat5 = -34.97418945;
             lat6 = -34.95018745;
             lat7 = -35.01144231;
             lat8 = -35.023998;
             lat9 = -35.00417571;
             lat10 = -34.94401359;
             lat11 = -34.91574202;

             lon1 = 117.208564;
             lon2 = 117.16019777;
             lon3 = 117.067981;
             lon4 = 116.87899003;
             lon5 = 116.9031911;
             lon6 = 116.81094222;
             lon7 = 116.64429775;
             lon8 = 116.571663;
             lon9 = 116.64429775;
             lon10 = 116.44405718;
             lon11 = 116.62224326;

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
             lat1 = -34.97418945;
             lat2 = -34.969752;
             lat3 = -35.01144231;
             lat4 = -35.023998;
             lat5 = -35.00417571;
             lat6 = -34.94401359;
             lat7 = -34.87034395;
             lat8 = -34.76383762;
             lat9 = -34.82967806;
             lat10 = -34.72002785;
             lat11 = -34.78398604;

             lon1 = 116.9031911;
             lon2 = 116.801495;
             lon3 = 116.64429775;
             lon4 = 116.571663;
             lon5 = 116.50976376;
             lon6 = 116.44405718;
             lon7 = 116.37227607;
             lon8 = 116.37762565;
             lon9 = 116.1925907;
             lon10 = 116.17334534;
             lon11 = 116.21805003;

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
             lat1 = -34.49983265;
             lat2 = -34.55931131;
             lat3 = -34.66401989;
             lat4 = -34.97418945;
             lat5 = -34.82967806;
             lat6 = -34.90051587;
             lat7 = -34.93678839;
             lat8 = -35.00447276;
             lat9 = -35.023998;
             lat10 = -34.995122;
             lat11 = -34.98732003;

             lon1 = 115.9564309;
             lon2 = 116.17455137;
             lon3 = 116.11854781;
             lon4 = 116.17334534;
             lon5 = 116.1925907;
             lon6 = 116.30374529;
             lon7 = 116.4187616;
             lon8 = 116.51203944;
             lon9 = 116.571663;
             lon10 = 116.652399;
             lon11 = 116.72079996;

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
             lat1 = -34.995122;
             lat2 = -35.023998;
             lat3 = -35.00417571;
             lat4 = -34.94401359;
             lat5 = -34.87034395;
             lat6 = -34.76383762;
             lat7 = -34.82967806;
             lat8 = -34.72002785;
             lat9 = -34.66401989;
             lat10 = -34.55931131;
             lat11 = -34.51197522;

             lon1 = 116.652399;
             lon2 = 116.571663;
             lon3 = 116.50976376;
             lon4 = 116.44405718;
             lon5 = 116.37227607;
             lon6 = 116.37762565;
             lon7 = 116.1925907;
             lon8 = 116.17334534;
             lon9 = 116.11854781;
             lon10 = 116.17455137;
             lon11 = 116.16417149;

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
             lat1 = -35.033431;
             lat2 = -35.04750998;
             lat3 = -34.97418945;
             lat4 = -34.95018745;
             lat5 = -35.01144231;
             lat6 = -35.023998;
             lat7 = -35.00417571;
             lat8 = -34.94401359;
             lat9 = -34.87034395;
             lat10 = -34.76383762;
             lat11 = -34.76513387;

             lon1 = 117.067981;
             lon2 = 116.87899003;
             lon3 = 116.9031911;
             lon4 = 116.81094222;
             lon5 = 116.64429775;
             lon6 = 116.571663;
             lon7 = 116.50976376;
             lon8 = 116.44405718;
             lon9 = 116.37227607;
             lon10 = 116.37762565;
             lon11 = 116.32294702;

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
             lat1 = -34.84135003;
             lat2 = -34.878491;
             lat3 = -34.93678839;
             lat4 = -35.00447276;
             lat5 = -34.995122;
             lat6 = -35.0251870416;
             lat7 = -35.02210074;
             lat8 = -35.04750998;
             lat9 = -35.033431;
             lat10 = -35.033431;
            
             lon1 = 116.11995002;
             lon2 = 116.31175999;
             lon3 = 116.4187616;
             lon4 = 116.51203944;
             lon5 = 116.652399;
             lon6 = 116.8105040118;
             lon7 = 116.81942789;
             lon8 = 116.87899003;
             lon9 = 117.067981;
             lon10 = 117.101798;
            
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
             lat1 = -34.856539;
             lat2 = -34.90051587;
             lat3 = -34.8249218;
             lat4 = -34.98033472;
             lat5 = -35.030016;
             lat6 = -34.995122;
             lat7 = -34.95018745;
             lat8 = -34.97418945;
             lat9 = -35.04750998;
             lat10 = -35.033431;
             lat11 = -35.004176;

             lon1 = 116.231534;
             lon2 = 116.30374529;
             lon3 = 116.00766403;
             lon4 = 116.5251935;
             lon5 = 116.574646;
             lon6 = 116.6523996;
             lon7 = 116.81094222;
             lon8 = 116.9031911;
             lon9 = 116.87899003;
             lon10 = 117.067981;
             lon11 = 117.101798;

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
             lat1 = -34.969752;
             lat2 = -35.01144231;
             lat3 = -35.023998;
             lat4 = -35.00417571;
             lat5 = -34.94401359;
             lat6 = -34.87034395;
             lat7 = -34.76383762;
             lat8 = -34.82967806;
             lat9 = -34.84135003;
             lat10 = -34.66401989;
             lat11 = -34.6330667;

             lon1 = 116.801495;
             lon2 = 116.64429775;
             lon3 = 116.574646;
             lon4 = 116.50976376;
             lon5 = 116.44405718;
             lon6 = 116.37227607;
             lon7 = 116.37762565;
             lon8 = 116.1925907;
             lon9 = 116.17334534;
             lon10 = 116.11854781;
             lon11 = 116.12740989;

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

        private void selectGroupThirteen(object sender, RoutedEventArgs e)
        {   
             lat1 = -34.93678839;
             lat2 = -35.00417571;
             lat3 = -35.030016;
             lat4 = -35.030016;
             lat5 = -35.0251870416;
             lat6 = -35.02210074;
             lat7 = -35.04750998;
             lat8 = -35.033431;
             lat9 = -35.03882088;
             lat10 = -34.9998158;

             lon1 = 116.4187616;
             lon2 = 116.50976376;
             lon3 = 116.574646;
             lon4 = 116.652399;
             lon5 = 116.8105040118;
             lon6 = 116.81942789;
             lon7 = 116.87899003;
             lon8 = 117.067981;
             lon9 = 117.16019777;
             lon10 = 117.208564;

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

        private void selectGroup14(object sender, RoutedEventArgs e)
        {
             lat1 = -35.03882088;
             lat2 = -34.94401359;
             lat3 = -35.04750998;
             lat4 = -34.97418945;
             lat5 = -34.95018745;
             lat6 = -35.01144231;
             lat7 = -35.023998;
             lat8 = -35.00417571;
             lat9 = -34.94401359;
             lat10 = -34.87034395;
             lat11 = -34.85064682;

             lon1 = 117.16019777;
             lon2 = 117.067981;
             lon3 = 116.87899003;
             lon4 = 116.9031911;
             lon5 = 116.81094222;
             lon6 = 116.64429775;
             lon7 = 116.571663;
             lon8 = 116.50976376;
             lon9 = 116.44405718;
             lon10 = 116.37227607;
             lon11 = 116.3908787;

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

