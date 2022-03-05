using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP.Lib
{
    public class DefensiveFootballer : Footballer
    {
        // Üst sınıftaki methodu ezmek için override anahtar sözcüğünü kullandık
        public override string Shoot()
        {
            return "Zayıf şut çekerim";
        }
    }
}
