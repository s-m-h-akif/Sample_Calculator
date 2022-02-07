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

        private void add_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != " " && textBox2.Text != "")
            {
                int num1 = Convert.ToInt32(textBox1.Text);
                int num2 = Convert.ToInt32(textBox2.Text);

                int res = num1 + num2;
                MessageBox.Show("The result is " + res);
            }
            else
            {
                MessageBox.Show("Please Enter Both the values ");
            }
        }

        private void sub_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != " " && textBox2.Text != "")
            {
                int num1 = Convert.ToInt32(textBox1.Text);
                int num2 = Convert.ToInt32(textBox2.Text);

                int res = num1 - num2;
                MessageBox.Show("The result is " + res);
            }
            else
            {
                MessageBox.Show("Please Enter Both the values ");
            }
        }

        private void mul_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != " " && textBox2.Text != "")
            {
                int num1 = Convert.ToInt32(textBox1.Text);
                int num2 = Convert.ToInt32(textBox2.Text);

                int res = num1 * num2;
                MessageBox.Show("The result is " + res);
            }
            else
            {
                MessageBox.Show("Please Enter Both the values ");
            }
        }

        private void div_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != " " && textBox2.Text != "")
            {
                int num1 = Convert.ToInt32(textBox1.Text);
                int num2 = Convert.ToInt32(textBox2.Text);

                int res = num1 / num2;
                MessageBox.Show("The result is " + res);
            }
            else
            {
                MessageBox.Show("Please Enter Both the values ");
            }
        }
    }
}
