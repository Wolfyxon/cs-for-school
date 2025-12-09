namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        const string LETTERS = "qwertyuiopasdfghjklzxcvbnm";
        const string SPECIAL_CHARS = "_-=+/$?_!@#%^&*(){}[]\\/|:;";
        const string NUMS = "1234567890";

        private string Password = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void passGenBtn_Click(object sender, EventArgs e)
        {
            int? length = tryParseInt(passLenInput.Text);

            if (length == null)
            {
                return;
            }

            string[] alphabets = { LETTERS };

            if (specialCheck.Checked)
                alphabets = alphabets.Append(SPECIAL_CHARS).ToArray();

            if (numsCheck.Checked)
                alphabets = alphabets.Append(NUMS).ToArray();

            Password = GenString(alphabets, (int)length, caseCheck.Checked);
            MessageBox.Show(Password);
        }
        
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"Dane pracownika: {nameInput.Text} {surnameInput.Text} " +
                $"{positionSelect.Text} " +
                $"Has³o: {Password} "
            );
        }

        int? tryParseInt(string str)
        {
            try
            {
                return int.Parse(str);
            }
            catch
            {
                return null;
            }
        }

        string GenString(string[] alphabets, int length, bool randCase)
        {
            Random rng = new Random();
            string res = "";

            for (int i = 0; i < length; i++)
            {
                string source = alphabets[rng.Next(0, alphabets.Length)];
                char ch = source[rng.Next(0, source.Length)];

                if (randCase)
                {
                    if (rng.Next(0, 1) == 0)
                    {
                        ch = Char.ToUpper(ch);
                    }
                    else
                    {
                        ch = Char.ToLower(ch);
                    }
                }

                res += ch;
            }

            return res;
        }
    }
}
