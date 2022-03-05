using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP.Lib
{
    public class Footballer : Human
    {
        public List<string>? TeamsPlayed { get; set; }

        // Alt sınıftan ezilmesine izin vermek için virtual anahtar sözcüğünü kullandık
        public virtual string Shoot()
        {
            return "Şut çekerim";
        }
    }
}
