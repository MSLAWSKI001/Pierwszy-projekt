using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace kalkulator_bmi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float wysokosc;
        float waga;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Sprawdz_Click(object sender, RoutedEventArgs e)
        {
            string wagastr = Waga.Text;
            string wysokoscstr = Wysokość.Text;
         
            if (string.IsNullOrEmpty(wagastr) && string.IsNullOrEmpty(wysokoscstr))
            {
                Warning.Text = "nie podałeś wagi i wyskości";
                Warning.Visibility = Visibility.Visible;
                Warning.FontSize = 15;
                Warning.Foreground = Brushes.Red;
            }

            else if (!float.TryParse(wysokoscstr, out wysokosc))
            {
                Warning.Text = "wysokość nie jest liczbą";
                Warning.Visibility = Visibility.Visible;
                Warning.FontSize = 15;
                Warning.Foreground = Brushes.Red;
            }
            
            else if (!float.TryParse(wagastr, out waga))
            {
                Warning.Text = "waga nie jest liczbą";
                Warning.Visibility = Visibility.Visible;
                Warning.FontSize = 15;
                Warning.Foreground = Brushes.Red;
            }
            else if (500 < waga || waga < 0.01)
            {
                Warning.Text = "nie poprawna waga";
                Warning.Visibility = Visibility.Visible;
                Warning.FontSize = 15;
                Warning.Foreground = Brushes.Red;
            }
            else if (500 < wysokosc || wysokosc < 1)
            {
                Warning.Text = "nie poprawna wysokość";
                Warning.Visibility = Visibility.Visible;
                Warning.FontSize = 15;
                Warning.Foreground = Brushes.Red;
            }
                
            else
            {
                float bmi = (waga) / ((wysokosc / 100) * (wysokosc / 100));
                if (bmi < 16)
                {
                    Warning.Text = "wygłodzenie " + bmi;
                    Warning.Visibility = Visibility.Visible;
                    Warning.FontSize = 15;
                    Warning.Foreground = Brushes.Green;
                }
                else if (bmi <= 16 && bmi < 17)
                {
                    Warning.Text = "wychudzenie " + bmi;
                    Warning.Visibility = Visibility.Visible;
                    Warning.FontSize = 15;
                    Warning.Foreground = Brushes.Green;
                }
                else if (bmi >= 17 && bmi < 18.5)
                {
                    Warning.Text = "niedowaga " + bmi;
                    Warning.Visibility = Visibility.Visible;
                    Warning.FontSize = 15;
                    Warning.Foreground = Brushes.Green;
                }
                else if (bmi >= 18.5 && bmi < 25)
                {
                    Warning.Text = "waga prawidłowa " + bmi;
                    Warning.Visibility = Visibility.Visible;
                    Warning.FontSize = 15;
                    Warning.Foreground = Brushes.Green;
                }
                else if (bmi >= 25 && bmi < 30)
                {
                    Warning.Text = "nadwaga " + bmi;
                    Warning.Visibility = Visibility.Visible;
                    Warning.FontSize = 15;
                    Warning.Foreground = Brushes.Green;
                }
                else if (bmi >= 30 && bmi < 35)
                {
                    Warning.Text = "1 stopień otylości " + bmi;
                    Warning.Visibility = Visibility.Visible;
                    Warning.FontSize = 15;
                    Warning.Foreground = Brushes.Green;
                }
                else if (bmi >= 35 && bmi < 40)
                {
                    Warning.Text = "2 stopień otylości " + bmi;
                    Warning.Visibility = Visibility.Visible;
                    Warning.FontSize = 15;
                    Warning.Foreground = Brushes.Green;
                }
                else if (bmi>40)
                { Warning.Text = "otylość skrajna " + bmi;
                    Warning.Visibility = Visibility.Visible;
                    Warning.FontSize = 15;
                    Warning.Foreground = Brushes.Green;
                }
            }

        }
    }
}
