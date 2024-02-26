using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    abstract class Number
    {
        public abstract double Add(double a, double b);

        public abstract double Subtract(double a, double b);

        public abstract double Multiply(double a, double b);

        public abstract double Divide(double a, double b);
    }
}
