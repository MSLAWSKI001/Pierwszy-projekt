using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListaApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListaPage : ContentPage
	{
        ObservableCollection<string> items = new ObservableCollection<string>();
        

        public ListaPage ()
		{
			InitializeComponent ();
            listView.ItemsSource = items;
		}

        private void Back_Clicked(object sender, EventArgs e)
        {
			Navigation.PushAsync(new MainPage());
        }

        private void Add_Clicked(object sender, EventArgs e)
        {
			Navigation.PushAsync(new AddPage(items));
        }

        private void Remove_Clicked(object sender, EventArgs e)
        {
            if (listView.SelectedItem != null)
            {
                string selectedItem = listView.SelectedItem as string;
                items.Remove(selectedItem);
            }
            else
            {
                DisplayAlert("nie wybrano","nie wybrano pozycji","ok");
            }
        }

      
    }
}