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
        public string Login_str { get; set; }
        public string Password_str { get; set; }    
        
        private void Button_Clicked(object sender, EventArgs e)
        {
            Password_str = password1.Text;
            string password2 = re_password.Text;
            if (Password_str   == password2)
            {
                List<User> users = new List<User>();
                login.Text = Login_str;
                users.Add(new User {Password = Password_str , Login = Login_str});
               
                Navigation.PushAsync(new MainPage(Login ,Password));
            }
            
            
                
        
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
    }
}