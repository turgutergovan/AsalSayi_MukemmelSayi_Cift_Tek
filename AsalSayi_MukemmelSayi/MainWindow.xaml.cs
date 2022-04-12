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

namespace AsalSayi_MukemmelSayi
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            int number = Convert.ToInt32(input.Text);

            if (number == 1 || number == 0)
                output.Text = "Sayı asal sayı değil";
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                     count++;
                }
                if (count == 0)
                    output.Text = "Sayı asal sayıdır";
                else
                    output.Text = "Sayı asal sayı değil";
            }
            //-----------------------------------------------------------
            int total = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                    total += i;
            }
            if (number == total)
                output2.Text="Sayı mükemmel sayıdır";
            else
                output2.Text = "Sayı mükemmel sayı değildir";

            //-----------------------------------------------------------

            if (number % 2 == 0)
                output3.Text = "Sayı çiftsayıdır";
            else
                output3.Text = "Sayı tek sayıdır";
        }
    }
}
