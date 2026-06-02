namespace inf04_02_24._06_SG
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
            btnPrev = new Button();
            btnNext = new Button();
            pictureBox1 = new PictureBox();
            lblAuthor = new Label();
            lblTitle = new Label();
            lblTrackCount = new Label();
            lblYear = new Label();
            lblDownloads = new Label();
            btnDownload = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnPrev
            // 
            btnPrev.BackgroundImage = Properties.Resources.obraz3;
            btnPrev.BackgroundImageLayout = ImageLayout.Stretch;
            btnPrev.Location = new Point(31, 158);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(101, 70);
            btnPrev.TabIndex = 0;
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.BackgroundImage = Properties.Resources.obraz2;
            btnNext.BackgroundImageLayout = ImageLayout.Stretch;
            btnNext.Location = new Point(1404, 158);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(102, 70);
            btnNext.TabIndex = 1;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.obraz;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(183, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 288);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblAuthor.ForeColor = SystemColors.Control;
            lblAuthor.Location = new Point(445, 25);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(364, 133);
            lblAuthor.TabIndex = 3;
            lblAuthor.Text = "Author";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 30F, FontStyle.Italic, GraphicsUnit.Point, 238);
            lblTitle.ForeColor = SystemColors.Control;
            lblTitle.Location = new Point(445, 158);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(413, 81);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "\"Album name\"";
            // 
            // lblTrackCount
            // 
            lblTrackCount.AutoSize = true;
            lblTrackCount.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblTrackCount.ForeColor = Color.FromArgb(97, 217, 24);
            lblTrackCount.Location = new Point(445, 262);
            lblTrackCount.Name = "lblTrackCount";
            lblTrackCount.Size = new Size(213, 54);
            lblTrackCount.TabIndex = 5;
            lblTrackCount.Text = "X utworów";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblYear.ForeColor = Color.FromArgb(97, 217, 24);
            lblYear.Location = new Point(692, 262);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(111, 54);
            lblYear.TabIndex = 6;
            lblYear.Text = "YYYY";
            // 
            // lblDownloads
            // 
            lblDownloads.AutoSize = true;
            lblDownloads.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblDownloads.ForeColor = Color.FromArgb(97, 217, 24);
            lblDownloads.Location = new Point(183, 369);
            lblDownloads.Name = "lblDownloads";
            lblDownloads.Size = new Size(216, 54);
            lblDownloads.TabIndex = 7;
            lblDownloads.Text = "downloads";
            // 
            // btnDownload
            // 
            btnDownload.BackColor = Color.FromArgb(97, 217, 24);
            btnDownload.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnDownload.Location = new Point(445, 364);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(176, 65);
            btnDownload.TabIndex = 8;
            btnDownload.Text = "Pobierz";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1531, 446);
            Controls.Add(btnDownload);
            Controls.Add(lblDownloads);
            Controls.Add(lblYear);
            Controls.Add(lblTrackCount);
            Controls.Add(lblTitle);
            Controls.Add(lblAuthor);
            Controls.Add(pictureBox1);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Name = "Form1";
            Text = "MojeDźwięki, wykonał: 1234567890";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPrev;
        private Button btnNext;
        private PictureBox pictureBox1;
        private Label lblAuthor;
        private Label lblTitle;
        private Label lblTrackCount;
        private Label lblYear;
        private Label lblDownloads;
        private Button btnDownload;
    }
}
