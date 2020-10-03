using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public delegate int Minus(int num1, int num2);
    class Subtraction
    {
        public static int getDiff(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}

