using System;

namespace Calulator.OneArg
{
    public class Cos : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}
