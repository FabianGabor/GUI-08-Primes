using System;
using System.Windows.Forms;

namespace GUI_08_Factorial
{
    public partial class Form1 : Form
    {
        private int _input;
        public Form1()
        {
            InitializeComponent();
        }

        private int calculatePrimes(int n)
        {
            var fact = 1;
            for (var i = 2; i <= n; i++)
            {
                fact *= i;
            }

            return fact;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                _input = int.Parse(textBoxInputFactorial.Text);
                labelResult.Text = calculatePrimes(_input).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Enter a positive integer!");
            }
        }
    }
}