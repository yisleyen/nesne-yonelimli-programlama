using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP.Lib
{
    public class Analyst : Employee
    {
        public Analyst(string name, int salary, Manager manager)
            : base(name, salary, manager)
        {

        }

        public override string Working()
        {
            return "Analist";
        }
    }
}
