using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine2
{
    public class Hirondelle : Item
    {
        
        public int Healing {  get; set; }

        public Hirondelle(int id,string name, string nameplural, int healing, int price ) : base(id,name,nameplural,price)
        {
          Healing = healing;

        }

    }
}
