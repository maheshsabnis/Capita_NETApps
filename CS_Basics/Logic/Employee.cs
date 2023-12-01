using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Basics.Logic
{
    /// <summary>
    /// Single Responsibility Principal
    /// The class MUST have all Members those are targetted to a specific requirements / funcationality 
    /// </summary>
    internal class Employee
    {
        int _EmpNo;
        string _EmpName;
        decimal _Salary;
        string _DeptName;

        public Employee(int eno, string ename, decimal sal)
        {
            _EmpNo = eno;
            _EmpName = ename;
            _Salary = sal;
        }

        public void GetEmp()
        {
            Console.WriteLine($"EmpNo : {_EmpNo}, EmpName : {_EmpName}, Salary : {_Salary}");
        }

    }
}
