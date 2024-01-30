using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine2
{
    public class Sort
    {
        public int IDSort { get; set; }
        public string NameSort { get; set; }

        public Sort(int idsort, string namesort)
        {
           IDSort = idsort;
           NameSort = namesort;

        }

    }
}
