using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstApp
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string email_str;
            string password1_str;
            string password2_str;
            email_str = email.Text;
            password1_str = password1.Text;
            password2_str = password2.Text;

            if (!(email_str.Contains("@")))
            {
                show_email.Text = "niepoprawny adres email";
                return;
            }
            if (!(password1_str == password2_str))
            {
                show_email.Text = "hasła się różnią";
                return;
            }



            show_email.Text = "Witaj  " + email_str;
        }
    }
}
