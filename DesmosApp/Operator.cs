﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesmosApp
{
    class Operator : Expression
    {
        private static string[] opList = { "+", "-", "*", "/", "^" };
        public readonly string opStr;
        public readonly Expression leftExpression;
        public readonly Expression rightExpression;

        public Operator(Expression leftExpression, Expression rightExpression, string opStr)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
            this.opStr = opStr;
        }

        public override double Interpret()
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
                case "^":
                    return Math.Pow(leftExpression.Interpret(), rightExpression.Interpret());
                default:
                    throw new Exception("Invalid Operator");
            }
        }


        // Summary:
        //      checks if a given string is an operator string by
        //      comparing to every element from the static opList
        //      which holds all the possible operators
        // Returns:
        //      the str given is an operator string
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
            int sum = 2;
            sum += leftExpression.GetLength();
            sum += rightExpression.GetLength();
            return sum;
        }

        public override string ToString()
        {
            return opStr;
        }
    }
}