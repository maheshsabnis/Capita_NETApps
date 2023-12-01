using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_OOPs_Design.Entities
{
    /// <summary>
    /// SRP
    /// </summary>
    internal class Employee
    {
        // Read/Write Property
        // set for Write and get for read
        public int EmpNo { get; set; }
        public string? EmpName {  get; set; }
        public string? DeptName { get; set; }
        public decimal Salary { get; set; }
        public string? Designation { get; set; } /* Property that will have repeated values e.g. Managers, Directors, S/W Engi, etc. */
        public decimal HRA { get; set; }
        public decimal TA { get; set; }
        public decimal TDS { get; set; }
        public decimal GorssIncome { get; }
        public decimal TakeHomeIncome { get;}

    }
}
