namespace desktop
{
    public partial class Form1 : Form
    {
        const int CHARS_START = 97;
        const int CHARS_END = 123; // 122

        public Form1()
        {
            InitializeComponent();
        }

        public static int WrapIndex(int index, int size)
        {
            return ((index % size) + size) % size;
        }

        public static String Ceasar(String text, int key)
        {
            String res = "";

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                if ((int)c < CHARS_START || (int)c > CHARS_END)
                {
                    res += c;
                    continue;
                }

                int charRelativeIdx = c - CHARS_START;
                int newRelativeIdx = WrapIndex(charRelativeIdx + key, CHARS_END - CHARS_START);

                res += (char)(CHARS_START + newRelativeIdx);
            }

            return res;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            int key = 0;
            
            try
            {
                key = int.Parse(inpKey.Text);
            } catch { }
        
            lblEncrypted.Text = Ceasar(inpText.Text, key);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dial = new SaveFileDialog();
            dial.ShowDialog();

            if(dial.FileName == "")
            {
                return;
            }

            File.WriteAllText(dial.FileName, lblEncrypted.Text);
        }
    }
}
