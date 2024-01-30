using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Engine2
{
    public static class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monstres> Monstre = new List<Monstres>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();
        public static readonly List<Sort> Sorts = new List<Sort>();
        public const int ITEM_ID_GWYNBLEIDD = 1;
        public const int ITEM_ID_EYE_MONSTRE = 2;
        public const int ITEM_ID_MOELLE_PUTREFIE = 3;
        public const int ITEM_ID_SPECTRE_POWDER = 4;
        public const int ITEM_ID_SPECTRE_ECTOPLASM = 5;
        public const int ITEM_ID_HIRONDELLE = 7;
        public const int ITEM_ID_HUILES = 10;
        public const int ITEM_ID_LESHEN_RESIN = 8;
        public const int ITEM_ID_LESHEN_SOUL = 9;
        public const int ITEM_ID_EDVARS_PASS = 10;
        public const int SORT_ID_IGNIS = 12;
        public const int SORT_ID_QUEN = 13; 
        public const int MONSTRE_ID_GOULE = 1;
        public const int MONSTRE_ID_SPECTRE = 2;
        public const int MONSTRE_ID_LESHEN = 3;
        public const int QUEST_ID_CLEAR_FOREST = 1;
        public const int QUEST_ID_CLEAR_WAR_FIELD = 2;
        public const int LOCATION_ID_AVALON = 1;
        public const int LOCATION_ID_NOVIGRAD = 2;
        public const int LOCATION_ID_GUARD_POST = 3;
        public const int LOCATION_ID_HAUNTED_HOUSE = 4;
        public const int LOCATION_ID_MILITARY_CAMP = 5;
        public const int LOCATION_ID_VILLAGE = 6;
        public const int LOCATION_ID_FOREST = 7;
        public const int LOCATION_ID_WAR_FIELD = 8;
        public const int LOCATION_ID_BRIDGE = 11;
        public const int UNSELLABLE_ITEM_PRICE = -1;

        static World()
        {
            PopulateItems();
            PopulateMonstre();
            PopulateQuests();
            PopulateLocations();
            PopulateSorts();
        }
        private static void PopulateSorts()
        {
            Sorts.Add(new Ignis(10,50,2,12,"Ignis"));
            Sorts.Add(new Quen(2,13,"Quen"));

        }
        private static void PopulateItems()
        {
            Items.Add(new Flamberge(1,5, ITEM_ID_GWYNBLEIDD,"Gwynbleidd","Gwynbleidd",5,10));
            Items.Add(new Item(ITEM_ID_EYE_MONSTRE,"oeil de monstre","yeux de monstre",15));
            Items.Add(new Item(ITEM_ID_MOELLE_PUTREFIE, "moelle putréfié", "moelles putréfiés",5));
            Items.Add(new Item(ITEM_ID_SPECTRE_POWDER, "poudre de spectre","poudres de spectre", 15));
            Items.Add(new Item(ITEM_ID_SPECTRE_ECTOPLASM,"ectoplasme","ectoplasmes", 15));
            Items.Add(new Hirondelle(ITEM_ID_HIRONDELLE, "Hirondelle", "Hirondelles",10, UNSELLABLE_ITEM_PRICE));
            Items.Add(new Item(ITEM_ID_LESHEN_RESIN, "Résine de leshen", "Résines de leshen", 40));
            Items.Add(new Item(ITEM_ID_LESHEN_SOUL, "ame de leshen", "ames de leshens", 60));
            Items.Add(new Item(ITEM_ID_EDVARS_PASS,"laisser-passer d'edvars","laisser-passer d'edvars", UNSELLABLE_ITEM_PRICE));
            Items.Add(new Huiles(10,ITEM_ID_HUILES,"Huile","Huiles", UNSELLABLE_ITEM_PRICE));
            
        }
        private static void PopulateMonstre()
        {
            Monstres Goule = new Monstres(MONSTRE_ID_GOULE, "Goule", 5, 0, 5, 3, 3,7,10,10);
            Goule.LootTable.Add(new LootItem(ItemByID(ITEM_ID_EYE_MONSTRE), 75, false));
            Goule.LootTable.Add(new LootItem(ItemByID(ITEM_ID_MOELLE_PUTREFIE), 75, true));
            Monstres Spectre = new Monstres(MONSTRE_ID_SPECTRE, "Spectre", 5, 0,9, 5, 5,10,15,15);
            Spectre.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPECTRE_POWDER), 75, false));
            Spectre.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPECTRE_ECTOPLASM), 75, true));
            Monstres Leshen = new Monstres(MONSTRE_ID_LESHEN, "Leshen", 20, 0, 12, 20, 20,22,30,30);
            Leshen.LootTable.Add(new LootItem(ItemByID(ITEM_ID_LESHEN_RESIN), 75, true));
            Leshen.LootTable.Add(new LootItem(ItemByID(ITEM_ID_LESHEN_SOUL), 25, false));
            Monstre.Add(Goule);
            Monstre.Add(Spectre);
            Monstre.Add(Leshen);





        }
        private static void PopulateQuests()
        {
            Quest clearForest =
              new Quest(
                  QUEST_ID_CLEAR_FOREST,
                  "Kill the monster in forest",
                  "Kill monster in forest and bring back his soul. You will receive a healing potion and 10 gold pieces.", 20, 10);
            clearForest.queteacheve.Add(new Queteacheve(ItemByID(ITEM_ID_LESHEN_SOUL), 1));
            clearForest.RewardItem = ItemByID(ITEM_ID_HIRONDELLE);
            Quest clearWarfield =
                new Quest(
                    QUEST_ID_CLEAR_WAR_FIELD,
                    "Clear the War Field",
                    "Kill goule in the war's field and bring back 3 monsters eyes. You will receive an adventurer's pass and 20 gold pieces.", 20, 20);
            clearWarfield.queteacheve.Add(new Queteacheve(ItemByID(ITEM_ID_EYE_MONSTRE), 3));
            clearWarfield.RewardItem = ItemByID(ITEM_ID_EDVARS_PASS);
            Quests.Add(clearForest);
            Quests.Add(clearWarfield);

        }
        private static void PopulateLocations()
        {
            // Create each location
            Location Avalon = new Location(LOCATION_ID_AVALON, "Avalon mordhen", "@\"C'est endroit est une des guildes des croiseleurs. Vous etes actuellement dans votre chambre de dortoir,\r\nvous faites partie de l'école du loup une des 4 écoles de la guilde");
            Location Novigrad = new Location(LOCATION_ID_NOVIGRAD, "Novigrad", " Vous voyez une d'énormes murailles se dréssé devant vous, à l'intérieur de la ville, le habitant vous dévisage");
            Marchand Hattori = new Marchand("Hattori");
            Hattori.AddItemToInventory(ItemByID(ITEM_ID_EYE_MONSTRE), 5);
            Hattori.AddItemToInventory(ItemByID(ITEM_ID_MOELLE_PUTREFIE),4);
            Novigrad.MarchandTravailleIci = Hattori;
            Location village = new Location(LOCATION_ID_VILLAGE, "village", "Un simple village de paysan");
            village.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_FOREST);
            Location Forest = new Location(LOCATION_ID_FOREST, "Foret", "Une foret assez lugubre, ou les arbres laisse peut d'espace pour passer. Vous vous sentez étouffé");
            Forest.MonsterLivingHere = MonstreByID(MONSTRE_ID_LESHEN);
            Location Militarycamp = new Location(LOCATION_ID_MILITARY_CAMP, "camp militaire", "L'empire des envahisseurs, ont dréssé un camp, vous allez y jeter un coup d'oeil");
            Militarycamp.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_WAR_FIELD);
            Location Warfield = new Location(LOCATION_ID_WAR_FIELD, "Champ de bataille", "Vous voyez des tonnes de cadavres, qui ont du propablement attiré des goules");
            Warfield.MonsterLivingHere = MonstreByID(MONSTRE_ID_GOULE);
            Location guardPost = new Location(LOCATION_ID_GUARD_POST, "poste de garde", "Il y a ici un grand garde à l'allure robuste.", ItemByID(ITEM_ID_EDVARS_PASS));
            Location bridge = new Location(LOCATION_ID_BRIDGE, "Pont", "Un point en bois permettant de traverser la rivière");
            Location hauntedhouse = new Location(LOCATION_ID_HAUNTED_HOUSE, "Un chateau hanté", "Vous entendez des cris d'effrois dans le chateau qui glacerait le sang de n'importe quel humain");
            hauntedhouse.MonsterLivingHere = MonstreByID(MONSTRE_ID_SPECTRE);
            // Link the locations together
            Avalon.LocationToNorth = Novigrad;
            Novigrad.LocationToNorth = village;
            Novigrad.LocationToSouth = Avalon;
            Novigrad.LocationToEast = guardPost;
            Novigrad.LocationToWest = Militarycamp;
            Militarycamp.LocationToEast = Novigrad;
            Militarycamp.LocationToWest = Warfield;
            Warfield.LocationToEast = Militarycamp;
            village.LocationToSouth = Novigrad;
            village.LocationToNorth = Forest;
            Forest.LocationToSouth = village;
            guardPost.LocationToEast = bridge;
            guardPost.LocationToWest = Novigrad;
            bridge.LocationToWest = guardPost;
            bridge.LocationToEast = hauntedhouse;
            hauntedhouse.LocationToWest = bridge;
            // Add the locations to the static list
            Locations.Add(Avalon);
            Locations.Add(Novigrad);
            Locations.Add(guardPost);
            Locations.Add(village);
            Locations.Add(Forest);
            Locations.Add(Militarycamp);
            Locations.Add(Warfield);
            Locations.Add(bridge);
            Locations.Add(hauntedhouse);

        }
        public static Item ItemByID(int id)
        {
            foreach (Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }
            return null;
        }
        public static Monstres MonstreByID(int id)
        {
            foreach (Monstres Monstre in Monstre)
            {
                if (Monstre.ID == id)
                {
                    return Monstre;
                }
            }
            return null;
        }
        public static Quest QuestByID(int id)
        {
            foreach (Quest quest in Quests)
            {
                if (quest.ID == id)
                {
                    return quest;
                }
            }
            return null;
        }
        public static Location LocationByID(int id)
        {
            foreach (Location location in Locations)
            {
                if (location.ID == id)
                {
                    return location;
                }
            }
            return null;
        }
    }
}

    

