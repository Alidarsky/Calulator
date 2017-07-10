using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calulator
{
    public partial class Form1 : Form
    {      
        public Form1()
        {
            InitializeComponent();
        }

        private void multi_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(field1.Text);
            double second = Convert.ToDouble(field2.Text);
            double resultS = first * second;
            result.Text = Convert.ToString(resultS);
        }

        private void divi_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(field1.Text);
            double second = Convert.ToDouble(field2.Text);
            double resultS = first / second;
            result.Text = Convert.ToString(resultS);           
        }

        private void minus_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(field1.Text);
            double second = Convert.ToDouble(field2.Text);
            double resultS = first - second;
            result.Text = Convert.ToString(resultS); 
        }

        private void plus_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(field1.Text);
            double second = Convert.ToDouble(field2.Text);
            double resultS = first + second;
            result.Text = Convert.ToString(resultS); 
        }

    }
}
