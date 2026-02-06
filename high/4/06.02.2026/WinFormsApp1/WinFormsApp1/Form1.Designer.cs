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
            label1 = new Label();
            inpNumber = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            inpName = new MaskedTextBox();
            label2 = new Label();
            inpSurname = new MaskedTextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            radioBeer = new RadioButton();
            radioGreen = new RadioButton();
            radioBlue = new RadioButton();
            btnSubmit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 40);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Numer";
            // 
            // inpNumber
            // 
            inpNumber.Location = new Point(147, 40);
            inpNumber.Name = "inpNumber";
            inpNumber.Size = new Size(249, 27);
            inpNumber.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(637, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 180);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(447, 40);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(147, 180);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // inpName
            // 
            inpName.Location = new Point(147, 82);
            inpName.Name = "inpName";
            inpName.Size = new Size(249, 27);
            inpName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 82);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 4;
            label2.Text = "Imię";
            // 
            // inpSurname
            // 
            inpSurname.Location = new Point(147, 124);
            inpSurname.Name = "inpSurname";
            inpSurname.Size = new Size(249, 27);
            inpSurname.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 124);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 6;
            label3.Text = "Nazwisko";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioBeer);
            groupBox1.Controls.Add(radioGreen);
            groupBox1.Controls.Add(radioBlue);
            groupBox1.Location = new Point(28, 171);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 125);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kolor oczu";
            // 
            // radioBeer
            // 
            radioBeer.AutoSize = true;
            radioBeer.Location = new Point(21, 86);
            radioBeer.Name = "radioBeer";
            radioBeer.Size = new Size(70, 24);
            radioBeer.TabIndex = 2;
            radioBeer.Text = "piwne";
            radioBeer.UseVisualStyleBackColor = true;
            // 
            // radioGreen
            // 
            radioGreen.AutoSize = true;
            radioGreen.Location = new Point(21, 56);
            radioGreen.Name = "radioGreen";
            radioGreen.Size = new Size(78, 24);
            radioGreen.TabIndex = 1;
            radioGreen.Text = "zielone";
            radioGreen.UseVisualStyleBackColor = true;
            // 
            // radioBlue
            // 
            radioBlue.AutoSize = true;
            radioBlue.Checked = true;
            radioBlue.Location = new Point(21, 26);
            radioBlue.Name = "radioBlue";
            radioBlue.Size = new Size(96, 24);
            radioBlue.TabIndex = 0;
            radioBlue.TabStop = true;
            radioBlue.Text = "niebieskie";
            radioBlue.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(536, 246);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(167, 46);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "OK";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(800, 323);
            Controls.Add(btnSubmit);
            Controls.Add(groupBox1);
            Controls.Add(inpSurname);
            Controls.Add(label3);
            Controls.Add(inpName);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(inpNumber);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Wprowadzanie danych do paszportu. Wykonał: 1234567890";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox inpNumber;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private MaskedTextBox inpName;
        private Label label2;
        private MaskedTextBox inpSurname;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton radioBlue;
        private RadioButton radioBeer;
        private RadioButton radioGreen;
        private Button btnSubmit;
    }
}
