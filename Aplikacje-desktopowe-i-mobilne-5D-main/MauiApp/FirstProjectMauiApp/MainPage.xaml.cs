namespace FirstProjectMauiApp
{
    public partial class MainPage : ContentPage
    {
        private List<string> fruitsCollections;

        public MainPage()
        {
            InitializeComponent();
            fruitsCollections = new List<string>();
            fruitsCollections.Add("Jabłko");
            fruitsCollections.Add("Ananas");
            fruitsCollections.Add("Gruszka");

            fruitPicker.ItemsSource = fruitsCollections;

            fruitPicker.SelectedItem = "Jabłko";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string text = messageEntry.Text;
            messageEntry.Text = " ";
            messageLabel.Text = "Podano: " + text;
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            ageLabel.Text = "Wybrano: " + ageSlider.Value;
        }

        private void Favorite_Button_Clicked(object sender, EventArgs e)
        {
            favoriteFruitLabel.Text = "Wybrano ulubiony owoc: " + fruitPicker.SelectedItem;
        }

        private void add_Image(object sender, EventArgs e)
        {
            ourImage.Source = "scout_flash.png";
        }
    }

}
