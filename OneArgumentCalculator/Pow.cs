namespace Calulator.OneArgumentCalculator
{
    public class Pow : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return first * first;
        }
    }
}
