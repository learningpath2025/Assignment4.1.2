using Assignment4._1._2.Interface;
using Assignment4._1._2.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4._1._2
{
    public partial class Form1 : Form
    {
        private ICalculator calculator;
        public Form1()
        {
            InitializeComponent();
            calculator = new CalcMethods();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PerformCalculation(calculator.Add);
        }
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            PerformCalculation(calculator.Subtract);
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            PerformCalculation(calculator.Divide);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            PerformCalculation(calculator.Multiply);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum1?.Clear();
            txtNum2?.Clear();
            txtResult.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PerformCalculation(Func<double, double, double> operation)
        {
            if (double.TryParse(txtNum1.Text, out double firstNumber) && double.TryParse(txtNum2.Text, out double secondNumber))
            {
                try
                {
                    txtResult.Text = operation(firstNumber, secondNumber).ToString();
                }
                catch (DivideByZeroException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtResult.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtResult.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter valid numbers in both fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtResult.Clear();
            }
        }
        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
