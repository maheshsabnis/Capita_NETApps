using CS_App.Entities;
using CS_App.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_App.AccountingSys
{
    internal class Accounts
    {
        /// <summary>
        /// Runtime will decide what type will be used for Employee and EmployeeLogic
        /// Dynamic Polymorphic Behavior
        /// 
        /// The GetNMetIncome() method will be used as Facade to Interact with the Employee Info System
        /// </summary>
        /// <param name="emp"></param>
        /// <param name="logic"></param>
        /// <returns></returns>
        public decimal GetNetIncome(Employee emp, EmployeeLogic logic)
        {
            decimal grossIncome = logic.GetIncome(emp);
            decimal tds = grossIncome  * Convert.ToDecimal(0.2);
            decimal netIncome = grossIncome - tds;
            return netIncome;
        }

    }
}
