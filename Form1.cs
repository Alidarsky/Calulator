using System;
using System.Windows.Forms;
using Calulator.OneArgumentCalculator;

namespace Calulator
{
    public partial class Form1 : Form
    {      
        public Form1()
        {
            InitializeComponent();
        }

        private void TwoButtonClick(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(field1.Text);
            double second = Convert.ToDouble(field2.Text);
            var calc = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
            double resultValue = calc.Calculate(first, second);          
            result.Text = resultValue.ToString();
        }

        private void OneButtonClick(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(field1.Text);
            var calc = OneArgumentFactory.CreateCalculator(((Button) sender).Name);
            double resultValue = calc.Calculate(first);
            result.Text = resultValue.ToString();
        }
    }
}
