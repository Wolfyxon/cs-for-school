using System.Drawing;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string color = GetSelectedEyeColorName();
            MessageBox.Show($"{inpName.Text} {inpSurname.Text} kolor oczu {color}");
        }
    }
}
