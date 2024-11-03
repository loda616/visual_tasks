using System;
using System.Windows.Forms;

namespace visual_tasks
{
    public partial class FCalculatorForm : Form
    {
        private double memoryValue = 0;
        private string currentOperation = "";
        private double result = 0;
        private bool operationPressed = false;

        public FCalculatorForm()
        {
            InitializeComponent();
        }

        private void load_data(object sender, EventArgs e)
        {
            // Initialize any required data if necessary
        }

        // Helper method to update text box
        private void UpdateTextBox(string value)
        {
            if (operationPressed)
            {
                textBox1.Clear();  // textBox1 is the name of the text box control
                operationPressed = false;
            }
            textBox1.Text += value;
        }

        // Number buttons click events
        private void button1_Click(object sender, EventArgs e) { UpdateTextBox("0"); }
        private void button2_Click(object sender, EventArgs e) { UpdateTextBox("1"); }
        private void button3_Click(object sender, EventArgs e) { UpdateTextBox("2"); }
        private void button4_Click(object sender, EventArgs e) { UpdateTextBox("3"); }
        private void button5_Click(object sender, EventArgs e) { UpdateTextBox("4"); }
        private void button6_Click(object sender, EventArgs e) { UpdateTextBox("5"); }
        private void button7_Click(object sender, EventArgs e) { UpdateTextBox("6"); }
        private void button8_Click(object sender, EventArgs e) { UpdateTextBox("7"); }
        private void button9_Click(object sender, EventArgs e) { UpdateTextBox("8"); }
        private void button10_Click(object sender, EventArgs e) { UpdateTextBox("9"); }

        // Operator buttons click events
        private void buttonPls_Click(object sender, EventArgs e) { SetOperation("+"); }
        private void buttonSub_Click(object sender, EventArgs e) { SetOperation("-"); }
        private void buttonDiv_Click(object sender, EventArgs e) { SetOperation("/"); }
        private void buttonMult_Click(object sender, EventArgs e) { SetOperation("*"); }

        private void SetOperation(string operation)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                result = double.Parse(textBox1.Text);
                currentOperation = operation;
                operationPressed = true;
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            double secondOperand;
            if (double.TryParse(textBox1.Text, out secondOperand))
            {
                switch (currentOperation)
                {
                    case "+":
                        result += secondOperand;
                        break;
                    case "-":
                        result -= secondOperand;
                        break;
                    case "*":
                        result *= secondOperand;
                        break;
                    case "/":
                        if (secondOperand != 0)
                            result /= secondOperand;
                        else
                            MessageBox.Show("Cannot divide by zero!");
                        break;
                }
                textBox1.Text = result.ToString();
                currentOperation = "";
            }
        }

        // Function buttons click events
        private void buttonClear_click(object sender, EventArgs e) { Clear(); }
        private void xDiv_Click(object sender, EventArgs e) { CalculateReciprocal(); }
        private void persenteg_Click(object sender, EventArgs e) { CalculatePercentage(); }
        private void SQR_Click(object sender, EventArgs e) { CalculateSquareRoot(); }

        // Function implementations
        private void Clear()
        {
            textBox1.Clear();
            result = 0;
            currentOperation = "";
        }

        private void CalculateReciprocal()
        {
            if (double.TryParse(textBox1.Text, out double value) && value != 0)
            {
                textBox1.Text = (1 / value).ToString();
            }
            else
            {
                MessageBox.Show("Cannot calculate reciprocal of zero!");
            }
        }

        private void CalculatePercentage()
        {
            if (double.TryParse(textBox1.Text, out double value))
            {
                textBox1.Text = (value / 100).ToString();
            }
        }

        private void CalculateSquareRoot()
        {
            if (double.TryParse(textBox1.Text, out double value))
            {
                textBox1.Text = Math.Sqrt(value).ToString();
            }
        }

        // Memory buttons click events
        private void MomeryPlus_Click(object sender, EventArgs e) { MemoryPlus(); }
        private void MomeryClear_(object sender, EventArgs e) { MemoryClear(); }
        private void momeryRead_Click(object sender, EventArgs e) { MemoryRead(); }
        private void momerySave_Click(object sender, EventArgs e) { MemorySave(); }

        // Memory functions
        private void MemoryPlus()
        {
            if (double.TryParse(textBox1.Text, out double value))
            {
                memoryValue += value;
                textBox1.Text = memoryValue.ToString();
            }
        }

        private void MemoryClear()
        {
            memoryValue = 0;
        }

        private void MemoryRead()
        {
            textBox1.Text = memoryValue.ToString();
        }

        private void MemorySave()
        {
            if (double.TryParse(textBox1.Text, out double value))
            {
                memoryValue = value;
            }
        }
    }
}
