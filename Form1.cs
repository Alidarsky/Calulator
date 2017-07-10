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

        private void ButtonClick(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(field1.Text);
            double second = Convert.ToDouble(field2.Text);
            double resultValue;

            switch (((Button)sender).Name)
            {
                case "multi":
                    resultValue = first * second;                   
                    break;
                case "divi":
                    resultValue = first / second;
                    break;
                case "minus":
                    resultValue = first - second;
                    break;
                case "plus":
                    resultValue = first + second;
                    break;
                default:
                    throw new Exception("Неизвестная операция!");
            }
            result.Text = resultValue.ToString();
        }

    }
}
