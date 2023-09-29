using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            display.Text = display.Text+ "9";
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "8";
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "7";
        }

        private void Six_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "6";
        }

        private void Five_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "5";
        }

        private void Four_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "4";
        }

        private void Three_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "3";
        }

        private void Two_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "2";
        }

        private void One_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "1";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "-";
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "×";
        }

        private void division_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "÷";
        }

        private void Equal_Click(object sender, EventArgs e)
        {


            int operand = 0;
            string num = "";
            char opt='0'; 
            int temp = 0;

            string expression = display.Text + "/"; 
            
            for(int i = 0; i < expression.Length; i++)
            {
                num += expression[i];

                if (expression[i] == '+' || expression[i] == '-' || expression[i] == '×' || expression[i] == '÷' || expression[i] == '/')
                {
                    operand = Int32.Parse(num.Substring(0, num.Length - 1));

                    if (opt == '0')
                    {
                        opt = display.Text[i];
                    }
                    else
                    {
                        if (opt == '+')
                            operand = temp + operand;

                        else if (opt == '-')
                            operand = temp - operand;

                        else if (opt == '×')
                            operand = temp * operand;

                        else if (opt == '÷')
                            operand = temp / operand;

                        opt = expression[i];


                    }

                    temp = operand;
                    operand = 0;
                    num = "";
                }

            }


            display.Text = temp.ToString();

            
               
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            display.Clear();
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "0";
        }
    }
}
