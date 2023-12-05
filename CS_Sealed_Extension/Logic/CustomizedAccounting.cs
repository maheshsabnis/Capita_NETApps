using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CS_Sealed_Extension.Logic
{
    internal class CustomizedAccounting
    {
        public decimal CalculateServiceTax(decimal bill)
        { 
            return bill * Convert.ToDecimal(0.16);
        }
    }


    /// <summary>
    /// Extension Method class
    /// 1. Class is Static
    /// </summary>
    internal static class AccountingExtension
    {
        /// <summary>
        /// The Extension Method
        /// 2. The Method is Static
        /// 3. The First Parameter is 'this' referred reference of 'Accounting' class
        /// - 'this Accounting acc'
        ///     - Means that the method CalculateServiceTax() will be accessed using an insatnce of
        ///     Accounting class
        /// </summary>
        /// <param name="acc"></param>
        /// <param name="bill"></param>
        /// <returns></returns>
        public static decimal CalculateServiceTax(this Accounting acc, decimal bill)
        {
            return bill * Convert.ToDecimal(0.16);
        }
    }


    internal static class StringExtensions
    {
        public static int GetLength(this string str)
        { 
            return str.Length;
        }

        public static string ChangeCase(this string str, char c)
        { 
            if(c == 'l' || c == 'L') return str.ToLower();
            if(c == 'u' || c == 'U') return str.ToUpper();
            return str;
        }

        public static int GetWhiteSpaces(this string str)
        {
            int whiteSpaces = 0;
            foreach(char c in str) 
            {
                if(Char.IsWhiteSpace(c))
                    whiteSpaces++;
            }
            return whiteSpaces;
        }
    }

}
