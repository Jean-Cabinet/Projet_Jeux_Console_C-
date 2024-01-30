using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine2
{
    public class Monstres : Creaturevivante
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardGold { get; set; }
        public int Défense { get; set; }
        public int RewardexperienceSacrifice { get; set; }
        public int RewardexperienceEpargner { get; set; }
        public int Riposte { get; set; }
        public List<LootItem> LootTable { get; set; }

        public Monstres(int id, string name, int maximunDamage, int rewardGold, int défense, int rewardexperienceSacrifice, int rewardexpérienceEpargner, int riposte, int currentpointdevie, int maximunpointdevie) : base(currentpointdevie, maximunpointdevie)
        {
            ID = id;
            Name = name;
            MaximumDamage = maximunDamage;
            RewardGold = rewardGold;
            Défense = défense;
            RewardexperienceEpargner = rewardexperienceSacrifice;
            RewardexperienceSacrifice = rewardexperienceSacrifice;
            Riposte = riposte;
            LootTable = new List<LootItem>();
        }

    }
}
