using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        bool firstNumber = true, sum_end = false;
        double num1, num2;
        char sing = ' ';

        private void Number_Click(string number)
        {
            if (firstNumber && sum_end)
            {
                Clear();
            }
                
            if (firstNumber)
            {
                label1.Text = "";
                label1.Text += number;
                firstNumber = false;
            }
            else
                label1.Text += number;
        }

        private void Operation(char sing)
        {
            if (this.sing == ' ')
            {
                num1 = Convert.ToDouble(label1.Text);
                this.sing = sing;
                label1.Text = "0";
                label2.Text += num1.ToString() + sing;
                firstNumber = true;
            }
        }

        private void Clear()
        {
            label1.Text = "0";
            label2.Text = "";
            firstNumber = true;
            sum_end = false;
            num1 = 0;
            num2 = 0;
            sing = ' ';
        }

        private void num_0_Click(object sender, EventArgs e)
        {
            Number_Click("0");
        }

        private void b_num_1_Click(object sender, EventArgs e)
        {
            Number_Click("1");
        }

        private void b_num_2_Click(object sender, EventArgs e)
        {
            Number_Click("2");
        }

        private void b_num_3_Click(object sender, EventArgs e)
        {
            Number_Click("3");
        }

        private void b_num_4_Click(object sender, EventArgs e)
        {
            Number_Click("4");
        }

        private void b_num_5_Click(object sender, EventArgs e)
        {
            Number_Click("5");
        }

        private void b_num_6_Click(object sender, EventArgs e)
        {
            Number_Click("6");
        }

        private void b_num_7_Click(object sender, EventArgs e)
        {
            Number_Click("7");
        }

        private void b_num_8_Click(object sender, EventArgs e)
        {
            Number_Click("8");
        }

        private void b_num_9_Click(object sender, EventArgs e)
        {
            Number_Click("9");
        }

        private void b_comma_Click(object sender, EventArgs e)
        {
            if (firstNumber)
                Number_Click("0,");
            else
                Number_Click(",");
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            Operation('+');
        }

        private void b_sub_Click(object sender, EventArgs e)
        {
            Operation('-');
        }

        private void b_multi_Click(object sender, EventArgs e)
        {
            Operation('*');
        }

        private void b_divi_Click(object sender, EventArgs e)
        {
            Operation('/');
        }

        private void b_C_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void b_plus_minus_Click(object sender, EventArgs e)
        {
            double temp = Convert.ToDouble(label1.Text);
            temp *= -1;
            label1.Text = temp.ToString();
        }

        private void b_CE_Click(object sender, EventArgs e)
        {
            if (!sum_end)
            {
                label1.Text = "0";
                firstNumber = true;
            }
        }

        private void b_sum_Click(object sender, EventArgs e)
        {
            sum_end = true;
            firstNumber = true;
            num2 = Convert.ToDouble(label1.Text);
            label2.Text += label1.Text + "=";
            switch (sing)
            {
                case '+':
                    num1 += num2;
                    break;
                case '-':
                    num1 -= num2;
                    break;
                case '*':
                    num1 *= num2;
                    break;
                case '/':
                    num1 /= num2;
                    break;
            }
            label1.Text = num1.ToString();
        }
    }
}
