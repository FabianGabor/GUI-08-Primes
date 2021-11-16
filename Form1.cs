using System;
using System.Collections;
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

        private bool IsPrime(int n)
        {
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                if (n % i == 0) return false;
            }

            return true;
        }

        private ArrayList CalculatePrimes(int n)
        {
            ArrayList primes = new ArrayList();
            for (var i = 3; i <= n; i+=2)
            {
                if (IsPrime(i)) primes.Add(i);
            }

            return primes;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                _input = int.Parse(textBoxInputFactorial.Text);
                foreach (var n in CalculatePrimes(_input))
                {
                    textBoxResult.Text += n + " ";
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Enter a positive integer!");
            }
        }
    }
}