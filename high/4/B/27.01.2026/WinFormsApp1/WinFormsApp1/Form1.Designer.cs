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
            sideAinp = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            sideBinp = new NumericUpDown();
            label3 = new Label();
            areaBox = new NumericUpDown();
            calcBtn = new Button();
            label4 = new Label();
            oblastBox = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)sideAinp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sideBinp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)areaBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)oblastBox).BeginInit();
            SuspendLayout();
            // 
            // sideAinp
            // 
            sideAinp.Location = new Point(12, 53);
            sideAinp.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            sideAinp.Name = "sideAinp";
            sideAinp.Size = new Size(150, 27);
            sideAinp.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 24);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 1;
            label1.Text = "Bok A:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 94);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "Bok B:";
            // 
            // sideBinp
            // 
            sideBinp.Location = new Point(11, 123);
            sideBinp.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            sideBinp.Name = "sideBinp";
            sideBinp.Size = new Size(150, 27);
            sideBinp.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 24);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 5;
            label3.Text = "Pole:";
            // 
            // areaBox
            // 
            areaBox.Location = new Point(204, 53);
            areaBox.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            areaBox.Name = "areaBox";
            areaBox.ReadOnly = true;
            areaBox.Size = new Size(150, 27);
            areaBox.TabIndex = 4;
            // 
            // calcBtn
            // 
            calcBtn.Location = new Point(10, 187);
            calcBtn.Name = "calcBtn";
            calcBtn.Size = new Size(344, 29);
            calcBtn.TabIndex = 6;
            calcBtn.Text = "Oblicz";
            calcBtn.UseVisualStyleBackColor = true;
            calcBtn.Click += calcBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(203, 94);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 8;
            label4.Text = "Obwód:";
            // 
            // oblastBox
            // 
            oblastBox.Location = new Point(204, 123);
            oblastBox.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            oblastBox.Name = "oblastBox";
            oblastBox.ReadOnly = true;
            oblastBox.Size = new Size(150, 27);
            oblastBox.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(oblastBox);
            Controls.Add(calcBtn);
            Controls.Add(label3);
            Controls.Add(areaBox);
            Controls.Add(label2);
            Controls.Add(sideBinp);
            Controls.Add(label1);
            Controls.Add(sideAinp);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)sideAinp).EndInit();
            ((System.ComponentModel.ISupportInitialize)sideBinp).EndInit();
            ((System.ComponentModel.ISupportInitialize)areaBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)oblastBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown sideAinp;
        private Label label1;
        private Label label2;
        private NumericUpDown sideBinp;
        private Label label3;
        private NumericUpDown areaBox;
        private Button calcBtn;
        private Label label4;
        private NumericUpDown oblastBox;
    }
}
