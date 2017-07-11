using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calulator.OneArgumentCalculator
{
    public class TenX : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Pow(10,first);
        }
    }
}
