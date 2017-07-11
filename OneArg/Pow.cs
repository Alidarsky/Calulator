using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calulator.OneArg
{
    public class Pow : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return first * first;
        }
    }
}
