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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double arg1 = 0, arg2 = 0;
        private double result;
        private string resultStr = "";
        private char opt;
        public MainWindow()
        {
            InitializeComponent();
            screen.Text = "";
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += "1";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += "2";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += "3";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += "4";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += "5";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += "6";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += "7";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += "8";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += "9";
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += "0";
        }


        private void resultBtn_Click(object sender, RoutedEventArgs e)
        {
            if (opt == '+')
            {
                arg2 = Convert.ToDouble(screen.Text);
                result = arg1 + arg2;
                resultStr = result.ToString();
                screen.Text = resultStr;
            }
            else if (opt == '-')
            {
                arg2 = Convert.ToDouble(screen.Text);
                result = arg1 - arg2;
                resultStr = result.ToString();
                screen.Text = resultStr;
            }
            else if (opt == '/')
            {
                arg2 = Convert.ToDouble(screen.Text);
                result = arg1 / arg2;
                resultStr = result.ToString();
                screen.Text = resultStr;
            }
            else if (opt == '*')
            {
                arg2 = Convert.ToDouble(screen.Text);
                result = arg1 * arg2;
                resultStr = result.ToString();
                screen.Text = resultStr;
            }
            else if (opt == '^')
            {
                arg2 = Convert.ToDouble(screen.Text);
                result = Math.Pow(arg1, arg2);
                resultStr = result.ToString();
                screen.Text = resultStr;
            }
            else
                screen.Text = "No operator";
            arg1 = 0;
            arg2 = 0;
            result = 0;
            resultStr = "";
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            arg1 += Convert.ToDouble(screen.Text);
            opt = '+';
            screen.Text = "";
        }

        private void subBtn_Click(object sender, RoutedEventArgs e)
        {
            arg1 -= Convert.ToDouble(screen.Text);
            opt = '-';
            screen.Text = "";
        }           

        private void divBtn_Click(object sender, RoutedEventArgs e)
        {
            if (arg1 == 0)
                arg1 = Convert.ToDouble(screen.Text);
            else
                arg1 /= Convert.ToDouble(screen.Text);
            opt = '/';
            screen.Text = "";
        }

        private void mulBtn_Click(object sender, RoutedEventArgs e)
        {
            if (arg1 == 0)
                arg1 = Convert.ToDouble(screen.Text);
            else
                arg1 *= Convert.ToDouble(screen.Text);
            opt = '*';
            screen.Text = "";
        }
        private void pointBtn_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += ".";
        }

        private void rmvBtn_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text.Substring(0, screen.Text.Length - 1);
        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = "";
            arg1 = 0;
            arg2 = 0;
            result = 0;
            resultStr = "";
        }

        private void powBtn_Click(object sender, RoutedEventArgs e)
        {
            arg1 = Convert.ToDouble(screen.Text);
            opt = '^';
            screen.Text = "";
        }

        private void sqrtBtn_Click(object sender, RoutedEventArgs e)
        {
            arg1 = Convert.ToDouble(screen.Text);
            result = Math.Sqrt(arg1);
            resultStr = result.ToString();
            screen.Text = resultStr;

        }

    }
}
