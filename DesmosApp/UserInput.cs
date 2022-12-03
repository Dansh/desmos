using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesmosApp
{

    // The expression class can only calculate prefix string which represents math expression
    // This class is responsible for taking the user math expression input (infix) 
    // and preparing it for the Expression class.
    class UserInput
    {
        private string str;
        private Dictionary<char, string> charToIntDict;

        public string Str
        {
            get
            {
                return str;
            }
            set
            {
                str = value;
            }
        }


        public UserInput(string str)
        {
            this.str = str;
            charToIntDict = new Dictionary<char, string>();
        }


        // Summary:
        //      Expression class which is responsible for calculating the expression
        //      can only handle infix string, this function takes the str attribute and
        //      prepares it for the expresion class.
        public void PrepareForCalc()
        {
            str = str.Replace(" ", "");
            ReplaceNumsByChars();
            InfixToPrefix();
            char[] strArr = str.ToCharArray();
            str = string.Join(" ", strArr);
            ReplaceCharsByNums();
        }



        // Summary:
        //      Replaces all the chars in the str attribute with the correct values from
        //      the charToIntDict attribute.
        public void ReplaceCharsByNums()
        {
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLetter(str[i]))
                {
                    newStr += charToIntDict[str[i]];
                }
                else
                {
                    newStr += str[i];
                }
            }
            str = newStr;
        }


        // Summary:
        //      The infix to prefix algorithm is designed to work with chars.
        //      this function replace all the nums in a string with chars and saves the values 
        //      in the charToIntDict attribute.
        public void ReplaceNumsByChars()
        {
            string newStr = "", currentNumStr = "";
            char currentChar = 'A';
            for (int i = 0; i < str.Length; i++)
            {
                if (!Char.IsDigit(str[i]))
                {
                    if (currentNumStr == "")
                    {
                        throw new Exception("Syntex Error");
                    }
                    charToIntDict[currentChar] = currentNumStr;
                    currentNumStr = "";
                    newStr += currentChar;
                    newStr += str[i];
                    currentChar++;                    
                }
                else
                {
                    currentNumStr += str[i];
                }
            }
            if (currentNumStr == "")
            {
                throw new Exception("Syntex Error");
            }
            charToIntDict[currentChar] = currentNumStr;
            newStr += currentChar;
            str = newStr;
        }


        // Summary:
        //      converts from infix to postfix
        // Returns:
        //      the string postfix representation of the expression
        private void InfixToPostfix()
        {
            string result = "";
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < str.Length; ++i)
            {
                char c = str[i];
                if (char.IsLetterOrDigit(c))
                {
                    result += c;
                }
                else       
                {
                    while (stack.Count > 0
                            && Prec(c) < Prec(stack.Peek()))
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
            str = result;
        }


        // Summary:
        //      converts from infix to prefix
        // Returns:
        //      the string prefix representation of the expression
        public void InfixToPrefix()
        {
            // reverse the expression string
            char[] strArr = str.ToCharArray();
            Array.Reverse(strArr);
            str = new string(strArr);

            // convert from infix to postfix
            InfixToPostfix();

            // reverse the expression string. again :)
            strArr = str.ToCharArray();
            Array.Reverse(strArr);
            str = new string(strArr);
        }


        public int Prec(char ch)
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
        //   takes every parameter in the string and simplfies it for the computer
        //   for example -
        //   3 + 3x -> 3 + 3 * x
        public void HandleParameters()
        {
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLetter(str[i]))
                {
                    if (i == 0)
                    {
                        newStr += "1*";
                    }
                    else
                    {
                        if (Char.IsDigit(str[i - 1]))
                        {
                            newStr += "*";
                        }
                        else
                        {
                            newStr += "1*";
                        }
                    }
                }
                newStr += str[i];
            }
            str = newStr;
        }


        public void ReplaceParameter(char param, string value)
        {
            str = str.Replace(param.ToString(), value);
        }

    }
}
