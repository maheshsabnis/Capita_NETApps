using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Overloading.Logic
{
    internal class StringOperations
    {
        /// <summary>
        /// Single Parameter Method
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string Concat(string str)
        {
            return $"The String is: {str}";
        }
        /// <summary>
        /// 2 Parameters
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public string Concat(string str1, string str2) 
        {
            return $"The String is: {str1} {str2}";
        }
        /// <summary>
        /// A String and String Array
        /// </summary>
        /// <param name="str"></param>
        /// <param name="strings"></param>
        /// <returns></returns>
        public string Concat(string str, string[] strings)
        {
            string result = String.Empty; // Best Practice

            result = str;

            foreach (string s in strings) 
            {
                result += s;
            }
            return result;
        }

        /// <summary>
        /// Same number of Input Parameters but change in Type 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="str"></param>
        /// <returns></returns>

        public string Concat(int x , string str)
        {
            return $"{str} : {x}";
        }

        /// <summary>
        /// Same number of Input Parameters but change in Order 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="str"></param>
        /// <returns></returns>

        public string Concat( string str, int x)
        {
            return $"{x} : {str}";
        }
    }
}
