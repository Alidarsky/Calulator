using System;

namespace Calulator.OneArg
{
    public class Sin : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}
