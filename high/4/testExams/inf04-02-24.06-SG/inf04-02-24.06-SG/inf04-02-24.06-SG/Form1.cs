using inf04_02_24._06_SG.Properties;

namespace inf04_02_24._06_SG
{
    public partial class Form1 : Form
    {
        class Album
        {
            public string author;
            public string title;
            public int tracks;
            public int year;
            public int downloads;
        }

        Album[] albums = { };
        Album currentAlbum;
        int currentAlbumIdx = 0;

        /**********************************************
        nazwa funkcji: Form1
        opis funkcji: Konstruktor formularza
        parametry: brak
        zwracany typ i opis: brak
        autor: 1234567890
        ***********************************************/
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        /**********************************************
        nazwa funkcji: LoadData
        opis funkcji: Wczytuje albumy z pliku Data.txt w zasobach projektu
        parametry: brak
        zwracany typ i opis: brak
        autor: 1234567890
        ***********************************************/
        void LoadData()
        {
            string[] lines = Resources.Data.Split("\n");
            int linesPerAlbum = 6;
            int albumCount = lines.Length / linesPerAlbum;
            
            for(int i = 0; i < albumCount; i++)
            {
                int start = i * linesPerAlbum;

                Album album = new Album{ 
                    author = lines[start + 0],
                    title = lines[start + 1],
                    tracks = int.Parse(lines[start + 2]),
                    year = int.Parse(lines[start + 3]),
                    downloads = int.Parse(lines[start + 4])
                };
                
                albums = albums.Append(album).ToArray();
            }

            UpdateAlbum();
        }

        /**********************************************
        nazwa funkcji: UpdateAlbum
        opis funkcji: Aktualizuje formularz na aktualnie wybrany album
        parametry: brak
        zwracany typ i opis: brak
        autor: 1234567890
        ***********************************************/
        void UpdateAlbum()
        {
            Album album = albums[currentAlbumIdx];

            lblTitle.Text = album.title;
            lblAuthor.Text = album.author;
            lblTrackCount.Text = album.tracks.ToString();
            lblYear.Text = album.year.ToString();
            lblDownloads.Text = album.downloads.ToString();

            currentAlbum = album;
        }

        /**********************************************
        nazwa funkcji: btnPrev_Click
        opis funkcji: Obsługa kliknięcia guzika wstecz
        parametry: 
            sender - obiekt wysyłający zdarzenie
            e - dane zdarzenia
        zwracany typ i opis: brak
        autor: 1234567890
        ***********************************************/
        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentAlbumIdx <= 0)
            {
                currentAlbumIdx = albums.Length - 1;
            }
            else
            {
                currentAlbumIdx -= 1;
            }

            UpdateAlbum();
        }


        /**********************************************
        nazwa funkcji: btnNext_Click
        opis funkcji: Obsługa kliknięcia guzika następny
        parametry: 
            sender - obiekt wysyłający zdarzenie
            e - dane zdarzenia
        zwracany typ i opis: brak
        autor: 1234567890
        ***********************************************/
        private void btnNext_Click(object sender, EventArgs e)
        {
            currentAlbumIdx = (currentAlbumIdx + 1) % albums.Length;
            UpdateAlbum();
        }
    
        /**********************************************
        nazwa funkcji: btnPrev_Click
        opis funkcji: Obsługa kliknięcia guzika pobierz
        parametry: 
            sender - obiekt wysyłający zdarzenie
            e - dane zdarzenia
        zwracany typ i opis: brak
        autor: 1234567890
        ***********************************************/
        private void btnDownload_Click(object sender, EventArgs e)
        {
            currentAlbum.downloads += 1;
            UpdateAlbum();
        }
    }
}
