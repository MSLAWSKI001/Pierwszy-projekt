﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListaApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

        private void Zaloguj_Clicked(object sender, EventArgs e)
        {
            string login = login_entry.Text;
            string password = password_entry.Text;
            User user = User.UsersList.FirstOrDefault(u => u.Login == login && u.Password == password);
            if (login != null && password != null)
            {
            Navigation.PushAsync (new  MainPage());
            }
            else
            {
                DisplayAlert("Niepowodzenie","Błąd logowania","ok");
            }
        }

        private void Rejestruj_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RejestracjaPage());
        }
    }
}