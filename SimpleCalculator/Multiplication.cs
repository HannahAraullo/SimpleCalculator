using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public delegate int Multiply(int num1, int num2);
    class Multiplication
    {
        public static int getProduct(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}

