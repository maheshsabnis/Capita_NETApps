using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Task_Continue.Logic
{
    internal class Processing
    {
        public decimal GetSalary(decimal sal)
        {
            decimal hra = 1000;
            decimal ta = 5000;    
            return sal + hra + ta;
        }
        public decimal GetTDS(decimal sal)
        { 
            return sal * Convert.ToDecimal(0.3);
        }
    }
}
