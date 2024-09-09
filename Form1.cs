using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO4_CALCULADORA1
{
    public partial class Form1 : Form
    {
        private double value1;
        private double value2;
        private double result;
        private int operation;

        public Form1()
        {
            InitializeComponent();
        }
        private void addNumber(string number)
        {
            if (txtOutput.Text == "0" && number != ".")
            {
                txtOutput.Text = number;
            }
            else
            {
                txtOutput.Text += number;
            }
        }
        private void btnErase_Click(object sender, EventArgs e)
        {
            if(txtOutput.TextLength > 1)
            {
                txtOutput.Text = txtOutput.Text.Substring(0, txtOutput.TextLength - 1);
            }
            else
            {
                txtOutput.Text = "0";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            value1 = 0;
            value2 = 0;
            txtOutput.Text = "0";
            operation = 0;

        }

        private void btnClearError_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "0";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            addNumber("1");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            addNumber("2");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            addNumber("3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            addNumber("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            addNumber("5");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            addNumber("6");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            addNumber("7");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            addNumber("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            addNumber("9");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            addNumber("0");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            value2 = Convert.ToDouble(txtOutput.Text);
            switch (operation)
            {
                case 1:
                    result = value1 + value2;
                    value1 = result;
                    break;
                case 2:
                    result = value1 - value2;
                    value1 = result;
                    break;
                case 3:
                    result = value1 * value2;
                    value1 = result;
                    break;
                case 4:
                    if(value2 != 0)
                    {
                        result = value1 / value2;
                        value1 = result;
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir entre cero");
                        return;
                    }
                    break;
            }
            txtOutput.Text = result.ToString();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            operation = 1;
            value1 = Convert.ToDouble(txtOutput.Text);
            txtOutput.Text = "";
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            operation = 2;
            value1 = Convert.ToDouble(txtOutput.Text);
            txtOutput.Text = "";
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            operation = 3;
            value1 = Convert.ToDouble(txtOutput.Text);
            txtOutput.Text = "";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operation = 4;
            value1 = Convert.ToDouble(txtOutput.Text);
            txtOutput.Text = "";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (!txtOutput.Text.Contains("."))
            {
                txtOutput.Text += ".";
            }
        }

        private void btnPercentege_Click(object sender, EventArgs e)
        {
            double currentValue = Convert.ToDouble(txtOutput.Text);
            currentValue = currentValue / 100;
            txtOutput.Text = currentValue.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
