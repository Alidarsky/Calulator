using System;
using Calulator.OneArg;


namespace Calulator.OneArg
{
    public static class OneArgumentFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string calcName)
        {
            switch (calcName)
            {
                case "cos":
                    return new Cos();
                case "sin":
                    return new Sin();
                case "pow":
                    return new Pow();
                case "root":
                    return new Root();
                default:
                    throw new Exception("Неизвестная операция!");
            }
        }
    }
}
