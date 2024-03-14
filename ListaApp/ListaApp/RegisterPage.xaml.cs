using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListaApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RejestracjaPage : ContentPage
    {
        public RejestracjaPage()
        {
            InitializeComponent();
        }
      
        private void Button_Clicked(object sender, EventArgs e)
        {
            string login = login_entry.Text;
            string password = password_entry.Text;
            string confirm_password = confirmpassword_entry.Text;
            if (password == confirm_password)
            {
                var newUser = new User { Login = login, Password = password };
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                DisplayAlert("Błąd","Hasła nei pasują do siebie","ok");
            }
            
            
                
        
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
    }
}