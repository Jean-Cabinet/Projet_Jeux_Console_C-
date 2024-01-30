using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine2
{
    public class Flamberge : Item
    {
        
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        public int Riposte {  get; set; }

        public Flamberge(int minimunDamage, int maximunDamage, int id, string name, string nameplural, int riposte, int price) : base(id, name, nameplural, price)
        { 
            MinimumDamage = minimunDamage;
            MaximumDamage = maximunDamage;
            Riposte = riposte;
        }

    }
}
