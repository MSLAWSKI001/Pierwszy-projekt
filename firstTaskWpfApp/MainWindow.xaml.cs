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

namespace firstTaskWpfApp
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
       
        private void Wykonaj_Click(object sender, RoutedEventArgs e)
        {
            string username = Username.Text;
            string agestring = Age.Text;
            int age;
            if (string.IsNullOrEmpty(username)&&string.IsNullOrEmpty(agestring))
            {
                Warning.Text = "nie podałeś imienia i wieku";
                Warning.Visibility = Visibility.Visible;
                Warning.FontSize = 15;
                Warning.Foreground = Brushes.Red;
            }
            else if (string.IsNullOrEmpty(username))
            {
                Warning.Text = "nie podałeś imienia";
                Warning.Visibility = Visibility.Visible;
                Warning.FontSize = 15;
                Warning.Foreground = Brushes.Red;
            }
            else if (string.IsNullOrEmpty(agestring))
            {
                Warning.Text = "nie podałeś wieku";
                Warning.Visibility = Visibility.Visible;
                Warning.FontSize = 15;
                Warning.Foreground = Brushes.Red;
            }

            else if (!int.TryParse(agestring, out age))
            {
                Warning.Text = "wiek nie jest liczbą";
                Warning.Visibility = Visibility.Visible;
                Warning.FontSize = 15;
                Warning.Foreground = Brushes.Red;
            }

            else if (age < 18)
            {
                Warning.Text = "jesteś niepełnoletni";
                Warning.Visibility = Visibility.Visible;
                Warning.FontSize = 15;
                Warning.Foreground = Brushes.Red;
            }
            else
            {
                Warning.Visibility = Visibility.Hidden;
            }
        }
    }
}
