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

namespace kółko_i_krzyżyk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NewGame();
            
        }
        public bool player1Turn { get; set; }
        
        public int slots { get; set; }
        public void NewGame()
        {
            slots = 1;
            player1Turn = true;
            Button_0_0.Content = null;
            Button_0_1.Content = null;
            Button_0_2.Content = null;

            Button_1_0.Content = null;
            Button_1_1.Content = null;
            Button_1_2.Content = null;

            Button_2_0.Content = null;
            Button_2_1.Content = null;
            Button_2_2.Content = null;
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CheckWin();
            var button = sender as Button;
            slots++;
            if (slots > 9)
            {
                 
                NewGame();
            }
            if (player1Turn)
            {
                player1Turn = false;
                button.Content = "X";
            }
            else
            {
               player1Turn = true;
               button.Content = "O";
            }
        }
        public void CheckWin() 
        {
           

            if (Button_0_0.Content == Button_0_1.Content && Button_0_1.Content == Button_0_2.Content && Button_0_0.Content == Button_0_2.Content)
            {
                Button_0_0.Background = Brushes.Green;
                Button_0_1.Background = Brushes.Green;
                Button_0_2.Background = Brushes.Green;
                
            }
            if (Button_1_0.Content == Button_1_1.Content && Button_1_1.Content == Button_1_2.Content && Button_1_0.Content == Button_1_2.Content)
            {
                Button_1_0.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_1_2.Background = Brushes.Green;
                
            }
            if (Button_2_0.Content == Button_2_1.Content && Button_2_1.Content == Button_2_2.Content && Button_2_0.Content == Button_2_2.Content)
            {
                Button_2_0.Background = Brushes.Green;
                Button_2_1.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                
            }

            if (Button_0_0.Content == Button_1_0.Content && Button_1_0.Content == Button_2_0.Content && Button_0_0.Content == Button_2_0.Content)
            {
                Button_0_0.Background = Brushes.Green;
                Button_1_0.Background = Brushes.Green;
                Button_2_0.Background = Brushes.Green;
                
            }
            if (Button_0_1.Content == Button_1_1.Content && Button_1_1.Content == Button_2_1.Content && Button_0_1.Content == Button_2_1.Content)
            {
                Button_0_1.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_2_1.Background = Brushes.Green;
                
            }
            if (Button_0_2.Content == Button_1_2.Content && Button_1_2.Content == Button_2_2.Content && Button_0_2.Content == Button_2_2.Content)
            {
                Button_0_2.Background = Brushes.Green;
                Button_1_2.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                
            }



            if (Button_0_0.Content == Button_1_1.Content && Button_1_1.Content == Button_2_2.Content && Button_0_0.Content == Button_2_2.Content)
            {
                Button_0_0.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                
            }
            if (Button_0_2.Content == Button_1_1.Content && Button_1_1.Content  == Button_2_0.Content && Button_0_2.Content == Button_2_0.Content)
            {
                Button_0_2.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_2_0.Background = Brushes.Green;
                
            }
            
        }
    }
}
