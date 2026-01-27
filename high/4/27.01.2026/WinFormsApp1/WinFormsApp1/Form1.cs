namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            decimal a = sideAinp.Value;
            decimal b = sideBinp.Value;

            areaBox.Value = a * b;
            oblastBox.Value = a * 2 + b * 2;
        }
    }
}
