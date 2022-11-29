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
    }
}
