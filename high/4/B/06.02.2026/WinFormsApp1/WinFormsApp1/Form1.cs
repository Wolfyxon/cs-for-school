using WinFormsApp1.Properties;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        /*
        **********************************************
        nazwa funkcji: Form1
        opis funkcji: Konstruktor interfejsu
        parametry: brak
        zwracany typ i opis: brak
        autor: 1234567890
        ***********************************************
        */
        public Form1()
        {
            InitializeComponent();
        }

        /*
        **********************************************
        nazwa funkcji: GetSelectedEyeColor
        opis funkcji: Zwraca nazwê wybranego koloru oczu
        parametry: brak
        zwracany typ i opis: string - Nazwa wybranego koloru
        autor: 1234567890
        ***********************************************
        */
        string GetSelectedEyeColorName()
        {
            if (radioBlue.Checked)
            {
                return "niebieski";
            }
            else if (radioGreen.Checked)
            {
                return "zielone";
            }
            else if (radioBeer.Checked)
            {
                return "piwne";
            } else
            {
                return "niewidzialne";
            }
        }

        /*
        **********************************************
        nazwa funkcji: btnSubmit_Click
        opis funkcji: Obs³uga przycisku "OK". Wyœwietla
                      podane informacje
        parametry: sender - obiekt wywo³uj¹cy zdarzenie
                   e      - parametry zdarzenia
        zwracany typ i opis: brak
        autor: 1234567890
        ***********************************************
        */
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string color = GetSelectedEyeColorName();
            MessageBox.Show($"{inpName.Text} {inpSurname.Text} kolor oczu {color}");
        }

        /*
        **********************************************
        nazwa funkcji: inpNumber_Leave
        opis funkcji: Obs³uga zdarzenia opuszczenia 
                      pola "numer". Aktualizuje obrazy na
                      podstawie wpisanego numeru.
        parametry: sender - obiekt wywo³uj¹cy zdarzenie
                   e      - parametry zdarzenia
        zwracany typ i opis: brak
        autor: 1234567890
        ***********************************************
        */
        private void inpNumber_Leave(object sender, EventArgs e)
        {
            Image? face = (Image?) Resources.ResourceManager.GetObject(inpNumber.Text + "-zdjecie");
            Image? fingerprint = (Image?)Resources.ResourceManager.GetObject(inpNumber.Text + "-odcisk");
            
            imgFace.Image = face;
            imgFingerprint.Image = fingerprint;
        }
    }
}
