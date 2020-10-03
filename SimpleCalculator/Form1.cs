using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    
    public partial class Form1 : Form
    {
        Add delegatedAddition;
        Minus delegatedSubtraction;
        Multiply delegatedMultiplication;
        Divide delegatedDivision;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            delegatedAddition = new Add(Addition.getSum);
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);
            MessageBox.Show(delegatedAddition(num1, num2).ToString());
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            delegatedDivision = new Divide(Division.getQuotient);
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);
            MessageBox.Show(delegatedDivision(num1, num2).ToString());

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            delegatedSubtraction = new Minus(Subtraction.getDiff);
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);
            MessageBox.Show(delegatedSubtraction(num1, num2).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {

            delegatedMultiplication = new Multiply(Multiplication.getProduct);
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);
            MessageBox.Show(delegatedMultiplication(num1, num2).ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
