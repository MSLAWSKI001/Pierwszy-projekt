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

namespace Aplikacja_slownikowaWPF
{
   
    public partial class MainWindow : Window
        
    {
       private List<string> word_list = new List<string>();
       public List<string> def_list = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            word_list.Add(add_word.Text);
            def_list.Add(add_def.Text);
            
        }
        private void Refresh_word_list() 
        {
            word_list.DataSource = word_list;
        }
        

       
    }
}
