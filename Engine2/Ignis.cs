using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine2
{
    public class Ignis : Sort
    {
        public int Damage {  get; set; }
        public int Brulurepercentage { get; set; }
        public int Damagebrulure {  get; set; }

        public Ignis(int damage, int brulurepercentage, int damagebrulure, int idsort, string namesort) : base(idsort,namesort)
        { 
            Damage = damage;
            Brulurepercentage = brulurepercentage;
            Damagebrulure = damagebrulure;
        }  


    }
}
