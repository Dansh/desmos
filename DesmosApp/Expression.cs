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
        //  converts an array of token string to an Expression Tree that can be calculated
        //
        // Parameters:
        //   tokenArray - a string array of token. token can be a string number, string operator or
        //      any part of the math expression (a string)
        //
        // Returns: 
        //   the beginning of the Expression tree
        public static Expression BuildTree(string tokenArray, int i = 0)
        {
            if (Operator.IsOperator(tokenArray[i].ToString()))
            {
                Expression leftExpression = BuildTree(tokenArray, i + 1);
                Expression rightExpression = BuildTree(tokenArray, i + leftExpression.GetLength() + 1);
                return new Operator(leftExpression, rightExpression, tokenArray[i].ToString());
            }
            return new Number(int.Parse(tokenArray[i].ToString()));
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



        // Summary:
        //   converts from infix to prefix
        // Returns:
        //   the string prefix representation of the expression
        public static string InfixToPrefix(string exp)
        {
            // reverse the expression string
            char[] expArr = exp.ToCharArray();
            Array.Reverse(expArr);
            exp = new string(expArr);

            // convert from infix to postfix
            exp = InfixToPostfix(exp);

            // reverse the expression string. again :)
            expArr = exp.ToCharArray();
            Array.Reverse(expArr);
            exp = new string(expArr);
            
            return exp;
        }


        public static int Prec(char ch)
        {
            switch (ch)
            {
                case '+':
                case '-':
                    return 1;

                case '*':
                case '/':
                    return 2;

                case '^':
                    return 3;
            }
            return -1;
        }


        // Summary:
        //   converts from infix to postfix
        // Returns:
        //   the string postfix representation of the expression
        private static string InfixToPostfix(string exp)
        {
            string result = "";
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < exp.Length; ++i)
            {
                char c = exp[i];
                if (char.IsLetterOrDigit(c))
                {
                    result += c;
                }
                else
                {
                    while (stack.Count > 0
                           && Prec(c) <= Prec(stack.Peek()))
                    {
                        result += stack.Pop();
                    }
                    stack.Push(c);
                }
            }
            while (stack.Count > 0)
            {
                result += stack.Pop();
            }
            return result;
        }

        
    }
}
