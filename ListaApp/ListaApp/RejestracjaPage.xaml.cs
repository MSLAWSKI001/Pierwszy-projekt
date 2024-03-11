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
            string password = password1.Text;
            string password2 = re_password.Text;
            if (password == password2)
            {

            }
            
            
                
        
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}