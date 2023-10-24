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
        int waga;
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
            
            else if (!int.TryParse(wagastr, out waga))
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
                double wysokosckw = Math.Round((float)((wysokosc / 100.0) * (wysokosc / 100)),2);
                
                
                double bmi  = Math.Round((double) (waga / wysokosckw ), 2);
                
                if (bmi < 16f)
                {
                    Warning.Text = "wygłodzenie bmi: " + bmi;
                    Warning.Visibility = Visibility.Visible;
                    Warning.FontSize = 15;
                    Warning.Foreground = Brushes.Green;
                }
                if (bmi >= 16f && bmi <= 16.99f)
                {
                    Warning.Text = "wychudzenie bmi: " + bmi;
                    Warning.Visibility = Visibility.Visible;
                    Warning.FontSize = 15;
                    Warning.Foreground = Brushes.Green;
                }
                if (bmi >= 17f && bmi <= 18.49f)
                {
                    Warning.Text = "niedowaga bmi: " + bmi;
                    Warning.Visibility = Visibility.Visible;
                    Warning.FontSize = 15;
                    Warning.Foreground = Brushes.Green;
                }
                if (bmi >= 18.5f && bmi <= 24.99f)
                {
                    Warning.Text = "waga prawidłowa bmi: " + bmi;
                    Warning.Visibility = Visibility.Visible;
                    Warning.FontSize = 15;
                    Warning.Foreground = Brushes.Green;
                }
                if (bmi >= 25f && bmi <= 29.99f)
                {
                    Warning.Text = "nadwaga bmi: " + bmi;
                    Warning.Visibility = Visibility.Visible;
                    Warning.FontSize = 15;
                    Warning.Foreground = Brushes.Green;
                }
                if (bmi >= 30f && bmi <= 34.99f)
                {
                    Warning.Text = "1 stopień otylości bmi: " + bmi;
                    Warning.Visibility = Visibility.Visible;
                    Warning.FontSize = 15;
                    Warning.Foreground = Brushes.Green;
                }
                if (bmi >= 35f && bmi <= 39.99f)
                {
                    Warning.Text = "2 stopień otylości bmi: " + bmi;
                    Warning.Visibility = Visibility.Visible;
                    Warning.FontSize = 15;
                    Warning.Foreground = Brushes.Green;
                }
                if (bmi >= 40.0f)
                { Warning.Text = "otylość skrajna bmi: " + bmi;
                    Warning.Visibility = Visibility.Visible;
                    Warning.FontSize = 15;
                    Warning.Foreground = Brushes.Green;
                }
            }

        }
    }
}
