using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine2
{
    public class Quest
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardAffinité { get; set; }
        public int RewardGold { get; set; }
        public Item RewardItem { get; set; }
        public List<Queteacheve> queteacheve {get; set;}    
        public Quest(int id, string name, string description, int rewardAffinité, int rewardGold, Item rewardItem = null)
        {
            ID = id;
            Name = name;
            Description = description;
            RewardAffinité = rewardAffinité;
            RewardGold = rewardGold;
            RewardItem = rewardItem;
            queteacheve=new List<Queteacheve>();

        }


    }
}
