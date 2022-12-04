using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesmosApp
{
    class DecimalNumber : Expression
    {
        private readonly double number;

        public DecimalNumber(double number)
        {
            this.number = number;
        }

        public override double Interpret()
        {
            return this.number;
        }

        public override int GetLength()
        {
            return number.ToString().Length + 1;
        }

        public override string ToString()
        {
            return number.ToString();
        }
    }
}
