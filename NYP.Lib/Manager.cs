using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP.Lib
{
    public class Manager : Employee
    {
        public List<Employee>? employees;
        public bool BossPaid = false;
        public decimal totalPayableSalary { get; set; }
        public Manager(string name, int salary, Manager manager)
            : base(name, salary, manager)
        {
            employees = new List<Employee>();
        }

        public int SalaryTotal()
        {
            return employees.Sum(i => i.Salary);
        }

        public void DistributeSalaries()
        {
            foreach (var employee in employees)
            {
                if (totalPayableSalary > 0)
                {
                    totalPayableSalary -= employee.Salary;
                    employee.Paid = true;
                }
            }
        }
    }
}
