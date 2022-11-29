using System;
using System.Collections.Generic;
using System.Text;

namespace DesmosApp
{
    class Operator : Expression
    {
        private static string[] opList = { "+", "-", "*", "/" };
        public readonly string opStr;
        public readonly Expression leftExpression;
        public readonly Expression rightExpression;

        public Operator(Expression leftExpression, Expression rightExpression, string opStr)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
            this.opStr = opStr;
        }

        public override int Interpret()
        {
            switch (opStr)
            {
                case "+":
                    return leftExpression.Interpret() + rightExpression.Interpret();
                case "-":
                    return leftExpression.Interpret() - rightExpression.Interpret();
                case "*":
                    return leftExpression.Interpret() * rightExpression.Interpret();
                case "/":
                    return leftExpression.Interpret() / rightExpression.Interpret();
                default:
                    throw new Exception("Invalid Operator");
            }
        }
        // Summary:
        //   checks if a given string is an operator string by
        //   comparing to every element from the static opList
        //   which holds all the possible operators
        // Returns:
        //   the str given is an operator string
        public static bool IsOperator(string str)
        {
            foreach (string opStr in opList)
            {
                if (opStr == str)
                {
                    return true;
                }
            }
            return false;
        }

        public override int GetLength()
        {
            int sum = 1;
            if (this.rightExpression.GetType() == typeof(Number))
            {
                sum++;
            }
            else
            {
                sum += this.rightExpression.GetLength();
            }
            if (this.leftExpression.GetType() == typeof(Number))
            {
                sum++;
            }
            else
            {
                sum += this.leftExpression.GetLength();
            }
            return sum;
        }

        public override string ToString()
        {
            return opStr;
        }
    }   
}