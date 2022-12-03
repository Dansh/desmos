using System;
using System.Collections.Generic;
using System.Text;

namespace DesmosApp
{
    class Number : Expression
    {
        private readonly int number;

        public Number(int number)
        {
            this.number = number;
        }

        public override int Interpret()
        {
            return this.number;
        }

        public override int GetLength()
        {
            int copy = number;
            int counter = 0;
            while (copy > 0)
            {
                copy /= 10;
                counter++;
            }
            return counter + 1;
        }

        public override string ToString()
        {
            return number.ToString();
        }
    }
}
