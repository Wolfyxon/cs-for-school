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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            radioPostcard = new RadioButton();
            radioLetter = new RadioButton();
            radioPackage = new RadioButton();
            btnCheckPrice = new Button();
            pictureBox1 = new PictureBox();
            lblPrice = new Label();
            groupBox2 = new GroupBox();
            label1 = new Label();
            inpStreet = new TextBox();
            inpPostCode = new TextBox();
            label2 = new Label();
            inpCity = new TextBox();
            label3 = new Label();
            btnSubmit = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioPackage);
            groupBox1.Controls.Add(radioLetter);
            groupBox1.Controls.Add(radioPostcard);
            groupBox1.Location = new Point(12, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rodzaj przesyłki";
            // 
            // radioPostcard
            // 
            radioPostcard.AutoSize = true;
            radioPostcard.Location = new Point(6, 26);
            radioPostcard.Name = "radioPostcard";
            radioPostcard.Size = new Size(100, 24);
            radioPostcard.TabIndex = 0;
            radioPostcard.TabStop = true;
            radioPostcard.Text = "Pocztówka";
            radioPostcard.UseVisualStyleBackColor = true;
            // 
            // radioLetter
            // 
            radioLetter.AutoSize = true;
            radioLetter.Location = new Point(6, 56);
            radioLetter.Name = "radioLetter";
            radioLetter.Size = new Size(52, 24);
            radioLetter.TabIndex = 1;
            radioLetter.TabStop = true;
            radioLetter.Text = "List";
            radioLetter.UseVisualStyleBackColor = true;
            // 
            // radioPackage
            // 
            radioPackage.AutoSize = true;
            radioPackage.Location = new Point(6, 86);
            radioPackage.Name = "radioPackage";
            radioPackage.Size = new Size(74, 24);
            radioPackage.TabIndex = 2;
            radioPackage.TabStop = true;
            radioPackage.Text = "Paczka";
            radioPackage.UseVisualStyleBackColor = true;
            // 
            // btnCheckPrice
            // 
            btnCheckPrice.Location = new Point(12, 160);
            btnCheckPrice.Name = "btnCheckPrice";
            btnCheckPrice.Size = new Size(250, 29);
            btnCheckPrice.TabIndex = 1;
            btnCheckPrice.Text = "Sprawdź cenę";
            btnCheckPrice.UseVisualStyleBackColor = true;
            btnCheckPrice.Click += btnCheckPrice_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 206);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblPrice.Location = new Point(137, 221);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(167, 38);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Cena: 1.5 zł";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(inpCity);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(inpPostCode);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(inpStreet);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(352, 29);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(334, 230);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dane adresowe";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 0;
            label1.Text = "Ulica z numerem";
            // 
            // inpStreet
            // 
            inpStreet.Location = new Point(6, 53);
            inpStreet.Name = "inpStreet";
            inpStreet.Size = new Size(322, 27);
            inpStreet.TabIndex = 1;
            // 
            // inpPostCode
            // 
            inpPostCode.Location = new Point(6, 118);
            inpPostCode.Name = "inpPostCode";
            inpPostCode.Size = new Size(130, 27);
            inpPostCode.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 95);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 2;
            label2.Text = "Kod pocztowy";
            // 
            // inpCity
            // 
            inpCity.Location = new Point(6, 184);
            inpCity.Name = "inpCity";
            inpCity.Size = new Size(322, 27);
            inpCity.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 161);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 4;
            label3.Text = "Miasto";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(12, 315);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(674, 29);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Zatwierdź";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 362);
            Controls.Add(btnSubmit);
            Controls.Add(groupBox2);
            Controls.Add(lblPrice);
            Controls.Add(pictureBox1);
            Controls.Add(btnCheckPrice);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Nadaj przesyłkę. PESEL: 1234567890";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioPostcard;
        private RadioButton radioPackage;
        private RadioButton radioLetter;
        private Button btnCheckPrice;
        private PictureBox pictureBox1;
        private Label lblPrice;
        private GroupBox groupBox2;
        private TextBox inpCity;
        private Label label3;
        private TextBox inpPostCode;
        private Label label2;
        private TextBox inpStreet;
        private Label label1;
        private Button btnSubmit;
    }
}
