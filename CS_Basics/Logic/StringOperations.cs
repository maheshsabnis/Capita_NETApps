using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Basics.Logic
{
    /// <summary>
    /// Single Responsibility Principal
    /// </summary>
    internal class StringOperations
    {
        public int GetLength(string str)
        {
            return str.Length;
        }
        public string ChangeCase(string str, char c)
        {
            if (c == 'l' || c == 'L')
                return str.ToLower();
            if (c == 'u' || c == 'U')
                return str.ToUpper();
            return str;
        }

        public void GetWhiteSpaces(string str, out int whiteSpaceCount)
        { 
            whiteSpaceCount = 0;

            foreach (char c in str) 
            {
                if(Char.IsWhiteSpace(c))
                {
                    whiteSpaceCount++; 
                }
            }
             
        }
    }
}
