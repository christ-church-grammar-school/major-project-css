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

            WeightTotal.Text = "Current Total Weight = \n";
            ItemsTotal.Text = "Items Packed Include: \n";
            Required_Items.Text = "Required Items Include: \n";
            Limit.Text = "The Maximum Weight is 25kg\n";
            State.Text = "You Are Currently:\n";

            Include();
            RecomCheck();
            StatusCheck();
        }

        public void Include()
        {
            double weight = 0;

            Dictionary<string, double> items = new Dictionary<string, double>();

            if (AddOn.Text == "")
            {
                for (int i = 0; i < items.Count; i++)
                {
                    int j = i + 1;
                    weight = weight + items.ElementAt(i).Value;
                    ItemsTotal.Text = ItemsTotal.Text + j + ". " + items.ElementAt(i).Key + " (" + items.ElementAt(i).Value + "kg)\n";
                }

                WeightTotal.Text = "Current Total Weight = " + weight + "kg";
            }
            else
            {
                string add = AddOn.Text;
                var removen = new[] { ',', ' ', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '.' };
                var removel = new[] { '=', ',', ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
                string itemadd = add.TrimEnd(removen);
                string weightadd = add.TrimStart(removel);
                double weightaddint = Convert.ToDouble(weightadd);

                items.Add(itemadd, weightaddint);

                for (int i = 0; i < items.Count; i++)
                {
                    double num = Convert.ToDouble(Number.Text);
                    weight = weight + items.ElementAt(i).Value;
                    ItemsTotal.Text = ItemsTotal.Text + num + ". " + items.ElementAt(i).Key + " (" + items.ElementAt(i).Value + "kg)\n";
                    double newnum = num + 1;
                    Number.Text = Convert.ToString(newnum);
                }

                string ChangeWeight = WeightTotal.Text;
                string ChangeWeightS = ChangeWeight.TrimStart(removel);
                string ChangeWeightE = ChangeWeightS.TrimEnd(removel);
                double ChangeWeightInt = Convert.ToDouble(ChangeWeightE);
                double change = ChangeWeightInt + weight;
                WNum.Text = Convert.ToString(change);
                WeightTotal.Text = "Current Total Weight = " + change + "kg";

                AddOn.Text = "";

                RecomCheck();
                StatusCheck();
            }
        }

        public void RecomCheck()
        {
            Required_Items.Text = "Required Items Include: ";

            Dictionary<string, string> recom = new Dictionary<string, string>();

            recom.Add("Sleeping Bag", "Not Included");
            recom.Add("Sleeping Mat", "Not Included");
            recom.Add("Ground Sheet", "Not Included");
            recom.Add("Torch", "Not Included");
            recom.Add("Water Bottle(s)", "Not Included");
            recom.Add("Shirts", "Not Included");
            recom.Add("Shorts/Pants", "Not Included");
            recom.Add("Rain Jacket", "Not Included");
            recom.Add("Fly Net", "Not Included");
            recom.Add("Cooking Ingredients", "Not Included");
            recom.Add("Sandals", "Not Included");


            for (int i = 0; i < recom.Count; i++)
            {
                if (ItemsTotal.Text.Contains(recom.ElementAt(i).Key))
                {
                    string replace = "Included";
                    int j = i + 1;
                    Required_Items.Text = Required_Items.Text + j + ". " + recom.ElementAt(i).Key + ": " + replace + "\n";
                }
                else
                {
                    int j = i + 1;
                    Required_Items.Text = Required_Items.Text + j + ". " + recom.ElementAt(i).Key + ": " + recom.ElementAt(i).Value + "\n";
                }
            }
        }

        public void StatusCheck()
        {
            State.Text = "You Are Currently:\n";
            double weight = Convert.ToDouble(WNum.Text);
            double totalweight = 25 - weight;
            if (totalweight == 0)
            {
                State.Text = "You Are Currently:\n" + "Exactly Full on Pack Weight\n" + "You Can Pack No More\n";
            }
            if (totalweight < 0)
            {
                double leftover = totalweight - (2 * totalweight);
                State.Text = "You Are Currently:\n" + leftover + "kg Over the Pack Weight Limit\n" + "You Must Remove Some Items\n";
            }
            if (totalweight > 0)
            {
                State.Text = "You Are Currently:\n" + totalweight + "kg Under the Pack Weight Limit\n" + "You Still Have Space For Items\n";
            }
        }

        private void WeightCalcBack_Button_Clicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("WeightCalcPage.xaml", UriKind.Relative));
        }

        private void WeightCalcHome_Button_Clicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MainPage.xaml", UriKind.Relative));
        }

        private void AddOnButton_Click(object sender, RoutedEventArgs e)
        {
            Include();
        }
    }
}
