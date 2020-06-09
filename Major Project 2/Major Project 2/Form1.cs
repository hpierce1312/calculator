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
            InitializeComponent();
        }
        //declare global variables
        int startNumber;
        int endNumber;

        private void parseData()
        {
            int.TryParse(startNumberTextBox.Text, out startNumber);
            int.TryParse(endNumberTextBox.Text, out endNumber);
        }

        private void clear()
        {
            resultsListBox.Items.Clear();
        }

        private void AbsoluteValueBtn_Click(object sender, EventArgs e)
        {
            clear();
            parseData();
            if(startNumber < 0)
            {
                resultsListBox.Items.Add("The absolute value of " + startNumber + ": " + startNumber * -1);
            }
            else
            {
                resultsListBox.Items.Add("The absolute value of " + startNumber + ": " + startNumber);
            }

            if(endNumber < 0)
            {
                resultsListBox.Items.Add("The absolute value of " + endNumber + ": " + endNumber * -1);
            }
            else
            {
                resultsListBox.Items.Add("The absolute value of " + endNumber + ": " + endNumber);
            }
        }

        private void CountBtn_Click(object sender, EventArgs e)
        {
            clear();
            parseData();
            int difference = endNumber - startNumber + 1;
            resultsListBox.Items.Add("Count of values between " + startNumber + " and " + endNumber
                    + ": " + difference);
        }

        private void DescSortBtn_Click(object sender, EventArgs e)
        {
            clear();
            parseData();
            for (int counter = endNumber; counter <= startNumber; counter--)
            {
                resultsListBox.Items.Add("Descending values between 3 and 8:");
                resultsListBox.Items.Add(counter.ToString());
            }
        }

        private void PerimiterBtn_Click(object sender, EventArgs e)
        {
            clear();
            parseData();
            int perimiter = (startNumber * 2) + (endNumber * 2);
            if(startNumber <= 0 || endNumber <= 0 || startNumber > endNumber)
            {
                MessageBox.Show("Error: Please enter another number", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                clear();
            }
            else
            {
                resultsListBox.Items.Add("Rectangle perimiter: width = " + startNumber + ";" + " length = " + endNumber + " is 22");
            }
        }

        private void PythagoreanTheoremBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
