namespace WinFormsApp1
{
    public partial class Form1 : Form
    {


        string Operator = "";
        string NumAStr = "";
        string NumBStr = "";

        public Form1()
        {
            InitializeComponent();

            // Number inputs
            for (int i = 0; i <= 9; i++)
            {
                Button btn = (Button)this.Controls[$"num{i}"]!;

                btn.Click += new System.EventHandler((object sender, EventArgs e) =>
                {
                    PutNumber(btn.Text);
                });
            }

            // Operator inputs
            string[] operatorNames = { "Add", "Sub", "Mul", "Div" };

            foreach (string operatorName in operatorNames)
            {
                Button btn = (Button)this.Controls[$"btn{operatorName}"]!;

                btn.Click += new System.EventHandler((object sender, EventArgs e) =>
                {
                    if (NumAStr.Length == 0)
                        return;

                    Operator = btn.Text;
                    Update();
                });
            }
        }

        void Update()
        {
            textBox.Text = $"{NumAStr} {Operator} {NumBStr}";
        }

        void ClearPartial()
        {
            NumBStr = "";
            Operator = "";
            Update();
        }

        void Clear()
        {
            NumAStr = "";
            ClearPartial();
        }

        void PutNumber(string strNumber)
        {
            if (Operator.Length == 0)
            {
                NumAStr += strNumber;
            }
            else
            {
                NumBStr += strNumber;
            }

            Update();
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (NumAStr.Length == 0 || NumBStr.Length == 0)
                return;

            if (Operator.Length == 0)
                return;

            int numA = int.Parse(NumAStr);
            int numB = int.Parse(NumBStr);
            int result = 0;
            
            switch (Operator)
            {
                case "+":
                    result = numA + numB;
                    break;
                case "-":
                    result = numA - numB;
                    break;
                case "*":
                    result = numA * numB;
                    break;
                case "/":
                    if (numB == 0)
                    {
                        Clear();
                        textBox.Text = "Can't divide by 0";
                        return;
                    }

                    result = numA / numB;
                    break;
                default:
                    result = -9999;
                    break;
            }

            ClearPartial();

            NumAStr = result.ToString();
            Update();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
