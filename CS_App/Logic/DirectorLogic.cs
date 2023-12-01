using CS_App.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_App.Logic
{
    internal  class DirectorLogic : EmployeeLogic
    {
        // Local In-memory Data Store

        ArrayList directors = new ArrayList();

        public override void AddEmployee(Employee emp)
        {
            directors.Add((Director)emp);
        }

        public override Employee[] GetEmployees()
        {
            var data = new Employee[directors.Count];
            int i = 0;
            foreach (var dir in directors)
            {
                data[i] = (Director)dir;
                i++;
            }
            return data;
        }

        public override decimal GetIncome(Employee emp)
        {
            Director director = (Director)emp;
            //director.HRA = 500;
            //director.MobileAllowance = 700;

            decimal totalIncome = director.Salary + director.HRA + director.MobileAllowance;

           return totalIncome;
        }

    }
}
