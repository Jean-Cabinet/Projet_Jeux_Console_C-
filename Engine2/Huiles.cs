using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine2
{
    public class Huiles : Item
    {
        public int SuppDamage { get; set; }

        public Huiles(int suppdamage, int id, string name, string nameplural, int price) : base(id, name, nameplural, price)
        { 
           
            SuppDamage = suppdamage;

        }

    }
}
