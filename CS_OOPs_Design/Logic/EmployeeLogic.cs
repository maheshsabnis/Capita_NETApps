using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_OOPs_Design.Entities;

namespace CS_OOPs_Design.Logic
{
    /// <summary>
    /// SRP : For Employee Operations 
    /// </summary>
    internal class EmployeeLogic
    {
        // Define a Data Store
        Employee[] employees;
        int count = 0;
        public EmployeeLogic()
        {
            // Issue: 1 Fix Size for Array Data Store, may result into app crash if the Array is not filled witrh its complete size  
            employees = new Employee[3];
        }

        public Employee[] GetEmployees() 
        {
            return employees;
        }

        public Employee GetEmployee(int id)
        {
            Employee employee = null;

            foreach (Employee e in employees) 
            {
                if(e.EmpNo == id)
                { employee = e; break; }
            }
            return employee;
        }


        public void AddEmployee(Employee employee) 
        {
            if (employee.Salary <= 0)
                return;
            employees[count++] = employee;
        }



        public void RemoveEmployee(Employee employee) 
        {
            // (YOUR HEDACHE) Logic for Remove Employee from Array
        }

        public void UpdateEmployee(int id, Employee employee)
        {
            // (YOUR HEDACHE) Logic for Update
        }

        public decimal GetIncome()
        {
            return 0;
        }


    }
}
