namespace desktopPracownicy
{
    public partial class Form1 : Form
    {
        private String password = "";

        private const String LETTERS = "qwertyuiopasdfghjklzxcvbnm";
        private const String NUMS = "1234567890";
        private const String SPECIAL = "@#$%^&*()_+-=";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenPass_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            String chars = GetPasswordCharset();

            int len = int.Parse(inpLen.Text);

            password = "";

            for (int i = 0; i < len; i++)
            {
                char c = chars[rng.Next(0, chars.Length)];
                
                if(checkCase.Checked && rng.Next(0, 1) == 1)
                {
                    c = c.ToString().ToUpper()[0];
                }

                password += c;
            }

            MessageBox.Show(password);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"Dane pracownika: {inpName.Text} {inpLastName.Text} {comboPosition.Text} Hasło: {password}"
            );
        }

        String GetPasswordCharset() 
        {
            String res = LETTERS;

            if(checkNumbers.Checked)
            {
                res += NUMS;
            }

            if(checkSpecial.Checked)
            {
                res += SPECIAL;
            }

            return res;
        }
    }
}
