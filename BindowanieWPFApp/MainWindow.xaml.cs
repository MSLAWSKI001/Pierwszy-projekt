using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace BindowanieWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        public string SourceValue { get; set; }
        public string StringNubmerOfWeek  { get; set; }
        //public string NameDayOfWeek { get; set; }
        private string nameDayOfWeek;
        public string NameDayOfWeek
        {
            get
            {
                return nameDayOfWeek;
            }
            set
            {
               nameDayOfWeek = value;
               OnPropertyChanged();
            }
    }
        
        
        public MainWindow()
        {
            InitializeComponent();
        }
        #region Informowanie bindowania
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName  = null)
        { 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string value = textBoxInfo.Text;
            TextBlockwynik.Text = value;
        }

        private void textBoxInfo_TextChanged(object sender, TextChangedEventArgs e)
        {
            string value = textBoxInfo.Text;
            TextBlockwynik.Text = value;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Zawartość: " + SourceValue);
        }

        private void DzienButton_Click(object sender, RoutedEventArgs e)
        {
            switch (StringNubmerOfWeek) 
            {
                case "1":
                    NameDayOfWeek = "poniedziłek";
                    //OnPropertyChanged("NameDayOfWeek");
                    break;
                case "2":
                    NameDayOfWeek = "Wtorek";
                    //OnPropertyChanged("NameDayOfWeek");
                    break;
                case "3":
                    NameDayOfWeek = "Środa";
                    //OnPropertyChanged(nameof(NameDayOfWeek));
                    break;
                case "4":
                    NameDayOfWeek = "Czwartek";
                    //OnPropertyChanged(nameof(NameDayOfWeek));
                    break;
                case "5":
                    NameDayOfWeek = "Piatek";
                    //OnPropertyChanged(nameof(NameDayOfWeek));
                    break;
                case "6":
                    NameDayOfWeek = "Sobota";
                    //OnPropertyChanged(nameof(NameDayOfWeek));
                    break;
                case "7":
                    NameDayOfWeek = "Niedziela";
                    //OnPropertyChanged(nameof(NameDayOfWeek));
                    break;
                default:
                    NameDayOfWeek = "Zła zmienna";
                    break;
            }
        }
    }
}
