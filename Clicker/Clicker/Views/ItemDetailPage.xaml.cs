using Clicker.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Clicker.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}