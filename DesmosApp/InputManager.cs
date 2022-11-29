using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesmosApp
{
    static class InputManager
    {

        // removing all whitespaces from the string
        public static string RemoveWhiteSpaces(string str)
        {            
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    newStr += str[i];
                }
            }
            return newStr;
        }


        // Summary:
        //   add the * symbol before every parameter in the string
        public static string HandleParameters(string str)
        {
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLetter(str[i]))
                {
                    newStr += "*";
                }
                newStr += str[i];
            }
            return newStr;
        }

        public static string ReplaceCharByString(string targetStr, char ch, string str)
        {
            string newStr = "";
            for (int i = 0; i < targetStr.Length; i++)
            {
                if (targetStr[i] == ch)
                {
                    for (int j = 0; j < str.Length; j++)
                    {
                        newStr += str[j];
                    }
                }
                else
                {
                    newStr += targetStr[i];
                }
            }
            return newStr;
        }
    }
}
