using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EssentialsApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void FlashLight_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FlashLightPage());
        }

        private void GPS_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GPSPage());
        }

        private void Compass_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CompassPage());
        }
    }
}
