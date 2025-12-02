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
            textBox = new TextBox();
            num1 = new Button();
            num2 = new Button();
            num5 = new Button();
            num4 = new Button();
            num6 = new Button();
            num3 = new Button();
            num9 = new Button();
            num8 = new Button();
            num7 = new Button();
            num0 = new Button();
            btnAdd = new Button();
            btnSub = new Button();
            btnDiv = new Button();
            btnMul = new Button();
            btnEqual = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Enabled = false;
            textBox.Location = new Point(16, 12);
            textBox.Name = "textBox";
            textBox.Size = new Size(138, 23);
            textBox.TabIndex = 0;
            // 
            // num1
            // 
            num1.Location = new Point(16, 51);
            num1.Name = "num1";
            num1.Size = new Size(25, 23);
            num1.TabIndex = 1;
            num1.Text = "1";
            num1.UseVisualStyleBackColor = true;
            // 
            // num2
            // 
            num2.Location = new Point(47, 51);
            num2.Name = "num2";
            num2.Size = new Size(25, 23);
            num2.TabIndex = 2;
            num2.Text = "2";
            num2.UseVisualStyleBackColor = true;
            // 
            // num5
            // 
            num5.Location = new Point(47, 80);
            num5.Name = "num5";
            num5.Size = new Size(25, 23);
            num5.TabIndex = 4;
            num5.Text = "5";
            num5.UseVisualStyleBackColor = true;
            // 
            // num4
            // 
            num4.Location = new Point(16, 80);
            num4.Name = "num4";
            num4.Size = new Size(25, 23);
            num4.TabIndex = 3;
            num4.Text = "4";
            num4.UseVisualStyleBackColor = true;
            // 
            // num6
            // 
            num6.Location = new Point(78, 80);
            num6.Name = "num6";
            num6.Size = new Size(25, 23);
            num6.TabIndex = 6;
            num6.Text = "6";
            num6.UseVisualStyleBackColor = true;
            // 
            // num3
            // 
            num3.Location = new Point(78, 51);
            num3.Name = "num3";
            num3.Size = new Size(25, 23);
            num3.TabIndex = 5;
            num3.Text = "3";
            num3.UseVisualStyleBackColor = true;
            // 
            // num9
            // 
            num9.Location = new Point(78, 109);
            num9.Name = "num9";
            num9.Size = new Size(25, 23);
            num9.TabIndex = 9;
            num9.Text = "9";
            num9.UseVisualStyleBackColor = true;
            // 
            // num8
            // 
            num8.Location = new Point(47, 109);
            num8.Name = "num8";
            num8.Size = new Size(25, 23);
            num8.TabIndex = 8;
            num8.Text = "8";
            num8.UseVisualStyleBackColor = true;
            // 
            // num7
            // 
            num7.Location = new Point(16, 109);
            num7.Name = "num7";
            num7.Size = new Size(25, 23);
            num7.TabIndex = 7;
            num7.Text = "7";
            num7.UseVisualStyleBackColor = true;
            // 
            // num0
            // 
            num0.Location = new Point(47, 138);
            num0.Name = "num0";
            num0.Size = new Size(25, 23);
            num0.TabIndex = 10;
            num0.Text = "0";
            num0.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(129, 51);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(25, 23);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(129, 80);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(25, 23);
            btnSub.TabIndex = 12;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(129, 138);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(25, 23);
            btnDiv.TabIndex = 14;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            // 
            // btnMul
            // 
            btnMul.Location = new Point(129, 109);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(25, 23);
            btnMul.TabIndex = 13;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(78, 138);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(45, 23);
            btnEqual.TabIndex = 15;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(16, 138);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(25, 23);
            btnClear.TabIndex = 16;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(175, 173);
            Controls.Add(btnClear);
            Controls.Add(btnEqual);
            Controls.Add(btnDiv);
            Controls.Add(btnMul);
            Controls.Add(btnSub);
            Controls.Add(btnAdd);
            Controls.Add(num0);
            Controls.Add(num9);
            Controls.Add(num8);
            Controls.Add(num7);
            Controls.Add(num6);
            Controls.Add(num3);
            Controls.Add(num5);
            Controls.Add(num4);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(textBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private Button num1;
        private Button num2;
        private Button num5;
        private Button num4;
        private Button num6;
        private Button num3;
        private Button num9;
        private Button num8;
        private Button num7;
        private Button num0;
        private Button btnAdd;
        private Button btnSub;
        private Button btnDiv;
        private Button btnMul;
        private Button btnEqual;
        private Button btnClear;
    }
}
