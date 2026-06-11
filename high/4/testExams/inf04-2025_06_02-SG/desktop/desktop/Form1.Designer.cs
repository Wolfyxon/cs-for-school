namespace desktop
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            inpText = new TextBox();
            inpKey = new TextBox();
            btnEncrypt = new Button();
            btnSave = new Button();
            lblEncrypted = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.FromArgb(15, 250, 235, 215);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(272, 38);
            label1.TabIndex = 0;
            label1.Text = "Podaj wartość klucza";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.FromArgb(15, 250, 235, 215);
            label2.Location = new Point(568, 23);
            label2.Name = "label2";
            label2.Size = new Size(252, 38);
            label2.TabIndex = 1;
            label2.Text = "Tekst zaszyfrowany";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.FromArgb(15, 250, 235, 215);
            label3.Location = new Point(12, 157);
            label3.Name = "label3";
            label3.Size = new Size(152, 38);
            label3.TabIndex = 2;
            label3.Text = "Podaj tekst";
            // 
            // inpText
            // 
            inpText.Location = new Point(12, 223);
            inpText.Multiline = true;
            inpText.Name = "inpText";
            inpText.Size = new Size(405, 305);
            inpText.TabIndex = 3;
            // 
            // inpKey
            // 
            inpKey.Location = new Point(174, 97);
            inpKey.Name = "inpKey";
            inpKey.Size = new Size(86, 31);
            inpKey.TabIndex = 4;
            // 
            // btnEncrypt
            // 
            btnEncrypt.BackColor = Color.LightBlue;
            btnEncrypt.Location = new Point(447, 360);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(92, 47);
            btnEncrypt.TabIndex = 5;
            btnEncrypt.Text = "Zaszyfruj";
            btnEncrypt.UseVisualStyleBackColor = false;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightBlue;
            btnSave.Location = new Point(623, 485);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(263, 47);
            btnSave.TabIndex = 6;
            btnSave.Text = "Zapisz szyfr w pliku";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblEncrypted
            // 
            lblEncrypted.BackColor = Color.CadetBlue;
            lblEncrypted.BorderStyle = BorderStyle.None;
            lblEncrypted.ForeColor = Color.AliceBlue;
            lblEncrypted.Location = new Point(601, 97);
            lblEncrypted.Multiline = true;
            lblEncrypted.Name = "lblEncrypted";
            lblEncrypted.Size = new Size(317, 353);
            lblEncrypted.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(568, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(381, 384);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1001, 544);
            Controls.Add(lblEncrypted);
            Controls.Add(pictureBox1);
            Controls.Add(btnSave);
            Controls.Add(btnEncrypt);
            Controls.Add(inpKey);
            Controls.Add(inpText);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Szyfrowanie. Wykonane przez 1234567890";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox inpText;
        private TextBox inpKey;
        private Button btnEncrypt;
        private Button btnSave;
        private TextBox lblEncrypted;
        private PictureBox pictureBox1;
    }
}
