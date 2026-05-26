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
            colorPanel = new Panel();
            label1 = new Label();
            sliderR = new TrackBar();
            label2 = new Label();
            valueR = new Label();
            valueG = new Label();
            label5 = new Label();
            sliderG = new TrackBar();
            valueB = new Label();
            label7 = new Label();
            sliderB = new TrackBar();
            btnGet = new Button();
            colorText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)sliderR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sliderG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sliderB).BeginInit();
            SuspendLayout();
            // 
            // colorPanel
            // 
            colorPanel.BackColor = Color.White;
            colorPanel.Location = new Point(12, 12);
            colorPanel.Name = "colorPanel";
            colorPanel.Size = new Size(776, 91);
            colorPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 148);
            label1.Name = "label1";
            label1.Size = new Size(303, 20);
            label1.TabIndex = 1;
            label1.Text = "Dobierz kolor suwakami i zapisz przyciskiem";
            // 
            // sliderR
            // 
            sliderR.Location = new Point(45, 185);
            sliderR.Maximum = 255;
            sliderR.Name = "sliderR";
            sliderR.Size = new Size(704, 56);
            sliderR.TabIndex = 2;
            sliderR.TickStyle = TickStyle.None;
            sliderR.Value = 255;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 185);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 3;
            label2.Text = "R";
            // 
            // valueR
            // 
            valueR.AutoSize = true;
            valueR.Location = new Point(755, 185);
            valueR.Name = "valueR";
            valueR.Size = new Size(33, 20);
            valueR.TabIndex = 4;
            valueR.Text = "255";
            // 
            // valueG
            // 
            valueG.AutoSize = true;
            valueG.Location = new Point(755, 234);
            valueG.Name = "valueG";
            valueG.Size = new Size(33, 20);
            valueG.TabIndex = 7;
            valueG.Text = "255";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 234);
            label5.Name = "label5";
            label5.Size = new Size(19, 20);
            label5.TabIndex = 6;
            label5.Text = "G";
            // 
            // sliderG
            // 
            sliderG.Location = new Point(45, 234);
            sliderG.Maximum = 255;
            sliderG.Name = "sliderG";
            sliderG.Size = new Size(704, 56);
            sliderG.TabIndex = 5;
            sliderG.TickStyle = TickStyle.None;
            sliderG.Value = 255;
            // 
            // valueB
            // 
            valueB.AutoSize = true;
            valueB.Location = new Point(755, 291);
            valueB.Name = "valueB";
            valueB.Size = new Size(33, 20);
            valueB.TabIndex = 10;
            valueB.Text = "255";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 291);
            label7.Name = "label7";
            label7.Size = new Size(18, 20);
            label7.TabIndex = 9;
            label7.Text = "B";
            // 
            // sliderB
            // 
            sliderB.Location = new Point(45, 291);
            sliderB.Maximum = 255;
            sliderB.Name = "sliderB";
            sliderB.Size = new Size(704, 56);
            sliderB.TabIndex = 8;
            sliderB.TickStyle = TickStyle.None;
            sliderB.Value = 255;
            // 
            // btnGet
            // 
            btnGet.BackColor = Color.Peru;
            btnGet.Location = new Point(313, 353);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(175, 36);
            btnGet.TabIndex = 11;
            btnGet.Text = "Pobierz";
            btnGet.UseVisualStyleBackColor = false;
            btnGet.Click += btnGet_Click;
            // 
            // colorText
            // 
            colorText.Location = new Point(316, 407);
            colorText.Name = "colorText";
            colorText.Size = new Size(172, 27);
            colorText.TabIndex = 12;
            colorText.Text = "255, 255, 255";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(800, 450);
            Controls.Add(colorText);
            Controls.Add(btnGet);
            Controls.Add(valueB);
            Controls.Add(label7);
            Controls.Add(sliderB);
            Controls.Add(valueG);
            Controls.Add(label5);
            Controls.Add(sliderG);
            Controls.Add(valueR);
            Controls.Add(label2);
            Controls.Add(sliderR);
            Controls.Add(label1);
            Controls.Add(colorPanel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)sliderR).EndInit();
            ((System.ComponentModel.ISupportInitialize)sliderG).EndInit();
            ((System.ComponentModel.ISupportInitialize)sliderB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel colorPanel;
        private Label label1;
        private TrackBar sliderR;
        private Label label2;
        private Label valueR;
        private Label valueG;
        private Label label5;
        private TrackBar sliderG;
        private Label valueB;
        private Label label7;
        private TrackBar sliderB;
        private Button btnGet;
        private TextBox colorText;
    }
}
