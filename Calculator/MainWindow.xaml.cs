using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private const string ErrorMessage = "Invalid Expression";
        private string _result;

        public MainWindow()
        {
            InitializeComponent();
        }

        /*
         * Input Btns
         */

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Button curButton = sender as Button;
            Screen.Text += curButton.Content.ToString();
        }

        /*
         * Get Result
         */

        private void resultBtn_Click(object sender, RoutedEventArgs e)
        {
            bool flag = true;
            try
            {
                DataTable table = new DataTable();
                _result = table.Compute(Screen.Text, string.Empty).ToString();
            }
            catch (Exception)
            {
                if (Screen.Text.Contains("^"))
                    flag = GetResult('^');
                else if (Screen.Text.Contains("√"))
                    flag = GetResult('√');
                else
                    flag = false;
            }
            finally
            {
                Screen.Text = flag ? _result : ErrorMessage;
            }
        }

        private bool GetResult(char opt)
        {
            if (Screen.Text.Count(_ => _ == opt) != 1) return false;
            _result =
               (opt == '^'
                    ? Math.Pow(GetArg(opt, firstArg: true), GetArg(opt))
                    : Math.Sqrt(GetArg(opt)) // Expected input is √9 not 9√
                        ).ToString(CultureInfo.InvariantCulture);
            return true;
        }

        private double GetArg(char opt, bool firstArg = false)
        {
            int optIndex = Screen.Text.IndexOf(opt);
            return Convert.ToDouble(
                firstArg
                    ? Screen.Text.Substring(0, optIndex)
                    : Screen.Text.Substring(optIndex + 1));
        }

        /*
         * Backspace Btn
         * Clear Btn
         */

        private void rmvBtn_Click(object sender, RoutedEventArgs e)
        {
            Screen.Text = Screen.Text.Substring(0, Screen.Text.Length - 1);
        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            Screen.Text = "";
        }

    }
}
