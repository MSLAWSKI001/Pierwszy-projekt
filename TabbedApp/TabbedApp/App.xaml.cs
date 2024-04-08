using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            TabbedPage tabbedPage = new TabbedPage();
            tabbedPage.Children.Add(new FirstPage() {Title = "pierwsza"} );
            tabbedPage.Children.Add(new SecondPage() { Title = "druga" });
            tabbedPage.Children.Add(new ThirdPage() { Title = "trzecia" });

            TabbedPage secondTabPage = new TabbedPage();
            secondTabPage.Children.Add(new MainPage());
            secondTabPage.Children.Add(new FirstPage());


            MainPage = tabbedPage;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
