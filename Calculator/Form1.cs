using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form

    {
        private TextBox selectedTextBox;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            // 1. Convert 'string' to 'int'
            float num1 = float.Parse(textNumber1.Text);
            float num2 = float.Parse(textNumber2.Text);




            // 3.Perfurm calculaition
            switch (cmbOperator.Text)
            {
                case "+":
                    lblResult.Text = (num1 + num2).ToString(); ;
                    break;

                case "-":
                    lblResult.Text = (num1 - num2).ToString(); ;
                    break;
                case "*":
                    lblResult.Text = (num1 * num2).ToString(); ;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        lblResult.Text = (num1 / num2).ToString();
                    }
                    else
                    {
                        lblResult.Text = "It is impossible";
                    }
                    break;


            }

        }

        private void btnOperator_Click_global(object sender, EventArgs e)
        {
            cmbOperator.Text = ((Button)sender).Text;
        }

        private void btnNum_Click_global(object sender, EventArgs e)
        {
            selectedTextBox.Text += ((Button)sender).Text;
        }


        private void comboOperator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void textNumber1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNumber1_Enter(object sender, EventArgs e)
        {
            selectedTextBox = sender as TextBox;
        }

        private void textNumber2_Enter(object sender, EventArgs e)
        {
            selectedTextBox = sender as TextBox;
        }

        private void cmbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
