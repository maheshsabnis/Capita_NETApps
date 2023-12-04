using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ref_out_params
{
    internal class Processing
    {
        public void XChange(ref int x, ref int y)
        {
            Console.WriteLine($"Received x = {x} and y = {y}");
            int z = x;
            x = y;
            y = z;
            Console.WriteLine($"After XChange x = {x} and y = {y}");
        }



        public void GetTDSAndIncome(decimal salary, out decimal tds, out decimal netincome)
        {
            if (salary > 50000)
            {
                tds = salary * Convert.ToDecimal(0.2);
            }
            else
            {
                tds = salary * Convert.ToDecimal(0.3);
            }
            netincome = salary - tds;
        }
        /// <summary>
        /// the params MUST be the last parameter to a method
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public int Add(int x,int y, params int[] values)
        {
            int sum = 0;

            if(values.Length == 0)
                return x + y;

            sum = x + y;
            foreach (int i in values)
            {
                sum += i;
            }

            return sum;
        }
    }
}
