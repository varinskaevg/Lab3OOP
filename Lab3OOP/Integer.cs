using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3OOP
{
    public class Integer : Number
    {
        private int value;

        public Integer(int value)
        {
            this.value = value;
        }

        public override Number Add(Number other)
        {
            if (other is Integer)
            {
                return new Integer(this.value + ((Integer)other).value);
            }
            throw new ArgumentException("Invalid type");
        }

        public override Number Subtract(Number other)
        {
            if (other is Integer)
            {
                return new Integer(this.value - ((Integer)other).value);
            }
            throw new ArgumentException("Invalid type");
        }

        public override Number Multiply(Number other)
        {
            if (other is Integer)
            {
                return new Integer(this.value * ((Integer)other).value);
            }
            throw new ArgumentException("Invalid type");
        }

        public override Number Divide(Number other)
        {
            if (other is Integer)
            {
                return new Integer(this.value / ((Integer)other).value);
            }
            throw new ArgumentException("Invalid type");
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}
