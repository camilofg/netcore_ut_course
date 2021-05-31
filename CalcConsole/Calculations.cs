﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CalcConsole
{
    public class Calculations
    {
        public List<int> FiboNumbers => new List<int> { 1, 1, 2, 3, 5, 8, 13 };

        public int Add(int a, int b)
        {
            return a + b;
        }

        public double AddDouble(double a, double b)
        {
            return a + b;
        }

        public bool IsOdd(int value) {
            return (value % 2) == 1;
        }
    }
}
