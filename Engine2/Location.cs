using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Engine2
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Item ItemRequiredToEnter { get; set; }
        public Monstres MonsterLivingHere { get; set; }
        public Location LocationToNorth { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToSouth { get; set; }
        public Location LocationToWest { get; set; }
        public Quest QuestAvailableHere { get; set; }
        public Marchand MarchandTravailleIci { get; set; }

        public Location(int id, string name, string description, Item itemRequiredToEnter = null, Monstres monsterLivingHere = null, Quest questAvailableHere = null) 
        {
            ID = id;
            Name = name;
            Description = description;
            ItemRequiredToEnter = itemRequiredToEnter;
            MonsterLivingHere = monsterLivingHere;
            QuestAvailableHere = questAvailableHere;
            
         


        }

    }
}
