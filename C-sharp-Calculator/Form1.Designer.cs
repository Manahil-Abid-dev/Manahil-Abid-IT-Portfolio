namespace Calculator
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
            txtDisplay = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = Color.Black;
            txtDisplay.BorderStyle = BorderStyle.FixedSingle;
            txtDisplay.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDisplay.ForeColor = Color.Cyan;
            txtDisplay.Location = new Point(67, 40);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(340, 70);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.TextChanged += txtDisplay_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(45, 45, 68);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(147, 414);
            button1.Name = "button1";
            button1.Size = new Size(65, 55);
            button1.TabIndex = 1;
            button1.Text = "0";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(45, 45, 68);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(59, 321);
            button2.Name = "button2";
            button2.Size = new Size(65, 55);
            button2.TabIndex = 2;
            button2.Text = "1";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(45, 45, 68);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(147, 321);
            button3.Name = "button3";
            button3.Size = new Size(65, 55);
            button3.TabIndex = 3;
            button3.Text = "2";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(45, 45, 68);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(246, 321);
            button4.Name = "button4";
            button4.Size = new Size(65, 55);
            button4.TabIndex = 4;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(45, 45, 68);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(59, 226);
            button5.Name = "button5";
            button5.Size = new Size(65, 55);
            button5.TabIndex = 5;
            button5.Text = "4";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(45, 45, 68);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(147, 226);
            button6.Name = "button6";
            button6.Size = new Size(65, 55);
            button6.TabIndex = 6;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(45, 45, 68);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Location = new Point(250, 226);
            button7.Name = "button7";
            button7.Size = new Size(65, 55);
            button7.TabIndex = 7;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(45, 45, 68);
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.White;
            button8.Location = new Point(59, 142);
            button8.Name = "button8";
            button8.Size = new Size(65, 55);
            button8.TabIndex = 8;
            button8.Text = "7";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(45, 45, 68);
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.White;
            button9.Location = new Point(147, 142);
            button9.Name = "button9";
            button9.Size = new Size(65, 55);
            button9.TabIndex = 9;
            button9.Text = "8";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(45, 45, 68);
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.White;
            button10.Location = new Point(250, 142);
            button10.Name = "button10";
            button10.Size = new Size(65, 55);
            button10.TabIndex = 10;
            button10.Text = "9";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(59, 130, 246);
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.ForeColor = Color.White;
            button11.Location = new Point(342, 414);
            button11.Name = "button11";
            button11.Size = new Size(65, 55);
            button11.TabIndex = 11;
            button11.Text = "+";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(59, 130, 246);
            button12.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.ForeColor = Color.White;
            button12.Location = new Point(342, 321);
            button12.Name = "button12";
            button12.Size = new Size(65, 55);
            button12.TabIndex = 12;
            button12.Text = "-";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(59, 130, 246);
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button13.ForeColor = Color.White;
            button13.Location = new Point(342, 226);
            button13.Name = "button13";
            button13.Size = new Size(65, 55);
            button13.TabIndex = 13;
            button13.Text = "*";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.FromArgb(59, 130, 246);
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button14.ForeColor = Color.White;
            button14.Location = new Point(342, 142);
            button14.Name = "button14";
            button14.Size = new Size(65, 55);
            button14.TabIndex = 14;
            button14.Text = "/";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.DarkRed;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button15.Location = new Point(59, 414);
            button15.Name = "button15";
            button15.Size = new Size(65, 55);
            button15.TabIndex = 15;
            button15.Text = "C";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.FromArgb(37, 99, 235);
            button16.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button16.ForeColor = Color.White;
            button16.Location = new Point(94, 483);
            button16.Name = "button16";
            button16.Size = new Size(244, 55);
            button16.TabIndex = 16;
            button16.Text = "=";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.FromArgb(45, 45, 68);
            button17.FlatStyle = FlatStyle.Flat;
            button17.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button17.ForeColor = Color.White;
            button17.Location = new Point(246, 414);
            button17.Name = "button17";
            button17.Size = new Size(65, 55);
            button17.TabIndex = 17;
            button17.Text = ".";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 47);
            ClientSize = new Size(435, 550);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtDisplay);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
    }
}
