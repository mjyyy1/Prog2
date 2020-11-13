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

namespace kalkylator
{
    public partial class MainWindow : Window
    {

        string input;//turn this to calc1 before asking for next number
        int convert;
        double calc1;
        double calc2;
        bool isnegative = false;

        public MainWindow()
        {
            InitializeComponent();

        }


        void Noll(object sender, RoutedEventArgs e)
        {

            input += "0";
            Output.Text = input;
        }
        void One(object sender, RoutedEventArgs e)
        {

            input += "1";
            Output.Text = input;
        }

        void Two(object sender, RoutedEventArgs e)
        {

            input += "2";
            Output.Text = input;
        }
        void Three(object sender, RoutedEventArgs e)
        {

            input += "3";
            Output.Text = input;
        }
        void Four(object sender, RoutedEventArgs e)
        {

            input += "4";
            Output.Text = input;
        }
        void Five(object sender, RoutedEventArgs e)
        {

            input += "5";
            Output.Text = input;
        }
        void Six(object sender, RoutedEventArgs e)
        {

            input += "6";
            Output.Text = input;
        }
        void Seven(object sender, RoutedEventArgs e)
        {

            input += "7";
            Output.Text = input;
        }
        void Eight(object sender, RoutedEventArgs e)
        {

            input += "8";
            Output.Text = input;
        }
        void Nine(object sender, RoutedEventArgs e)
        {

            input += "9";
            Output.Text = input;
        }



        void PlusMinus(object sender, RoutedEventArgs e)
        {
            if (isnegative == false)

            {
               
            }
            else if (isnegative == true){

            }
        }
        void Comma(object sender, RoutedEventArgs e)
        {

            input += ",";
            Output.Text = input;
        }
        void Equals(object sender, RoutedEventArgs e)
        {
            calc2 = Convert.ToDouble(input);
            input = "";
            Output.Text = input;
        }
        void Plus(object sender, RoutedEventArgs e)
        {
            calc1 = Convert.ToDouble(input);
            input = "";
            Output.Text = input;
        }

        void Minus(object sender, RoutedEventArgs e)
        {

        }
        void Multiplication(object sender, RoutedEventArgs e)
        {

        }
        void Division(object sender, RoutedEventArgs e)
        {

        }
        void CE(object sender, RoutedEventArgs e)
        {

        }
        void C(object sender, RoutedEventArgs e)
        {

        }
        void Del(object sender, RoutedEventArgs e)
        {
         
            
        }



}

}
