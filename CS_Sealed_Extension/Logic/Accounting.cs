using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Sealed_Extension.Logic
{
    internal sealed class Accounting
    {
        public decimal CalcluateTDS(decimal income)
        {
            return income * Convert.ToDecimal(0.2);
        }
        public decimal CalcluateGST(decimal payment)
        {
            return payment * Convert.ToDecimal(0.18);
        }
    }
}
