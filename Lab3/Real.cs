using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Real : Number
    {
        public override double Add(double a, double b)
        {
            return a + b;
        }

        public override double Subtract(double a, double b)
        {
            return a - b;
        }

        public override double Multiply(double a, double b)
        {
            return a * b;
        }

        public override double Divide(double a, double b)
        {
            if (b != 0)
                return a / b;
            else
                throw new DivideByZeroException("Ділення на нуль.");
        }
    }
}
