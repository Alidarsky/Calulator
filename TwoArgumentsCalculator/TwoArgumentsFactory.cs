using System;
using Calulator.OneArgumentCalculator;


namespace Calulator
{
    public static class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string calcName)
        {
            switch (calcName)
            {
                case "multiplication":
                    return new Multi();
                case "division":
                    return new Division();
                case "minus":
                    return new Minus();
                case "plus":
                    return new Plus();
                case "residue":
                    return new Residue();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }

    }
}
