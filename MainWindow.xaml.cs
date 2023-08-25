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
using static System.Net.Mime.MediaTypeNames;

namespace Assignment_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, RoutedEventArgs e)
        {

            Button button = (Button)sender;

            if (button.Content.ToString() == "Del")
                textBox.Text = "";
            else if (button.Content.ToString() == "Off")
                System.Windows.Application.Current.Shutdown();
            else if (button.Content.ToString() == "=")
            {
                try
                {
                    Result_Click();
                }
                catch (Exception)
                {
                    textBox.Text = "Error!";
                }
            }
            else if (button.Content.ToString() == "R")
            {
                if (textBox.Text.Length > 0)
                {
                    textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
                }
            }
            
            else
                textBox.Text += ((Button)sender).Content.ToString();
        }

    

    public void Result_Click()
        {
            String value;
            int index = 0;
            if (textBox.Text.Contains("+"))
            {
                index = textBox.Text.IndexOf("+");
            }
            else if (textBox.Text.Contains("/"))
            {
                index = textBox.Text.IndexOf("/");
            }
            else if (textBox.Text.Contains("*"))
            {
                index = textBox.Text.IndexOf("*");
            }
            else if (textBox.Text.Contains("-"))
            {
                index = textBox.Text.IndexOf("-");
            }

            value = textBox.Text.Substring(index, 1);

            double sign_one = Convert.ToDouble(textBox.Text.Substring(0, index));
            double sign_two = Convert.ToDouble(textBox.Text.Substring(index + 1, textBox.Text.Length - index - 1));


            switch (value)
            {
                case "+":
                    textBox.Text += "=" + (sign_one + sign_two);
                    break;
                case "*":
                    textBox.Text += "=" + (sign_one * sign_two);
                    break;
                case "/":
                    textBox.Text += "=" + (sign_one / sign_two);
                    break;
                case "-":
                    textBox.Text += "=" + (sign_one - sign_two);
                    break;
            }
        }
    }
}
