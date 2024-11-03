using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace visual_tasks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Open_Calculator(object sender, EventArgs e)
        {
            FCalculatorForm calculatorForm = new FCalculatorForm();

            calculatorForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            image_panner image_Panner = new image_panner();
            image_Panner.Show(); 
        }
    }
}
