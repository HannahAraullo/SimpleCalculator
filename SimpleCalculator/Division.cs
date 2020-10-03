using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public delegate int Divide(int num1, int num2);
    class Division
    {
        public static int getQuotient(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}

