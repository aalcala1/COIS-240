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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// Tienes que arregrar esos errores. son de curly brackets
        /// 
        /// namespace calculator
{
    public partial class Calculator : Form
        {

            double firstNumber, secondNumber, total;
            string comand; // if is multiplication, division, etc.


            public Calculator()
            {
                InitializeComponent();
            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }
            #region botones numericos

            private void btn1_Click(object sender, EventArgs e)
            {
                lblDesplegar.Text += "1";
            }

            private void btn2_Click(object sender, EventArgs e)
            {
                lblDesplegar.Text += "2";
            }

            private void btn3_Click(object sender, EventArgs e)
            {
                lblDesplegar.Text += "3";
            }

            private void btn4_Click(object sender, EventArgs e)
            {
                lblDesplegar.Text += "4";
            }

            private void btn5_Click(object sender, EventArgs e)
            {
                lblDesplegar.Text += "5";
            }

            private void btn6_Click(object sender, EventArgs e)
            {
                lblDesplegar.Text += "6";
            }

            private void btn7_Click(object sender, EventArgs e)
            {
                lblDesplegar.Text += "7";
            }

            private void btn8_Click(object sender, EventArgs e)
            {
                lblDesplegar.Text += "8";
            }

            private void btn9_Click(object sender, EventArgs e)
            {
                lblDesplegar.Text += "9";
            }

            private void button8_Click(object sender, EventArgs e)
            {
                lblDesplegar.Text += "*";
            }

            private void btn0_Click(object sender, EventArgs e)
            {
                lblDesplegar.Text += "0";
            }

            private void button2_Click(object sender, EventArgs e)
            /// calcula.
            {
                // si el tipo de calculo, comand, es multiply
                if (comand == "multiply")
                {
                    secondNumber = Convert.ToDouble(lblDesplegar.Text);
                    total = firstNumber * secondNumber;
                    lblDesplegar.Text = total.ToString();
                }
            }

            private void button3_Click(object sender, EventArgs e)
            {
                if (comand == "add")
                {
                    firstNumber = Convert.ToDouble(lblDesplegar.Text);
                    lblDesplegar.Text = "";
                    comand = "add";
                }
            }

            private void button11_Click(object sender, EventArgs e)
            {
                lblDesplegar.Text += "#";
            }
            #endregion


            private void button1_Click(object sender, EventArgs e)
            {
                firstNumber = Convert.ToDouble(lblDesplegar.Text);
                lblDesplegar.Text = "";
                comand = "multiply";
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
            private void btn1_Click(object sender, EventArgs e)
        {
            lblDesplegar.Text += "1";
           
        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }
    }
    }

}
