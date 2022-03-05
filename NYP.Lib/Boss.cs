using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP.Lib
{
    public class Boss
    {
        public List<Manager> ManagerList;
        private int totalSalary = 0;
        public Boss()
        {
            ManagerList = new List<Manager>();
        }
        public Boss(Manager manager)
        {
            ManagerList = new List<Manager>();
            ManagerList.Add(manager);
        }
        public void TotalSalaryFind()
        {
            totalSalary = ManagerList.Sum(i => i.Salary) + ManagerList.Sum(i => i.SalaryTotal());
        }
        public void DistributeSalaries()
        {
            foreach (var manager in ManagerList)
            {
                totalSalary -= manager.Salary;
                manager.Paid = true;

                int employeeSalary = manager.SalaryTotal();
                totalSalary -= employeeSalary;
                manager.totalPayableSalary = employeeSalary;
                manager.BossPaid = true;
            }
        }
    }
}
