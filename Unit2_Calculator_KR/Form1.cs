using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit2_Calculator_KR
{
    public partial class Calculator : Form
    {
        int total = 0;
        char prevOperation = ' ';
        int plus_Click = 0;
        int subtract_Click = 0;
        int times_Click = 0;
        int fractunate_Click = 0;
        int result_Click = 0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculate()
        {
            if (prevOperation == ' ')
            {
                total = Convert.ToInt32(lblDisplay.Text);
                lblDisplay.Text = "0";

            }
            else
            {
                if (prevOperation == '+')
                {
                    total = total + Convert.ToInt32(lblDisplay.Text);
                    lblDisplay.Text = "0";

                }
                if (prevOperation == '-')
                {
                    total = total - Convert.ToInt32(lblDisplay.Text);
                    lblDisplay.Text = "0";

                }
                if (prevOperation == '*')
                {
                    total = total * Convert.ToInt32(lblDisplay.Text);
                    lblDisplay.Text = "0";

                }
                if (prevOperation == '/')
                {
                    total = total / Convert.ToInt32(lblDisplay.Text);
                    lblDisplay.Text = "0";

                }
            }

            if (plus_Click == 1)
            {
                prevOperation = '+';
                plus_Click = 0;
            }
            else if (subtract_Click == 1)
            {
                prevOperation = '-';
                subtract_Click = 0;
            }
            else if (times_Click == 1)
            {
                prevOperation = '*';
                times_Click = 0;
            }
            else if (fractunate_Click == 1)
            {
                prevOperation = '/';
                fractunate_Click = 0;
            }
            else
            {
                prevOperation = ' ';
                result_Click = 0;
                lblDisplay.Text = Convert.ToString(total);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            total = 0;
            prevOperation = ' ';
            plus_Click = 0;
            subtract_Click = 0;
            times_Click = 0;
            fractunate_Click = 0;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "0";
            else
                lblDisplay.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "1";
            else
                lblDisplay.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "2";
            else
                lblDisplay.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "3";
            else
                lblDisplay.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "4";
            else
                lblDisplay.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "5";
            else
                lblDisplay.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "6";
            else
                lblDisplay.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "7";
            else
                lblDisplay.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "8";
            else
                lblDisplay.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "9";
            else
                lblDisplay.Text += "9";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            fractunate_Click = 1;
            calculate();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            times_Click = 1;
            calculate();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            subtract_Click = 1;
            calculate();
        }

        private void add_Click(object sender, EventArgs e)
        {
            plus_Click = 1;
            calculate();
        }

        private void equal_Click(object sender, EventArgs e)
        {
            result_Click = 1;
            calculate();
        }
    }
}
