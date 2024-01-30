using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Engine2
{
    public class Marchand
    {
        public string Name { get; set; }
        public BindingList <InventoryItem> Inventory { get;  private set; }

        public Marchand(string name) 
        {
            Name = name;
            Inventory = new BindingList<InventoryItem>();
        }

        public void AddItemToInventory(Item ItemToAdd, int quantity = 1)
        {
            InventoryItem Item = Inventory.SingleOrDefault(ii => ii.Details.ID == ItemToAdd.ID);

            if(Item == null)
            {
                // Si ils n'ont pas l'item, alors il l'ajoute
                Inventory.Add(new InventoryItem(ItemToAdd, quantity));
            }
            else
            {
                // Ils ont l'item dans leur inventaire, on augmente alors la quantité
                Item.Quantity += quantity;
            }
           OnPropertyChanged("Inventory");

        }

        public void RemoveItemToInventory(Item ItemToRemove, int quantity = 1)
        {
            InventoryItem Item = Inventory.SingleOrDefault(ii => ii.Details.ID == ItemToRemove.ID);

            if (Item == null)
            {
                // L'objet n'est pas dans inventaire du joueur.
                // Une erreur va probalbment se produire
            }
            else 
            {
                // Ils ont l'item danss leur inventaire, baisser la quantité
                Item.Quantity -= quantity;
                // ne pas autoriser les quantité négatives.
                if(Item.Quantity < 0)
                {
                    Item.Quantity = 0;
                }
                if(Item.Quantity == 0) 
                {

                    Inventory.Remove(Item);
                }
                OnPropertyChanged("Inventory");

            }

           
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));

            }

        }




    }
}
