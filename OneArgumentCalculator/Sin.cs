using System;

namespace Calulator.OneArgumentCalculator
{
    public class Sin : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}
