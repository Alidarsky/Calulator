﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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