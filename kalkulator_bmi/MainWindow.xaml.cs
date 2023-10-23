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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Sprawdz_Click(object sender, RoutedEventArgs e)
        {
            string wagastr = Waga.Text;
            string wysokoscstr = Wysokość.Text;
            float waga;
            int wysokosc;
            if (string.IsNullOrEmpty(wagastr) && string.IsNullOrEmpty(wysokoscstr))
            {
                Warning.Text = "nie podałeś wagi i wyskości";
                Warning.Visibility = Visibility.Visible;
                Warning.FontSize = 15;
                Warning.Foreground = Brushes.Red;
            }
             void SprawdzanieWagi (string wagastr)
            {
                if (!float.TryParse(wagastr, out waga))
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
            }
            void SprawdzanieWysokości (string wysokoscstr) 
            {
                if (!int.TryParse(wysokoscstr, out wysokosc))
                {
                    Warning.Text = "wysokość nie jest liczbą";
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
                float bmi = (waga) / ((wysokosc / 100) * (wysokosc / 100));
            void SprawdzanieBMI (float bmi)
                {
                    if (bmi<0)
                    {
                        Warning.Text = "bmi mniejsze od 0";
                        Warning.Visibility = Visibility.Visible;
                        Warning.FontSize = 15;
                        Warning.Foreground = Brushes.Red;

                    }
                }
            }
        }
    }
}
