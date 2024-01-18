using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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




            Button_0_0.Background = null;
            Button_0_1.Background = null;
            Button_0_2.Background = null;

            Button_1_0.Background = null;
            Button_1_1.Background = null;
            Button_1_2.Background = null;

            Button_2_0.Background = null;
            Button_2_1.Background = null;
            Button_2_2.Background = null;
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button.Content != null) {
                return;
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
            slots++;
            CheckWin();
            if (slots > 9)
            {
                MessageBox.Show($"Remis", "Koniec gry", MessageBoxButton.OK);
                NewGame();
            }
        }
        public void CheckWin() 
        {
           

            if (Button_0_0.Content !=null && Button_0_0.Content == Button_0_1.Content  && Button_0_1.Content == Button_0_2.Content && Button_0_0.Content == Button_0_2.Content)
            {
                Button_0_0.Background = Brushes.Green;
                Button_0_1.Background = Brushes.Green;
                Button_0_2.Background = Brushes.Green;
                ShowWinnerMessage(Button_0_0.Content.ToString());
                
                
            }
            if (Button_1_0.Content != null && Button_1_0.Content == Button_1_1.Content && Button_1_1.Content == Button_1_2.Content && Button_1_0.Content == Button_1_2.Content)
            {
                Button_1_0.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_1_2.Background = Brushes.Green;
                ShowWinnerMessage(Button_1_0.Content.ToString());

            }
            if (Button_2_0.Content != null && Button_2_0.Content == Button_2_1.Content && Button_2_1.Content == Button_2_2.Content && Button_2_0.Content == Button_2_2.Content)
            {
                Button_2_0.Background = Brushes.Green;
                Button_2_1.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                ShowWinnerMessage(Button_2_0.Content.ToString());

            }

            if (Button_1_0.Content != null && Button_0_0.Content == Button_1_0.Content && Button_1_0.Content == Button_2_0.Content && Button_0_0.Content == Button_2_0.Content)
            {
                Button_0_0.Background = Brushes.Green;
                Button_1_0.Background = Brushes.Green;
                Button_2_0.Background = Brushes.Green;
                ShowWinnerMessage(Button_1_0.Content.ToString());

            }
            if (Button_0_1.Content != null && Button_0_1.Content == Button_1_1.Content && Button_1_1.Content == Button_2_1.Content && Button_0_1.Content == Button_2_1.Content)
            {
                Button_0_1.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_2_1.Background = Brushes.Green;
                ShowWinnerMessage(Button_0_1.Content.ToString());

            }
            if (Button_0_2.Content != null && Button_0_2.Content == Button_1_2.Content && Button_1_2.Content == Button_2_2.Content && Button_0_2.Content == Button_2_2.Content)
            {
                Button_0_2.Background = Brushes.Green;
                Button_1_2.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                ShowWinnerMessage(Button_0_2.Content.ToString());

            }



            if (Button_0_0.Content != null && Button_0_0.Content == Button_1_1.Content && Button_1_1.Content == Button_2_2.Content && Button_0_0.Content == Button_2_2.Content)
            {
                Button_0_0.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                ShowWinnerMessage(Button_0_0.Content.ToString());

            }
            if (Button_0_2.Content != null && Button_0_2.Content == Button_1_1.Content && Button_1_1.Content  == Button_2_0.Content && Button_0_2.Content == Button_2_0.Content)
            {
                Button_0_2.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_2_0.Background = Brushes.Green;
                ShowWinnerMessage(Button_0_2.Content.ToString());

            }
            
        }
        private void ShowWinnerMessage(string winner) 
        {
            MessageBox.Show($"{winner} wygrywa!", "Koniec gry", MessageBoxButton.OK);
            NewGame();
        }
    }
}
