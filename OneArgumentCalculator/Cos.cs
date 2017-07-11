using System;

namespace Calulator.OneArgumentCalculator
{
    public class Cos : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}
