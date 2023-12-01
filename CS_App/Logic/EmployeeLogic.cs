using CS_App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_App.Logic
{
    internal abstract class EmployeeLogic
    {

        public abstract void AddEmployee(Employee emp);
        public abstract Employee[] GetEmployees();
        
        public virtual decimal GetIncome(Employee emp)
        {
            return emp.Salary;
        }
    }
}
