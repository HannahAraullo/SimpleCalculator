using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public delegate int Add(int num1, int num2);
    class Addition
    {
        public static int getSum (int num1, int num2){
            return num1 + num2;
            }
    }
}
