using System;
using System.Collections.Generic;
using System.Text;

namespace _14JunePractiseP227.Classes
{
    public class Company
    {
        public Employee[] Employees = new Employee[0];
        public int EmployeeLimit;


        public void AddEmployee(Employee employee)
        {
            if (EmployeeLimit>Employees.Length)
            {
                Array.Resize(ref Employees, Employees.Length + 1);
                Employees[Employees.Length - 1] = employee;
            }
        }


        public Employee[] SearchEmployees(string search)
        {
            Employee[] filteredEmps = new Employee[0];

            for (int i = 0; i < Employees.Length; i++)
            {
                if (Employees[i].FullName.ToLower().Contains(search.ToLower()))
                {
                    Array.Resize(ref filteredEmps, filteredEmps.Length + 1);
                    filteredEmps[filteredEmps.Length - 1] = Employees[i];
                }
            }
            
            return filteredEmps;
        }
    }
}
