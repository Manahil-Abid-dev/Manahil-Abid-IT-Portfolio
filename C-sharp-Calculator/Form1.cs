using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double num1 = 0, num2 = 0;
        string op = "";

        public Form1()
        {
            InitializeComponent();
            txtDisplay.Text = "0";
        }
        private void button1_Click(object sender, EventArgs e) // 0
        {
            if (txtDisplay.Text == "0" || txtDisplay.Text == "")
                txtDisplay.Text = "0";
            else
                txtDisplay.Text += "0";
        }

        private void button2_Click(object sender, EventArgs e) // 1
        {
            if (txtDisplay.Text == "0" || txtDisplay.Text == "")
                txtDisplay.Text = "1";
            else
                txtDisplay.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e) // 2
        {
            if (txtDisplay.Text == "0" || txtDisplay.Text == "")
                txtDisplay.Text = "2";
            else
                txtDisplay.Text += "2";
        }

        private void button4_Click(object sender, EventArgs e) // 3
        {
            if (txtDisplay.Text == "0" || txtDisplay.Text == "")
                txtDisplay.Text = "3";
            else
                txtDisplay.Text += "3";
        }
        private void button5_Click(object sender, EventArgs e) // 4
        {
            if (txtDisplay.Text == "0" || txtDisplay.Text == "")
                txtDisplay.Text = "4";
            else
                txtDisplay.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e) // 5
        {
            if (txtDisplay.Text == "0" || txtDisplay.Text == "")
                txtDisplay.Text = "5";
            else
                txtDisplay.Text += "5";
        }
        private void button7_Click(object sender, EventArgs e) // 6
        {
            if (txtDisplay.Text == "0" || txtDisplay.Text == "")
                txtDisplay.Text = "6";
            else
                txtDisplay.Text += "6";
        }
        private void button8_Click(object sender, EventArgs e) // 7
        {
            if (txtDisplay.Text == "0" || txtDisplay.Text == "")
                txtDisplay.Text = "7";
            else
                txtDisplay.Text += "7";
        }

        private void button9_Click(object sender, EventArgs e) // 8
        {
            if (txtDisplay.Text == "0" || txtDisplay.Text == "")
                txtDisplay.Text = "8";
            else
                txtDisplay.Text += "8";
        }
        private void button10_Click(object sender, EventArgs e) // 9
        {
            if (txtDisplay.Text == "0" || txtDisplay.Text == "")
                txtDisplay.Text = "9";
            else
                txtDisplay.Text += "9";
        }
        private void ApplyPreviousOperation()
        {
            if (op == "" && txtDisplay.Text != "")
            {
                num1 = Convert.ToDouble(txtDisplay.Text);
                return;
            }
            if (op != "" && txtDisplay.Text != "")
            {
                num2 = Convert.ToDouble(txtDisplay.Text);

                if (op == "+") num1 += num2;
                else if (op == "-") num1 -= num2;
                else if (op == "*") num1 *= num2;
                else if (op == "/")
                {
                    if (num2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero");
                        return;
                    }
                    num1 /= num2;
                }
            }
        }
        private void button11_Click(object sender, EventArgs e) // +
        {
            ApplyPreviousOperation();
            op = "+";
            txtDisplay.Text = "";
        }

        private void button12_Click(object sender, EventArgs e) // -
        {
            ApplyPreviousOperation();
            op = "-";
            txtDisplay.Text = "";
        }

        private void button13_Click(object sender, EventArgs e) // *
        {
            ApplyPreviousOperation();
            op = "*";
            txtDisplay.Text = "";
        }

        private void button14_Click(object sender, EventArgs e) // /
        {
            ApplyPreviousOperation();
            op = "/";
            txtDisplay.Text = "";
        }
        private void button16_Click(object sender, EventArgs e) // =
        {
            ApplyPreviousOperation();
            txtDisplay.Text = num1.ToString();
            op = "";
        }
        private void button15_Click(object sender, EventArgs e) // C
        {
            txtDisplay.Text = "0";
            num1 = 0;
            num2 = 0;
            op = "";
        }
        private void button17_Click(object sender, EventArgs e) // .
        {
            if (txtDisplay.Text == "")
                txtDisplay.Text = "0.";
            else if (!txtDisplay.Text.Contains("."))
                txtDisplay.Text += ".";
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
