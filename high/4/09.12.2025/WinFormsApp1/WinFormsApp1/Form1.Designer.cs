namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            employeeGroup = new GroupBox();
            positionSelect = new ComboBox();
            label3 = new Label();
            surnameInput = new TextBox();
            label2 = new Label();
            nameInput = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            passGenBtn = new Button();
            specialCheck = new CheckBox();
            numsCheck = new CheckBox();
            caseCheck = new CheckBox();
            passLenInput = new TextBox();
            label6 = new Label();
            confirmBtn = new Button();
            employeeGroup.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // employeeGroup
            // 
            employeeGroup.Controls.Add(positionSelect);
            employeeGroup.Controls.Add(label3);
            employeeGroup.Controls.Add(surnameInput);
            employeeGroup.Controls.Add(label2);
            employeeGroup.Controls.Add(nameInput);
            employeeGroup.Controls.Add(label1);
            employeeGroup.Location = new Point(12, 12);
            employeeGroup.Name = "employeeGroup";
            employeeGroup.Size = new Size(222, 168);
            employeeGroup.TabIndex = 0;
            employeeGroup.TabStop = false;
            employeeGroup.Text = "Dane pracownica";
            // 
            // positionSelect
            // 
            positionSelect.FormattingEnabled = true;
            positionSelect.Items.AddRange(new object[] { "Kierownik", "Starszy programista", "Młodszy programista", "Tester" });
            positionSelect.Location = new Point(98, 77);
            positionSelect.Name = "positionSelect";
            positionSelect.Size = new Size(118, 23);
            positionSelect.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 80);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 4;
            label3.Text = "Stanowisko";
            // 
            // surnameInput
            // 
            surnameInput.Location = new Point(98, 48);
            surnameInput.Name = "surnameInput";
            surnameInput.Size = new Size(118, 23);
            surnameInput.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 51);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Nazwisko";
            // 
            // nameInput
            // 
            nameInput.Location = new Point(98, 19);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(118, 23);
            nameInput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "Imię";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(passGenBtn);
            groupBox1.Controls.Add(specialCheck);
            groupBox1.Controls.Add(numsCheck);
            groupBox1.Controls.Add(caseCheck);
            groupBox1.Controls.Add(passLenInput);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(281, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(222, 168);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generowanie hasła";
            // 
            // passGenBtn
            // 
            passGenBtn.BackColor = Color.SteelBlue;
            passGenBtn.ForeColor = Color.White;
            passGenBtn.Location = new Point(60, 137);
            passGenBtn.Name = "passGenBtn";
            passGenBtn.Size = new Size(96, 25);
            passGenBtn.TabIndex = 5;
            passGenBtn.Text = "Generuj hasło";
            passGenBtn.UseVisualStyleBackColor = false;
            passGenBtn.Click += passGenBtn_Click;
            // 
            // specialCheck
            // 
            specialCheck.AutoSize = true;
            specialCheck.Location = new Point(6, 101);
            specialCheck.Name = "specialCheck";
            specialCheck.Size = new Size(107, 19);
            specialCheck.TabIndex = 4;
            specialCheck.Text = "Znaki specjalne";
            specialCheck.UseVisualStyleBackColor = true;
            // 
            // numsCheck
            // 
            numsCheck.AutoSize = true;
            numsCheck.Location = new Point(6, 76);
            numsCheck.Name = "numsCheck";
            numsCheck.Size = new Size(54, 19);
            numsCheck.TabIndex = 3;
            numsCheck.Text = "Cyfry";
            numsCheck.UseVisualStyleBackColor = true;
            // 
            // caseCheck
            // 
            caseCheck.AutoSize = true;
            caseCheck.Location = new Point(6, 52);
            caseCheck.Name = "caseCheck";
            caseCheck.Size = new Size(126, 19);
            caseCheck.TabIndex = 2;
            caseCheck.Text = "Małe i wielkie litery";
            caseCheck.UseVisualStyleBackColor = true;
            // 
            // passLenInput
            // 
            passLenInput.Location = new Point(98, 19);
            passLenInput.Name = "passLenInput";
            passLenInput.Size = new Size(118, 23);
            passLenInput.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 22);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 0;
            label6.Text = "Ile znaków?";
            // 
            // confirmBtn
            // 
            confirmBtn.BackColor = Color.SteelBlue;
            confirmBtn.ForeColor = Color.White;
            confirmBtn.Location = new Point(163, 197);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(191, 29);
            confirmBtn.TabIndex = 6;
            confirmBtn.Text = "Zatwierdź";
            confirmBtn.UseVisualStyleBackColor = false;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(536, 238);
            Controls.Add(confirmBtn);
            Controls.Add(groupBox1);
            Controls.Add(employeeGroup);
            Name = "Form1";
            Text = "Dodaj pracownika";
            employeeGroup.ResumeLayout(false);
            employeeGroup.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox employeeGroup;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label3;
        private TextBox nameInput;
        private TextBox surnameInput;
        private Label label2;
        private ComboBox positionSelect;
        private GroupBox groupBox1;
        private Label label6;
        private TextBox passLenInput;
        private CheckBox specialCheck;
        private CheckBox numsCheck;
        private CheckBox caseCheck;
        private Button passGenBtn;
        private Button confirmBtn;
    }
}
