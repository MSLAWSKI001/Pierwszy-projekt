namespace Inf04MauiApp
{
    public partial class MainPage : ContentPage
    {
     

        public MainPage()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Clicked(object sender, EventArgs e)
        {
            string strEntryMail = entryMail.Text;
            string strEntryPassword = entryPassword.Text;
            string strRepeatPassword = entryRepeatPassword.Text;
            string letter = "@";

            if (!string.IsNullOrEmpty(strEntryMail) && !string.IsNullOrEmpty(strEntryPassword) && !string.IsNullOrEmpty(strRepeatPassword))
            {
                if (!strEntryMail.Contains(letter))
                {
                    labelMessage.Text = "Nieprawidłowy adres e-mail";
                }

                else if (strEntryPassword != strRepeatPassword)
                {
                    labelMessage.Text = "Hasła się różnią";
                }

                else
                    labelMessage.Text = "Witaj " + strEntryMail;
            }
            else
                labelMessage.Text = "Podano złe dane";
        }
    }

}
