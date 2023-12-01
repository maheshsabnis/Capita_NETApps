using CS_App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_App.Logic
{
    internal class ManagerLogic : EmployeeLogic
    {
        public override void AddEmployee(Employee emp)
        {
            throw new NotImplementedException();
        }

        public override Employee[] GetEmployees()
        {
            throw new NotImplementedException();
        }

        public override decimal GetIncome(Employee emp)
        {
            return base.GetIncome(emp);
        }
    }
}
