using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calulator
{
    public static class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string CalcName)
        {
            switch (CalcName)
            {
                case "multi":
                    return new Multi();
                case "divi":
                    return new Divi();
                case "minus":
                    return new Minus();
                case "plus":
                    return new Plus();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }

    }
}
