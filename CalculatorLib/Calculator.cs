﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Div(int x, int y)
        {
            DataValidatorLib.DataValidator validator = new DataValidatorLib.DataValidator();
            if (validator.IsDataValueZero(y))
            {
                return 0;
            }
            return x / y;
        }
    }
}
