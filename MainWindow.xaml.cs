using System.Text;
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
        
        int num1 , num2, netice;
        char op;
        

        public MainWindow()
        {
            InitializeComponent();
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

        private void toplamaBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(screen.Text))
            {
                num1 = int.Parse(screen.Text);
                screen.Text = "";
                op = '+';
            }
            else
            {
                MessageBox.Show("ilk once ededi daxil edin");
            }
        }

        private void cixmaBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(screen.Text))
            {
                num1 = int.Parse(screen.Text);
                op = '-';
                screen.Text = "";
            }
            else
            {
                MessageBox.Show("ilk once ededi daxil edin");
            }
        }

        private void vurmaBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(screen.Text))
            {
                num1 = int.Parse(screen.Text);
                op = '*';
                screen.Text = "";
            }
            else
            {
                MessageBox.Show("ilk once ededi daxil edin");
            }
        }

        private void bolmeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(screen.Text))
            {
                num1 = int.Parse(screen.Text);
                op = '/';
                screen.Text = "";
            }
            else
            {
                MessageBox.Show("ilk once ededi daxil edin");
            }
        }

        

        private void beraberBtn_Click(object sender, RoutedEventArgs e)
        {
            num2 = int.Parse(screen.Text);
            if (op == '+')
            {
                netice = num1 + num2;
                screen.Text = netice.ToString();
            }
            else if (op == '-')
            {
                netice = num1 - num2;
                screen.Text = netice.ToString();
            }
            else if (op == '/')
            {
                netice = num1 / num2;
                screen.Text = netice.ToString();
            }
            else if (op == '*')
            {
                netice = num1 * num2;
                screen.Text = netice.ToString();
            }
            else
                MessageBox.Show("nese sehvdi");
            screen.Text = "";
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(screen.Text) )
            {
                screen.Text += "0";
            }
            else
            {
                MessageBox.Show("ededd sifirla baslaya bilmez");
            }
        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += "1";
        }

    }
}