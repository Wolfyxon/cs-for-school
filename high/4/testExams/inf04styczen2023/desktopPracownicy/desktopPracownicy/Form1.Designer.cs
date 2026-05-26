namespace desktopPracownicy
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            comboPosition = new ComboBox();
            label2 = new Label();
            inpLastName = new TextBox();
            label1 = new Label();
            inpName = new TextBox();
            groupBox2 = new GroupBox();
            btnGenPass = new Button();
            checkSpecial = new CheckBox();
            checkNumbers = new CheckBox();
            checkCase = new CheckBox();
            label4 = new Label();
            inpLen = new TextBox();
            btnConfirm = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboPosition);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(inpLastName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(inpName);
            groupBox1.Location = new Point(31, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 263);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodaj pracownika";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 146);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 5;
            label3.Text = "Stanowisko";
            // 
            // comboPosition
            // 
            comboPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPosition.FormattingEnabled = true;
            comboPosition.Items.AddRange(new object[] { "Kierownik", "Starszy programista", "Młodszy programista", "Tester" });
            comboPosition.Location = new Point(148, 143);
            comboPosition.Name = "comboPosition";
            comboPosition.Size = new Size(182, 33);
            comboPosition.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 92);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 3;
            label2.Text = "Nazwisko";
            // 
            // inpLastName
            // 
            inpLastName.Location = new Point(148, 89);
            inpLastName.Name = "inpLastName";
            inpLastName.Size = new Size(182, 31);
            inpLastName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 38);
            label1.Name = "label1";
            label1.Size = new Size(46, 25);
            label1.TabIndex = 1;
            label1.Text = "Imię";
            // 
            // inpName
            // 
            inpName.Location = new Point(148, 35);
            inpName.Name = "inpName";
            inpName.Size = new Size(182, 31);
            inpName.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnGenPass);
            groupBox2.Controls.Add(checkSpecial);
            groupBox2.Controls.Add(checkNumbers);
            groupBox2.Controls.Add(checkCase);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(inpLen);
            groupBox2.Location = new Point(441, 45);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(347, 263);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Generowanie hasła";
            // 
            // btnGenPass
            // 
            btnGenPass.BackColor = Color.SteelBlue;
            btnGenPass.ForeColor = Color.White;
            btnGenPass.Location = new Point(115, 205);
            btnGenPass.Name = "btnGenPass";
            btnGenPass.Size = new Size(146, 35);
            btnGenPass.TabIndex = 10;
            btnGenPass.Text = "Generuj hasło";
            btnGenPass.UseVisualStyleBackColor = false;
            btnGenPass.Click += btnGenPass_Click;
            // 
            // checkSpecial
            // 
            checkSpecial.AutoSize = true;
            checkSpecial.Location = new Point(21, 158);
            checkSpecial.Name = "checkSpecial";
            checkSpecial.Size = new Size(157, 29);
            checkSpecial.TabIndex = 9;
            checkSpecial.Text = "Znaki specjalne";
            checkSpecial.UseVisualStyleBackColor = true;
            // 
            // checkNumbers
            // 
            checkNumbers.AutoSize = true;
            checkNumbers.Location = new Point(21, 123);
            checkNumbers.Name = "checkNumbers";
            checkNumbers.Size = new Size(79, 29);
            checkNumbers.TabIndex = 8;
            checkNumbers.Text = "Cyfry";
            checkNumbers.UseVisualStyleBackColor = true;
            // 
            // checkCase
            // 
            checkCase.AutoSize = true;
            checkCase.Location = new Point(21, 88);
            checkCase.Name = "checkCase";
            checkCase.Size = new Size(186, 29);
            checkCase.TabIndex = 7;
            checkCase.Text = "Małe i wielkie litery";
            checkCase.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 38);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 6;
            label4.Text = "Ile znaków?";
            // 
            // inpLen
            // 
            inpLen.Location = new Point(159, 38);
            inpLen.Name = "inpLen";
            inpLen.Size = new Size(182, 31);
            inpLen.TabIndex = 6;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.SteelBlue;
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(275, 352);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(290, 41);
            btnConfirm.TabIndex = 11;
            btnConfirm.Text = "Zatwierdź";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 412);
            Controls.Add(btnConfirm);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Dodaj pracownika 1234567890";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private TextBox inpLastName;
        private Label label1;
        private TextBox inpName;
        private ComboBox comboPosition;
        private Label label3;
        private Label label4;
        private TextBox inpLen;
        private CheckBox checkSpecial;
        private CheckBox checkNumbers;
        private CheckBox checkCase;
        private Button btnGenPass;
        private Button btnConfirm;
    }
}
