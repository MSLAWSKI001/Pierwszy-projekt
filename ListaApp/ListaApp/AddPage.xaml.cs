using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListaApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddPage : ContentPage
	{
		
		ObservableCollection<string> items;
		public AddPage (ObservableCollection<string> items)
		{
			InitializeComponent ();
			this.items = items;
		}
        private void Button_Clicked(object sender, EventArgs e)
        {
			Navigation.PushAsync(new ListaPage());
        }

        private void Add_Clicked(object sender, EventArgs e)
        {
			string newItem = text_entry.Text;
            if (! string.IsNullOrEmpty(newItem))
            {
				items.Add(newItem);
				Navigation.PopAsync();
            }
        }
    }
}