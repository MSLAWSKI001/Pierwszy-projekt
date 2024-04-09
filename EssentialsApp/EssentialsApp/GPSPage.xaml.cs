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
	public partial class GPSPage : ContentPage
	{
		public GPSPage ()
		{
			InitializeComponent ();
		}

         async void Button_Clicked(object sender, EventArgs e)
        {
			var result =  await Geolocation.GetLocationAsync( new
					GeolocationRequest(GeolocationAccuracy.Default, TimeSpan.FromMinutes(1)));
            resultLocation.Text = $"Latitude: {result.Latitude}, Longitude: {result.Longitude}, Altitude: {result.Altitude}";

        }
    }
}