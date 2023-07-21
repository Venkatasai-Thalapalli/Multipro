using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    public class Calc
    {
        public int Add(int a , int b)
        {
            return a + b;
        } 
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Divide(int a, int b)
        {
            if(b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            return a / b;
        }
        public int Multiply(int a, int b)
        {
            return (a * b);
        }
        public bool Prime(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
