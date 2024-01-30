using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine2
{
    public class Edvars : Creaturevivante
    {

      
        public int PointexperienceSacrifice { get; set; }
        public int PointexperienceEpargner { get; set; }
        public int LevelSacrifice { get; set; }
        public int LevelEpargner { get; set; }
        public int Boursegold { get; set; }
        public int Ignis {  get; set; }
        public int Quen {  get; set; }
        public int Affinité { get; set; }
        public int Armure { get; set; }
        public Location CurrentLocation { get; set; }
        public List<InventoryItem> Inventory { get; set; }
        public List <EdvarsQuest> Quests { get; set; } 
        public List <InventorySort> RouedesSorts { get; set; }
        



        public Edvars(int pointexperienceSacrifice, int armure, int pointexperienceEpargner, int levelSacrifice, int levelEpargner, int boursegold, int ignis, int quen, int affinité, int currentpointdevie, int maximunpointdevie) : base(currentpointdevie, maximunpointdevie)
        {
            PointexperienceEpargner = pointexperienceEpargner;
            PointexperienceSacrifice = pointexperienceSacrifice;
            LevelEpargner = levelEpargner;
            LevelSacrifice = levelSacrifice;
            Boursegold = boursegold;
            Ignis = ignis;
            Quen = quen;
            Affinité = affinité;
            Armure = armure;
            Quests = new List<EdvarsQuest>();
            Inventory = new List<InventoryItem>();
            RouedesSorts = new List<InventorySort>();
            
        }
        public bool HasRequiredItemToEnterThisLocation(Location location)
        {
            if(location.ItemRequiredToEnter == null)
            {
                return true;


            }
            foreach (InventoryItem ii in Inventory)
            {
                if(ii.Details.ID == location.ItemRequiredToEnter.ID)
                {
                    return true;
                }

            }
            return false;

        }

        public bool Edvarshasquest(Quest quest)
        {
            foreach (EdvarsQuest Equest in Quests)
            {
                if (Equest.Details.ID == quest.ID)
                {
                    return true;
                }

            }
            return false;

        }
        public bool Completedthisquest(Quest quest)
        {
            foreach(EdvarsQuest Equest in Quests)
            {
                if(Equest.Details.ID == quest.ID)
                {
                    return Equest.IsCompleted;
                }
            }
            return false;

        }


        public bool HasallQuestcompletionItem(Quest quest)
        {
            foreach(Queteacheve qca in quest.queteacheve)
            {
                bool foundItemInPlayersInventory = false;

                foreach(InventoryItem ii in Inventory)
                {
                    if(ii.Details.ID == qca.Details.ID)
                    {
                        foundItemInPlayersInventory = true;

                        if(ii.Quantity < qca.Quantity)
                        {
                            return false;
                        }

                    }

                }
                if (!foundItemInPlayersInventory)
                {
                    return false;

                }
            }
           return true;

        }

        public void RemoveQuestcompletionItem(Quest quest)
        {
            foreach(Queteacheve qci in quest.queteacheve)
            {
                foreach (InventoryItem ii in Inventory)
                {
                    if (ii.Details.ID == qci.Details.ID)
                    {
                        ii.Quantity -= qci.Quantity;
                        break;
                    }

                }

            }

           

        }

        public void AddItemInventory(Item itemtoadd)
        {
            foreach(InventoryItem ii in Inventory)
            {
                if(ii.Details.ID == itemtoadd.ID)
                {
                    ii.Quantity++;
                    return;
                }

            }
            Inventory.Add(new InventoryItem(itemtoadd,1));
        }

        public void MarkQuestCompleted(Quest quest)
        {
            foreach(EdvarsQuest qce in Quests)
            {

                if(qce.Details.ID == quest.ID)
                {
                    qce.IsCompleted = true;
                    return;
                }

            }

        }






    }
}
