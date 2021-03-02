using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        float value1, value2, result;
        public Form1()
        {
            InitializeComponent();
        }

        private void Addition_CheckedChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, @"\d+") && Regex.IsMatch(textBox2.Text, @"\d+"))
            {
                value1 = float.Parse(textBox1.Text);
                value2 = float.Parse(textBox2.Text);
                result = value1 + value2;
                MessageBox.Show(result.ToString());
            }
            else
                MessageBox.Show("Invalid Inputs");
        }
        private void Subtraction_CheckedChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, @"\d+") && Regex.IsMatch(textBox2.Text, @"\d+"))
            {
                value1 = float.Parse(textBox1.Text);
                value2 = float.Parse(textBox2.Text);
                result = value1 - value2;
                MessageBox.Show(result.ToString());
            }
            else
                MessageBox.Show("Invalid Inputs");
        }

        private void Multiplication_CheckedChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, @"\d+") && Regex.IsMatch(textBox2.Text, @"\d+"))
            {
                value1 = float.Parse(textBox1.Text);
                value2 = float.Parse(textBox2.Text);
                result = value1 * value2;
                MessageBox.Show(result.ToString());
            }
            else
                MessageBox.Show("Invalid Inputs");
        }

        private void Division_CheckedChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, @"\d+") && Regex.IsMatch(textBox2.Text, @"[1-9]+"))
            {
                value1 = float.Parse(textBox1.Text);
                value2 = float.Parse(textBox2.Text);
                result = value1 / value2;
                MessageBox.Show(result.ToString());
            }
            else
                MessageBox.Show("Invalid Inputs");
        }
    }
}
