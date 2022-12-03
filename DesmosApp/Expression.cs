using System;
using System.Collections.Generic;
using System.Text;

namespace DesmosApp
{
    abstract class Expression
    {
        public abstract int Interpret();
        public abstract int GetLength();


        // Summary:
        //    converts a string to an Expression Tree that can be calculated
        //
        // Parameters:
        //      tokenArray - a string that can be a string number, string operator or
        //            any part of the math expression (a string)
        //
        // Returns: 
        //      the beginning of the Expression tree
        public static Expression BuildTree(string str, int i = 0)
        {
            if (Operator.IsOperator(str[i].ToString()))
            {
                Expression leftExpression = BuildTree(str, i + 2);
                Expression rightExpression = BuildTree(str, i + leftExpression.GetLength() + 2);
                return new Operator(leftExpression, rightExpression, str[i].ToString());
            }
            string numStr = "";
            while (str[i] != ' ')
            {
                numStr += str[i];
                i++;
                if (i == str.Length)
                {
                    break;
                }
            }
            return new Number(int.Parse(numStr.ToString()));
        }

        public void PrintExpressionTree()
        {
            Console.WriteLine(this);
            if (this.GetType() == typeof(Operator))
            {
                ((Operator)this).leftExpression.PrintExpressionTree();
                ((Operator)this).rightExpression.PrintExpressionTree();
            }
        }

    }
}
