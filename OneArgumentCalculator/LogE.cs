using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calulator.OneArgumentCalculator
{
    public class LogE : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(2.73,first);
        }
    }
}
