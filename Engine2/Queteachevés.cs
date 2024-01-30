using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine2
{
    public class Queteacheve
    {
   
        
            public Item Details { get; set; }
            public int Quantity { get; set; }
            public Queteacheve(Item details, int quantity)
            {
                Details = details;
                Quantity = quantity;
            }
        


    }
}
