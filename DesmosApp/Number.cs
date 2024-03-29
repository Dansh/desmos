﻿using System;
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
