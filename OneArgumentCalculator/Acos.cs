
using System;

namespace Calulator.OneArgumentCalculator
{
    public class Acos : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Acos(first);
        }
    }
}

