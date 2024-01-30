using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine2
{
    public class Item
    {
      public int ID { get; set; }
      public string Name { get; set; }
      public string Nameplural { get; set; }
      public int Price { get; set; }

        public Item(int id,string name, string nameplural, int price) 
        { 
            ID = id;
            Name = name;
            Nameplural = nameplural;
            Price = price;

        }

    }
}
