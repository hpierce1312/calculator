//BUS 442 - Project 2
//App Name - arithmeticIsCool.org Calculator
//App Purpose - this app performs a variety of mathematical based on two textbox inputs
//Developer Names - Hudson Pierce, Donnie Jenkins
//Date - 11/07/2019
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Major_Project_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //Hudson coded, Donnie reviewed
            InitializeComponent();
            startNumberTextBox.MaxLength = 9;
            endNumberTextBox.MaxLength = 9;
        }
        //Hudson coded, Donnie reviewed
        int startNumber;
        int endNumber;
        private void parseData()
        {
            int.TryParse(startNumberTextBox.Text, out startNumber);
            int.TryParse(endNumberTextBox.Text, out endNumber);
        }

        //Hudson coded, Donnie reviewed
        private void clear()
        {
            resultsListBox.Items.Clear();
        }
        //Hudson coded, Donnie reviewed
        private void focus()
        {
            startNumberTextBox.Focus();
        }
        //Donnie coded, Hudson reviewed
        private void AbsoluteValueBtn_Click(object sender, EventArgs e)
        {
            clear();
            parseData();
            resultsListBox.Items.Add("The absolute value of " + startNumber + ": " + Math.Abs(startNumber));
            resultsListBox.Items.Add("The absolute value of " + endNumber + ": " + Math.Abs(endNumber));
            focus();
        }
        //Hudson coded, Donnie reviewed
        private void CountBtn_Click(object sender, EventArgs e)
        {
            clear();
            parseData();
            int difference = Math.Abs(endNumber - startNumber) + 1;
            resultsListBox.Items.Add("Count of values between " + startNumber + " and " + endNumber + ": " + difference);
            focus();
        }
        //Hudson coded, Donnie reviewed
        private void PerimiterBtn_Click(object sender, EventArgs e)
        {
            clear();
            parseData();
            int perimiter = (startNumber * 2) + (endNumber * 2);
            if(startNumber <= 0 || endNumber <= 0)
            {
                MessageBox.Show("Error: Please enter values greater than zero", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                clear();
            }
            else if(startNumber > endNumber)
            {
                MessageBox.Show("Error: Please enter an end number greater than or equal to start number", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                clear();
            }
            else
            {
                resultsListBox.Items.Add("Rectangle perimiter: width = " + startNumber + ";" + " length = " + endNumber + " is " + perimiter);
            }
            focus();
        }
        //Hudson coded, Donnie reviewed
        private void PythagoreanTheoremBtn_Click(object sender, EventArgs e)
        {
            clear();
            parseData();

            int a = startNumber;
            int b = endNumber;
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            if (startNumber <= 0 || endNumber <= 0)
            {
                MessageBox.Show("Error: Please enter values greater than zero", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                clear();
            }

            else
            {
                resultsListBox.Items.Add("a\xB2 + b\xB2 = c\xB2");
                resultsListBox.Items.Add(Math.Pow(a, 2) + " + " + Math.Pow(b, 2) + " = c\xB2");
                resultsListBox.Items.Add((Math.Pow(a, 2) + Math.Pow(b, 2)).ToString("N2") + " = c\xB2");
                resultsListBox.Items.Add(c.ToString("N2") + " = c");
            }
            focus();
        }
        //Hudson coded, Donnie reviewed
        private void FactorialBtn_Click(object sender, EventArgs e)
        {
            clear();
            parseData();
            endNumberTextBox.Clear();

            if (startNumber > 10 || startNumber < 0)
            {
                MessageBox.Show("Error: Please enter a value greater than 0 and less than or equal to 10", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                clear();
            }
            else if (startNumber == 0)
            {
                resultsListBox.Items.Add(startNumber + "! = 1");
            }
            else
            {
                int factorial = startNumber;
                for (int counter = startNumber - 1; counter >= 1; counter--)
                {
                    factorial = factorial * counter;
                }
                resultsListBox.Items.Add(startNumber + "! = " + factorial + ".");
            }
            focus();
        }
        //Hudson coded, Donnie reviewed
        private void MultiplicationTableBtn_Click(object sender, EventArgs e)
        {
            clear();
            parseData();

            if (startNumber > 12 || startNumber < 1)
            {
                MessageBox.Show("Error: Please enter a value between 1 and 12", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                clear();
            }

            else
            {
                for (int i = 1; i <= 12; i++)
                {
                    int result = startNumber * i;
                    resultsListBox.Items.Add(i + " * " + startNumber + " = " + result);
                }
            }
            focus();
        }
        //Hudson coded, Donnie reviewed
        private void FibonacciBtn_Click(object sender, EventArgs e)
        {
            clear();
            parseData();
            endNumberTextBox.Clear();
            if(startNumber > 0 & startNumber <= 30)
            {
                int[] numbers = new int[30];
                numbers[0] = 0;
                numbers[1] = 1;

                resultsListBox.Items.Add(numbers[0]);
                resultsListBox.Items.Add(numbers[1]);

                for (int index = 2; index < startNumber; index++)
                {
                    numbers[index] = numbers[index - 1] + numbers[index - 2];
                    resultsListBox.Items.Add(numbers[index]);
                }
            }

            else
            {
                MessageBox.Show("Please enter a value between 1 and 30 for the start number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                startNumberTextBox.Focus();
            }
            focus();
        }
        //Hudson coded, Donnie reviewed
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
                this.Close();
        }
        //Donnie coded, Hudson reviewed
        private void ExponentationBtn_Click(object sender, EventArgs e)
        {
            clear();
            parseData();

            double result = Math.Pow(startNumber, endNumber);

            resultsListBox.Items.Add(startNumber + " raised to the power of " + endNumber + ": " + result);

            focus();
        }
        //Donnie coded, Hudson reviewed
        private void RangeBtn_Click(object sender, EventArgs e)
        {
            clear();
            parseData();

            int range = startNumber - endNumber;

            int absoluteRange = Math.Abs(range);

            resultsListBox.Items.Add("Range of values between " + startNumber + " and " + endNumber + ": " + absoluteRange);

            focus();
        }
        //Donnie coded, Hudson reviewed
        private void SumOfSquaresBtn_Click(object sender, EventArgs e)
        {
            clear();
            parseData();

            if(startNumber == 0 & endNumber == 0)
            {
                MessageBox.Show("Start number and end number cannot both be zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (startNumber > endNumber)
            {
                MessageBox.Show("Start number must be less than the end number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                double square = 0;
                double sumSquare = 0;
                int sum = 0;
                for (int i = startNumber; i <= endNumber; i++)
                {
                    square = Math.Pow(i, 2);
                    sumSquare += square;
                    sum += i;

                    resultsListBox.Items.Add("The number is: " + i + " and its square is: " + square);

                }
                resultsListBox.Items.Add("");
                resultsListBox.Items.Add("Sum of numbers: " + sum + " Sum of squares: " + sumSquare);

            }
            focus();
        }
        //Donnie coded, Hudson reviewed
        private void DescendingSortBtn_Click(object sender, EventArgs e)
        {
            clear();
            parseData();

            resultsListBox.Items.Add("Descending values between " + startNumber + " and " + endNumber + ":");

            if (startNumber < endNumber)
            {
                int swap = startNumber;
                startNumber = endNumber;
                endNumber = swap;
            }

            for (int iterations = startNumber; iterations >= endNumber; iterations -= 1)
            {
                resultsListBox.Items.Add(iterations);
            }
            focus();
        }
        //Hudson coded, Donnie reviewed
        private void StartNumberTextBox_Click(object sender, EventArgs e)
        {
            startNumberTextBox.SelectAll();
        }
        //Hudson coded, Donnie reviewed
        private void EndNumberTextBox_Click(object sender, EventArgs e)
        {
            endNumberTextBox.SelectAll();
        }
        //Hudson coded, Donnie reviewed
        private void StartNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            clear();
        }
        //Hudson coded, Donnie reviewed
        private void EndNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            clear();
        }
        //Hudson coded, Donnie reviewed
        private void StartNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
                return;
            }
        }
        //Hudson coded, Donnie reviewed
        private void EndNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
                return;
            }
        }
        //Hudson coded, Donnie reviewed
        private void StartNumberTextBox_Enter(object sender, EventArgs e)
        {
            startNumberTextBox.SelectAll();
        }
        //Hudson coded, Donnie reviewed
        private void EndNumberTextBox_Enter(object sender, EventArgs e)
        {
            endNumberTextBox.SelectAll();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
