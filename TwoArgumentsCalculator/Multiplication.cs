namespace Calulator
{
    public class Multi : ITwoArgumentsCalculator
    {
        public double Calculate (double first, double second)
        {
            return first * second;
        }
    }
}
