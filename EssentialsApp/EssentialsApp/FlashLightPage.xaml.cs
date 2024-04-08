using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
namespace EssentialsApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlashLightPage : ContentPage
    {
        public FlashLightPage()
        {
            InitializeComponent();
        }

        private void TurnON_Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();

                if (location != null)
                {
                    Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                }
            }
            catch (Exception)
            {

                //throw;
            }
        }

       
        
    }
}