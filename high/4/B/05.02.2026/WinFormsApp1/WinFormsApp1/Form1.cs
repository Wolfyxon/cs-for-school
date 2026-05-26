namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckPrice_Click(object sender, EventArgs e)
        {
            double price = 0;

            if(radioPostcard.Checked)
            {
                price = 1;
            } else if (radioLetter.Checked)
            {
                price = 1.5;
            } else if (radioPackage.Checked)
            {
                price = 10;
            }

            lblPrice.Text = $"Cena: {price} z³";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(inpPostCode.Text.Length != 5)
            {
                MessageBox.Show("Nieprawid³owa liczba cyfr w kodzie pocztowym");
                return;
            }

            try
            {
                int.Parse(inpPostCode.Text);
            } catch
            {
                MessageBox.Show("Kod pocztowy powinien siê sk³adaæ z samych cyfr");
                return;
            }

            MessageBox.Show("Dane przesy³ki zosta³y wprowadzone");
        }
    }
}
