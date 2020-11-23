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

namespace bruhh
{

    public partial class MainWindow : Window
    {
        string input;
        double calc1;
        double calc2;
        double ismin;
        double sum;
        bool plus = false;
        bool min = false;
        bool multip = false;
        bool div = false;

        bool usedcomma = false;

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

            if (String.IsNullOrEmpty(input))
            {

            }
            else
            {


                calc1 = Convert.ToDouble(input);
                ismin = calc1 * -1;

                input = Convert.ToString(ismin);


            }
            Output.Text = input;
        }
        void Comma(object sender, RoutedEventArgs e)
        {
            if (usedcomma == false)
            {
                input += ",";
                Output.Text = input;
                usedcomma = true;
            }

        }
        void Equals(object sender, RoutedEventArgs e)
        {
            calc2 = Convert.ToDouble(input);
            input = "";
            if (plus == true)
            {
                sum = calc1 + calc2;
            }
            else if (min == true)
            {

                if (calc1 >= calc2)
                {
                    sum = calc1 - calc2;
                }
                else
                {
                    sum = 000;
                }

            }
            else if (multip == true)
            {
                sum = calc1 * calc2;
            }
            else if (div == true)
            {
                if (calc2 != 0)
                {
                    sum = calc1 / calc2;
                }
                else
                {
                    sum = 000;
                }


            }

            input = Convert.ToString(sum);
            Output.Text = input;
            plus = false;
            min = false;
            div = false;
            multip = false;
            usedcomma = false;
            input = "";
        }
        void Plus(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(input))
            {

            }
            else
            {


                if (multip || div || min)
                {

                }
                else
                {
                    calc1 = Convert.ToDouble(input);
                    input = "";
                    Output.Text = input;
                    plus = true;
                    usedcomma = false;
                }

            }
        }

        void Minus(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(input))
            {

            }
            else
            {


                if (multip || div || plus)
                {

                }
                else
                {
                    calc1 = Convert.ToDouble(input);
                    input = "";
                    Output.Text = input;
                    min = true;
                    usedcomma = false;
                }
            }

        }
        void Multiplication(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(input))
            {

            }
            else
            {


                if (plus || div || min)
                {

                }
                else
                {
                    calc1 = Convert.ToDouble(input);
                    input = "";
                    Output.Text = input;
                    multip = true;
                    usedcomma = false;
                }
            }

        }
        void Division(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(input))
            {

            }
            else
            {



                if (multip || plus || min)
                {

                }
                else
                {
                    calc1 = Convert.ToDouble(input);
                    input = "";
                    Output.Text = input;
                    div = true;
                    usedcomma = false;
                }
            }

        }
        void CE(object sender, RoutedEventArgs e)
        {
            calc1 = 0;
            calc2 = 0;
            input = "";
            Output.Text = input;
        }
        void C(object sender, RoutedEventArgs e)
        {
            if (plus || multip || div || min)
            {
                calc2 = 0;

            }
            else
            {
                calc1 = 0;
            }
            input = "";
            Output.Text = input;
        }
        void Del(object sender, RoutedEventArgs e)
        {

            if (String.IsNullOrEmpty(input))
            {

            }
            else
            {
                string f = input.Remove(input.Length - 1);
                input = f;
                Output.Text = input;
            }

        }



    }
}
