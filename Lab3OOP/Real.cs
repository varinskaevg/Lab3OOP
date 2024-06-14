using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3OOP
{
    public class Real : Number
    {
        private double value;

        public Real(double value)
        {
            this.value = value;
        }

        public override Number Add(Number other)
        {
            if (other is Real)
            {
                return new Real(this.value + ((Real)other).value);
            }
            throw new ArgumentException("Invalid type");
        }

        public override Number Subtract(Number other)
        {
            if (other is Real)
            {
                return new Real(this.value - ((Real)other).value);
            }
            throw new ArgumentException("Invalid type");
        }

        public override Number Multiply(Number other)
        {
            if (other is Real)
            {
                return new Real(this.value * ((Real)other).value);
            }
            throw new ArgumentException("Invalid type");
        }

        public override Number Divide(Number other)
        {
            if (other is Real)
            {
                return new Real(this.value / ((Real)other).value);
            }
            throw new ArgumentException("Invalid type");
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}
