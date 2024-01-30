using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine2
{
    public class Quen:Sort
    {
        public int Utilisation {  get; set; }

        public Quen(int utilisation, int idsort, string namesort) : base(idsort, namesort)
        {
            Utilisation = utilisation;

        }


    }
}
