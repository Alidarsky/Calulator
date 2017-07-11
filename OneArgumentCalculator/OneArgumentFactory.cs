using System;

namespace Calulator.OneArgumentCalculator
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
                case "arcsin":
                    return new Asin();
                case "arccos":
                    return new Acos();
                case "tan":
                    return new Tan();
                case "ctan":
                    return new Ctan();
                case "tenX":
                    return new TenX();
                case "twoX":
                    return new TwoX();
                case "logTen":
                    return new LogTen();
                case "logTwo":
                    return new LogTwo();
                case "logE":
                    return new LogE();
                case "arctan":
                    return new Atan();
                case "minusX":
                    return new MinusX();   
                default:
                    throw new Exception("Неизвестная операция!");
            }
        }
    }
}
