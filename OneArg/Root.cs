using System;

namespace Calulator.OneArg
{
    public class Root : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Pow(first, 0.5);
        }
    }
}
