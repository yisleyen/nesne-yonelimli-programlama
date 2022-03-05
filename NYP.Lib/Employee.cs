using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP.Lib
{
    public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public bool Paid { get; set; }
        public Manager Manager { get; set; }

        public Employee(string name, int salary, Manager manager)
        {
            Name = name;
            Salary = salary;
            Manager = manager;
        }

        public virtual string Working()
        {
            return "Çalışıyorum";
        }
    }
}
