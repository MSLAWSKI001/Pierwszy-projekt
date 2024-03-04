using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Clicker.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            
            InitializeComponent();
        }
        public int score { get; set; }
        public int gold { get; set; } = 0;
        public int hp { get; set; } = 50;
        private void Button_Clicked(object sender, EventArgs e)
        {
            hp--;
            score_label.Text = hp.ToString();
            if (hp <= 0)
            {
                hp = 50;
                gold++;
                gold_label.Text = gold.ToString();
            }

        }
    }
}