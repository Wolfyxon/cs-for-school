using System.Drawing;
using WinFormsApp1.Properties;

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

        private void inpNumber_Leave(object sender, EventArgs e)
        {
            Image? face = (Image?) Resources.ResourceManager.GetObject(inpNumber.Text + "-zdjecie");
            Image? fingerprint = (Image?)Resources.ResourceManager.GetObject(inpNumber.Text + "-odcisk");
            
            imgFace.Image = face;
            imgFingerprint.Image = fingerprint;
        }
    }
}
