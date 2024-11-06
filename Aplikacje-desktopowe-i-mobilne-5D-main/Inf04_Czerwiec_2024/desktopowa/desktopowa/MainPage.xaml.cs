using static desktopowa.MainPage;

namespace desktopowa
{
    public partial class MainPage : ContentPage
    {
        List<Album> albums = new List<Album>();
        public int currentIndex = 0;

        public MainPage()
        {
            InitializeComponent();
            using (StreamReader reader = new StreamReader("Data.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Album album = new Album()
                    {
                        artist = line,
                        album = reader.ReadLine(),
                        songsNumber = int.Parse(reader.ReadLine()),
                        publicYear = int.Parse(reader.ReadLine()),
                        downloadNumber = int.Parse(reader.ReadLine()),
                        newLine = reader.ReadLine()
                    };
                    albums.Add(album);
                }
            }
            updateAlbum();
        }

        private void updateAlbum()
        {
            Album currentAlbum = albums[currentIndex];
            titleLabel.Text = currentAlbum.album;
            musicNumberLabel.Text = currentAlbum.songsNumber.ToString() + " utworów";
            publicYearLabel.Text = currentAlbum.publicYear.ToString();
            downloadNumberLabel.Text = currentAlbum.downloadNumber.ToString();
            artistLabel.Text = currentAlbum.artist.ToString();
        }

        private void downloadButton_Clicked(object sender, EventArgs e)
        {
            albums[currentIndex].downloadNumber++;
            updateAlbum();
        }

        public class Album
        {
            public string artist { get; set; }
            public string album { get; set; }
            public int songsNumber { get; set; }
            public int publicYear { get; set; }
            public int downloadNumber { get; set; }
            public string newLine { get; set; }
        }

        private void rightButton_Clicked(object sender, EventArgs e)
        {
            currentIndex = (currentIndex - 1 + albums.Count) % albums.Count;
            updateAlbum();
        }

        private void leftButton_Clicked(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % albums.Count;
            updateAlbum();
        }

    }
}
