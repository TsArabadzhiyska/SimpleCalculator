using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {


        Division division = new Division();
        Multiplication multiplication = new Multiplication();
        Substraction substraction = new Substraction();
        Addition addition = new Addition();

        private decimal currentValue;
        private string firstnum;
        private string secondnum;
        private bool enterValue = false;
        private string currentOperation;
        private decimal memory;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CloseButton_MouseHover(object sender, EventArgs e)
        {

            CloseButton.ForeColor = ColorTranslator.FromHtml("#FFF");
            CloseButton.BackColor = Color.Red;

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Black;
            CloseButton.BackColor = ColorTranslator.FromHtml("#F0F0F0");

        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;

        }

        private void NumbersOnly_Click(object sender, EventArgs e)
        {
            Button numberButton = (Button)sender;

            if ((display.Text == "0") || (enterValue == true))
            {
                display.Text = "";

            }

            enterValue = false;
            if (numberButton.Text == ".")
            {

                if (!display.Text.Contains("."))
                {
                    display.Text = display.Text + numberButton.Text;
                }

            }
            else
            {
                display.Text = display.Text + numberButton.Text;

            }
        }
        private void MathOperations_Click(object sender, EventArgs e)
        {
            Button operationButton = (Button)sender;


            if (currentValue != 0)
            {
                equalsButton.PerformClick();
                enterValue = true;
                currentOperation = operationButton.Text;
                TrackLabelCalc.Text = currentValue + " " + currentOperation;
            }
            else
            {
                currentValue = decimal.Parse(display.Text);
                currentOperation = operationButton.Text;
                display.Text = "";
                TrackLabelCalc.Text = currentValue + " " + currentOperation;
            }
            firstnum = TrackLabelCalc.Text;
        }

        private void Equals_Click(object sender, EventArgs e)
        {

            string secondnum = display.Text;

            lbHronology.Text = "";
            switch (currentOperation)
            {
                case "÷":
                    currentValue = division.MathOperation(currentValue, decimal.Parse(display.Text));

                    TrackLabelCalc.Text = Convert.ToString(currentValue) + currentOperation + display.Text;

                    TrackLabelCalc.Text = "";
                    display.Text = (currentValue).ToString();
                    break;
                case "✕":
                    currentValue = multiplication.MathOperation(currentValue, decimal.Parse(display.Text));
                    TrackLabelCalc.Text = Convert.ToString(currentValue) + currentOperation + display.Text;

                    TrackLabelCalc.Text = "";
                    display.Text = (currentValue).ToString();
                    break;
                case "-":
                    currentValue = substraction.MathOperation(currentValue, decimal.Parse(display.Text));
                    TrackLabelCalc.Text = Convert.ToString(currentValue) + currentOperation + display.Text;

                    TrackLabelCalc.Text = "";
                    display.Text = (currentValue).ToString();
                    break;
                case "+":
                    currentValue = addition.MathOperation(currentValue, decimal.Parse(display.Text));
                    display.Text = currentValue.ToString();
                    TrackLabelCalc.Text = "";
                    break;


            }

            currentOperation = "";
            hronologyTextBox.AppendText("\n" + firstnum + " " + secondnum + "\n" + "= " + "\n");
            hronologyTextBox.AppendText("\n\t" + display.Text + "\n\n");
            lbHronology.Text = "";
            firstnum = "";
        }

        private void clearHronologyB_Click(object sender, EventArgs e)
        {
            hronologyTextBox.Clear();
            lbHronology.Text = "You have to make some\ncalculations ";
            hronologyTextBox.ScrollBars = 0;
        }



        private void ClearDisplayButton_Click(object sender, EventArgs e)
        {
            TrackLabelCalc.Text = "";
            currentValue = 0;
            memory = 0;
            display.Text = "0";
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            currentValue = 0;
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void PositiveNegativeButton_Click(object sender, EventArgs e)
        {
            currentValue = decimal.Parse(display.Text);
            if (currentValue != 0)
            {
                if (display.Text.Contains("-"))
                {
                    display.Text = display.Text.Remove(0, 1);
                }
                else
                {
                    currentValue = -currentValue;
                    display.Text = currentValue.ToString();
                }
            }
        }

        private void ClearOneDigit_Click(object sender, EventArgs e)
        {
            if (display.Text.Length > 0)
                display.Text = display.Text.Remove(display.Text.Length - 1);
            else
                display.Text = "0";
        }

        private void MemoryClear_Click(object sender, EventArgs e)
        {
            memory = 0;
            MemoryClear.Enabled = false;
            MemoryRead.Enabled = false;
        }

        private void MemoryRead_Click(object sender, EventArgs e)
        {
            display.Text = memory.ToString();
        }

        private void MemorySave_Click(object sender, EventArgs e)
        {
            memory = decimal.Parse(display.Text);
            display.Text = "0";
            MemoryClear.Enabled = true;
            MemoryRead.Enabled = true;

        }

        private void MemoryAddition_Click(object sender, EventArgs e)
        {
            currentValue = decimal.Parse(display.Text);
            memory = memory + currentValue;

        }

        private void MemorySubstraction_Click(object sender, EventArgs e)
        {
            currentValue = decimal.Parse(display.Text);
            memory = memory - currentValue;
            TrackLabelCalc.Text = memory.ToString();
        }

        private void Percent_Click(object sender, EventArgs e)
        {
            currentValue = decimal.Parse(display.Text);

            currentValue = currentValue / 100;

            display.Text = currentValue.ToString();

        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            currentValue = decimal.Parse(display.Text);
            currentValue = (decimal)Math.Sqrt((double)currentValue);
            display.Text = currentValue.ToString();

        }

        private void PowButton_Click(object sender, EventArgs e)
        {
            currentValue = decimal.Parse(display.Text);
            currentValue = (decimal)Math.Pow((double)currentValue, 2);
            display.Text = currentValue.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentValue = decimal.Parse(display.Text);
            if (currentValue != 0)
            {
                currentValue = (decimal)1.0 / currentValue;
                display.Text = currentValue.ToString();
            }
            else
            {
                TrackLabelCalc.Text = "Can't divide by zero";

            }
        }
    }
}
//Tsvetelina Arabadzhiyska 1701681027 
