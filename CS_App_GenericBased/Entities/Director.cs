using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_App_GenericBased.Entities
{
    internal class Director : Employee
    {
        public decimal HRA { get; set; }
        public decimal MobileAllowance { get; set; }
    }
}
