using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public const string NAN = "NaN";
        double PrevNumber;
        string Operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void num1_Click(object sender, EventArgs e)
        {
            if (isCalcInputValid())
            {
                textBox1.Text = textBox1.Text + "1";
            }
            else
            {
                textBox1.Text = "1";
            }
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (isCalcInputValid())
            {
                textBox1.Text = textBox1.Text + "2";
            }
            else
            {
                textBox1.Text = "2";
            }
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (isCalcInputValid())
            {
                textBox1.Text = textBox1.Text + "3";
            }
            else
            {
                textBox1.Text = "3";
            }
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == null || textBox1.Text != "0") && textBox1.Text != NAN)
            {
                textBox1.Text = textBox1.Text + "4";
            }
            else
            {
                textBox1.Text = "4";
            }
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (isCalcInputValid())
            {
                textBox1.Text = textBox1.Text + "5";
            }
            else
            {
                textBox1.Text = "5";
            }
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (isCalcInputValid())
            {
                textBox1.Text = textBox1.Text + "6";
            }
            else
            {
                textBox1.Text = "6";
            }
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (isCalcInputValid())
            {
                textBox1.Text = textBox1.Text + "7";
            }
            else
            {
                textBox1.Text = "7";
            }
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (isCalcInputValid())
            {
                textBox1.Text = textBox1.Text + "8";
            }
            else
            {
                textBox1.Text = "8";
            }
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (isCalcInputValid())
            {
                textBox1.Text = textBox1.Text + "9";
            }
            else
            {
                textBox1.Text = "9";
            }
        }

        private void num0_Click(object sender, EventArgs e)
        {
            if (isCalcInputValid())
            {
                textBox1.Text = textBox1.Text + "0";
            }
            else
            {
                textBox1.Text = "0";
            }
        }

        private bool isCalcInputValid() {
            return (textBox1.Text == null || textBox1.Text != "0") && textBox1.Text != NAN;
        }

        private void clear_entry_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            string Input = textBox1.Text;
            if (Input != NAN)
            {
                PrevNumber = Convert.ToDouble(Input.Replace(".", ","));
                Operation = "+";
                textBox1.Text = "0";
            }
            
        }

        private void minus_Click(object sender, EventArgs e)
        {
            string Input = textBox1.Text;
            if (Input != NAN)
            {
                PrevNumber = Convert.ToDouble(Input.Replace(".", ","));
                Operation = "-";
                textBox1.Text = "0";
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            string Input = textBox1.Text;
            if (Input != NAN)
            {
                PrevNumber = Convert.ToDouble(Input.Replace(".", ","));
                Operation = "*";
                textBox1.Text = "0";
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            string Input = textBox1.Text;
            if (Input != NAN)
            {
                PrevNumber = Convert.ToDouble(Input.Replace(".", ","));
                Operation = "/";
                textBox1.Text = "0";
            }
        }

        private void point_Click(object sender, EventArgs e)
        {
            string Input = textBox1.Text;
            if (Input == NAN) {
                textBox1.Text = "0.";
                return;
            }

            if (textBox1.Text != null)
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {
            double CurrentNumber = Convert.ToDouble(textBox1.Text.Replace(".", ","));
            double Result;

            switch (Operation) {
                case "+":
                    Result = PrevNumber + CurrentNumber;
                    break;
                case "-":
                    Result = PrevNumber - CurrentNumber;
                    break;
                case "*":
                    Result = PrevNumber * CurrentNumber;
                    break;
                case "/":
                    if (CurrentNumber == 0) {
                        textBox1.Text = NAN;
                        PrevNumber = 0;
                        return;
                    }
                    Result = PrevNumber / CurrentNumber;
                    break;
                default:
                    throw new ArgumentException($"Unknown operation {Operation}");
            }

            textBox1.Text = Convert.ToString(Result).Replace(",", ".");
            Clipboard.SetText(textBox1.Text);
            PrevNumber = Result;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
