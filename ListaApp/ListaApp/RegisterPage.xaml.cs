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
            User.UsersList = new List<User>();
        }
      
        private void Button_Rejestruj(object sender, EventArgs e)
        {
            string login = login_entry.Text;
            string password = password_entry.Text;
            string confirm_password = confirmpassword_entry.Text;
            if (login == null && password == null)
            {
                DisplayAlert("Błąd", "Niepodałeś loginu lub hasła", "ok");
                return;
            }
            {
            if (password == confirm_password)
            {
                User newUser = new User { Login = login, Password = password };
                User.UsersList.Add(newUser);
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                DisplayAlert("Błąd","Hasła nei pasują do siebie","ok");
            }  
            }
            
            
                
        
        }

        private void Button_Zaloguj(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
    }
}