using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine2;

namespace RPG
{
    public partial class RPG : Form
    {
        private Edvars _Edvars;
        private Monstres _CurrentMonstres;
        public RPG()
        {
            InitializeComponent();
            _Edvars = new Edvars(0,10, 0, 1, 1, 50, 10, 10, 0, 12, 12);
            MoveTo(World.LocationByID(World.LOCATION_ID_AVALON));
            _Edvars.Inventory.Add(new InventoryItem(World.ItemByID(World.ITEM_ID_GWYNBLEIDD), 1));
            lblbourse.Text = _Edvars.Boursegold.ToString();
            lblexE.Text = _Edvars.PointexperienceEpargner.ToString();
            lblexS.Text = _Edvars.PointexperienceSacrifice.ToString();
            lbllevelE.Text = _Edvars.LevelEpargner.ToString();
            lbllevelS.Text = _Edvars.LevelSacrifice.ToString();
            lblpointvie.Text = _Edvars.Currentpointvie.ToString();
            lblignis.Text = _Edvars.Ignis.ToString();
            lblaffinité.Text = _Edvars.Affinité.ToString();







        }

        private void btnNord_Click(object sender, EventArgs e)
        {
            MoveTo(_Edvars.CurrentLocation.LocationToNorth);
        }

        private void btnEst_Click(object sender, EventArgs e)
        {
            MoveTo(_Edvars.CurrentLocation.LocationToEast);
        }

        private void btnSud_Click(object sender, EventArgs e)
        {
            MoveTo(_Edvars.CurrentLocation.LocationToSouth);
        }

        private void btnOuest_Click(object sender, EventArgs e)
        {
            MoveTo(_Edvars.CurrentLocation.LocationToWest);
        }

        private void btnUseFlamberges_Click(object sender, EventArgs e)
        {
            Flamberge CurrentFlamberge = (Flamberge)cboWeapons.SelectedItem;
            int DamageTomonster = RandomNumberGenerator.NumberBetween(CurrentFlamberge.MinimumDamage, CurrentFlamberge.MaximumDamage);
            _CurrentMonstres.Currentpointvie = _CurrentMonstres.Currentpointvie - (DamageTomonster - _CurrentMonstres.Défense);
            rtbMessage.Text += "You hit the " + _CurrentMonstres.Name + " for " + DamageTomonster.ToString() + " points." + Environment.NewLine;
            btnUseEpargner.Visible = false;
            btnUseSacrifice.Visible = false;
            if (_CurrentMonstres.Currentpointvie <= 0)
            {

                rtbMessage.Text += Environment.NewLine;
                rtbMessage.Text += "You defeated the " + _CurrentMonstres.Name + Environment.NewLine;
                btnUseEpargner.Visible = true;
                btnUseSacrifice.Visible = true;

                _Edvars.Boursegold += _CurrentMonstres.RewardGold;
                rtbMessage.Text += "You receive " + _CurrentMonstres.RewardGold.ToString() + " gold" + Environment.NewLine;

                List <InventoryItem> LootedItems = new List<InventoryItem>();

                foreach (LootItem lootItem in _CurrentMonstres.LootTable)
                {
                    if (RandomNumberGenerator.NumberBetween(1, 100) <= lootItem.DropPercentage)
                    {
                        LootedItems.Add(new InventoryItem(lootItem.Details, 1));
                    }

                }
                if(LootedItems.Count == 0)
                {
                    foreach (LootItem lootItems in _CurrentMonstres.LootTable)
                    {
                        if (lootItems.IsDefaultItem)
                        {
                            LootedItems.Add(new InventoryItem(lootItems.Details, 1));
                        }

                    }

                }
                foreach (InventoryItem inventoryItem in LootedItems)
                {
                    _Edvars.AddItemInventory(inventoryItem.Details);
                    if (inventoryItem.Quantity == 1)
                    {
                        rtbMessage.Text += "You loot " + inventoryItem.Quantity.ToString() + " " + inventoryItem.Details.Name + Environment.NewLine;
                    }
                    else
                    {
                        rtbMessage.Text += "You loot " + inventoryItem.Quantity.ToString() + " " + inventoryItem.Details.Nameplural + Environment.NewLine;
                    }
                }
                // Refresh player information and inventory controls
                lblpointvie.Text = _Edvars.Currentpointvie.ToString();
                lblbourse.Text = _Edvars.Boursegold.ToString();
                UpdateInventoryListUI();
                UpdatePotionsListUI();
                UpdateWeaponsListUI();
                // Add a blank line to the messages box, just for appearance.
                rtbMessage.Text += Environment.NewLine;
                // Move player to current location (to heal player and create a new monster to fight)
                MoveTo(_Edvars.CurrentLocation);


            }
            else
            {
                int DamageToEdvars = RandomNumberGenerator.NumberBetween(0, _CurrentMonstres.MaximumDamage);
                rtbMessage.Text += "The " + _CurrentMonstres.Name + " did " + DamageToEdvars.ToString() + " points of damage." + Environment.NewLine;

                _Edvars.Currentpointvie = _Edvars.Currentpointvie -(DamageToEdvars - _Edvars.Armure);
                lblpointvie.Text = _Edvars.Currentpointvie.ToString();
                if (_Edvars.Currentpointvie <= 0)
                {
                   
                    rtbMessage.Text += "The " + _CurrentMonstres.Name + " killed you." + Environment.NewLine;
                    
                    MoveTo(World.LocationByID(World.LOCATION_ID_AVALON));
                }


            }
            
        }
        
        

        private void btnUsesort_Click(object sender, EventArgs e)
        {
            Ignis CurrentIgnis = (Ignis)cboSort.SelectedItem;
            Quen CurrentQuen = (Quen)cboSort.SelectedItem;

           
            if( RandomNumberGenerator.NumberBetween(1,100)<= CurrentIgnis.Brulurepercentage)
            {
                int DamageTomonster = CurrentIgnis.Damage + CurrentIgnis.Damagebrulure;
                _CurrentMonstres.Currentpointvie = _CurrentMonstres.Currentpointvie - DamageTomonster;
                rtbMessage.Text += "You hit the " + _CurrentMonstres.Name + " for " + DamageTomonster.ToString() + " points." + Environment.NewLine;
            }
            else
            {
                int DamageTomonster = CurrentIgnis.Damage;
                _CurrentMonstres.Currentpointvie = _CurrentMonstres.Currentpointvie - DamageTomonster ;
                rtbMessage.Text += "You hit the " + _CurrentMonstres.Name + " for " + DamageTomonster.ToString() + " points." + Environment.NewLine;
            }
            if (_CurrentMonstres.Currentpointvie <= 0)
            {

                rtbMessage.Text += Environment.NewLine;
                rtbMessage.Text += "You defeated the " + _CurrentMonstres.Name + Environment.NewLine;
                btnUseEpargner.Visible = true;
                btnUseSacrifice.Visible = true;

                _Edvars.Boursegold += _CurrentMonstres.RewardGold;
                rtbMessage.Text += "You receive " + _CurrentMonstres.RewardGold.ToString() + " gold" + Environment.NewLine;

                List<InventoryItem> LootedItems = new List<InventoryItem>();

                foreach (LootItem lootItem in _CurrentMonstres.LootTable)
                {
                    if (RandomNumberGenerator.NumberBetween(1, 100) <= lootItem.DropPercentage)
                    {
                        LootedItems.Add(new InventoryItem(lootItem.Details, 1));
                    }

                }
                if (LootedItems.Count == 0)
                {
                    foreach (LootItem lootItems in _CurrentMonstres.LootTable)
                    {
                        if (lootItems.IsDefaultItem)
                        {
                            LootedItems.Add(new InventoryItem(lootItems.Details, 1));
                        }

                    }

                }
                foreach (InventoryItem inventoryItem in LootedItems)
                {
                    _Edvars.AddItemInventory(inventoryItem.Details);
                    if (inventoryItem.Quantity == 1)
                    {
                        rtbMessage.Text += "You loot " + inventoryItem.Quantity.ToString() + " " + inventoryItem.Details.Name + Environment.NewLine;
                    }
                    else
                    {
                        rtbMessage.Text += "You loot " + inventoryItem.Quantity.ToString() + " " + inventoryItem.Details.Nameplural + Environment.NewLine;
                    }
                }
                // Refresh player information and inventory controls
                lblpointvie.Text = _Edvars.Currentpointvie.ToString();
                lblbourse.Text = _Edvars.Boursegold.ToString();
                UpdateInventoryListUI();
                UpdatePotionsListUI();
                UpdateWeaponsListUI();
                // Add a blank line to the messages box, just for appearance.
                rtbMessage.Text += Environment.NewLine;
                // Move player to current location (to heal player and create a new monster to fight)
                MoveTo(_Edvars.CurrentLocation);


            }
            else
            {
               
                if (_Edvars.Currentpointvie > 0 && CurrentQuen.Utilisation < 2)
                {
                    int DamageToEdvars = RandomNumberGenerator.NumberBetween(0, 0);
                    rtbMessage.Text += "The " + _CurrentMonstres.Name + " did " + DamageToEdvars.ToString() + " points of damage." + Environment.NewLine;

                    _Edvars.Currentpointvie = _Edvars.Currentpointvie - DamageToEdvars ;
                    lblpointvie.Text = _Edvars.Currentpointvie.ToString();

                }
                if(_Edvars.Currentpointvie > 0)
                {
                    int DamageToEdvars = RandomNumberGenerator.NumberBetween(0, _CurrentMonstres.MaximumDamage);
                    rtbMessage.Text += "The " + _CurrentMonstres.Name + " did " + DamageToEdvars.ToString() + " points of damage." + Environment.NewLine;

                    _Edvars.Currentpointvie = _Edvars.Currentpointvie - (DamageToEdvars - _Edvars.Armure);
                    lblpointvie.Text = _Edvars.Currentpointvie.ToString();

                }
                if (_Edvars.Currentpointvie <= 0)
                {

                    rtbMessage.Text += "The " + _CurrentMonstres.Name + " killed you." + Environment.NewLine;

                    MoveTo(World.LocationByID(World.LOCATION_ID_AVALON));
                }


            }


        }

        private void btnUsepotions_Click(object sender, EventArgs e)
        {
            Hirondelle potion = (Hirondelle)cboPotions.SelectedItem;
            
            if(_Edvars.Currentpointvie > _Edvars.Maximunpointvie)
            {
                _Edvars.Currentpointvie = _Edvars.Maximunpointvie;

            }
            foreach(InventoryItem ii in _Edvars.Inventory)
            {
                if(ii.Details.ID == potion.ID)
                {
                    ii.Quantity -= ii.Quantity;
                    break;
                }
            }
            // Display message
            rtbMessage.Text += "You drink a " + potion.Name + Environment.NewLine;
            // Monster gets their turn to attack
            // Determine the amount of damage the monster does to the player
            int damageToPlayer = RandomNumberGenerator.NumberBetween(0, _CurrentMonstres.MaximumDamage);
            // Display message
            rtbMessage.Text += "The " + _CurrentMonstres.Name + " did " + damageToPlayer.ToString() + " points of damage." + Environment.NewLine;
            _Edvars.Currentpointvie -= damageToPlayer;
            if(_Edvars.Currentpointvie <= 0)
            {
                // Display message
                rtbMessage.Text += "The " + _CurrentMonstres.Name + " killed you." + Environment.NewLine;
                MoveTo(World.LocationByID(World.LOCATION_ID_AVALON));
            }
            lblpointvie.Text = _Edvars.Currentpointvie.ToString();  
            UpdateInventoryListUI();
            UpdatePotionsListUI();

        }

        private void MoveTo(Location newLocation)
        {
           
                if (!_Edvars.HasRequiredItemToEnterThisLocation(newLocation))
                {

                    rtbMessage.Text += "You must have a " + newLocation.ItemRequiredToEnter.Name + " to enter this location." + Environment.NewLine;
                    return;
                }



            _Edvars.CurrentLocation = newLocation;
            btnNord.Visible = (newLocation.LocationToNorth != null);
            btnEst.Visible = (newLocation.LocationToEast != null);
            btnSud.Visible = (newLocation.LocationToSouth != null);
            btnOuest.Visible = (newLocation.LocationToWest != null);

            rtbLocation.Text = newLocation.Name + Environment.NewLine;
            rtbLocation.Text += newLocation.Description + Environment.NewLine;

            _Edvars.Currentpointvie = _Edvars.Maximunpointvie;

            lblpointvie.Text = _Edvars.Currentpointvie.ToString();

            if (newLocation.QuestAvailableHere != null)
            {
                bool Edvarshasquest = false;
                bool Edvarshasalreadycompletequest = false;

                bool EdvarsAlreadyHasQuest = _Edvars.Edvarshasquest(newLocation.QuestAvailableHere);
                bool EdavrsAlreadyCompletedQuest = _Edvars.Completedthisquest(newLocation.QuestAvailableHere);

                if (Edvarshasquest)
                {
                    if (!Edvarshasalreadycompletequest)
                    {
                        // See if the player has all the items needed to complete the quest
                        bool EdvarsHasAllItemsToCompleteQuest = _Edvars.HasallQuestcompletionItem(newLocation.QuestAvailableHere);
                        // The player has all items required to complete the quest
                        if (EdvarsHasAllItemsToCompleteQuest)
                        {
                            rtbMessage.Text += Environment.NewLine;
                            rtbMessage.Text += "You complete the '" + newLocation.QuestAvailableHere.Name + "' quest." + Environment.NewLine;
                            
                            _Edvars.RemoveQuestcompletionItem(newLocation.QuestAvailableHere);
                            // Give quest rewards
                            rtbMessage.Text += "You receive: " + Environment.NewLine;
                            rtbMessage.Text += newLocation.QuestAvailableHere.RewardAffinité.ToString() + " experience points" + Environment.NewLine;
                            rtbMessage.Text += newLocation.QuestAvailableHere.RewardGold.ToString() + " gold" + Environment.NewLine;
                            rtbMessage.Text += newLocation.QuestAvailableHere.RewardItem.Name + Environment.NewLine;
                            rtbMessage.Text += Environment.NewLine;

                            _Edvars.Affinité += newLocation.QuestAvailableHere.RewardAffinité;
                            _Edvars.Boursegold += newLocation.QuestAvailableHere.RewardGold;


                        }



                        // They didn't have the item, so add it to their inventory, with a quantity of 1
                        _Edvars.AddItemInventory(newLocation.QuestAvailableHere.RewardItem);

                        // Mark the quest as completed
                        // Find the quest in the player's quest list
                       _Edvars.MarkQuestCompleted(newLocation.QuestAvailableHere);  
                    }
                }
            }
            else
            {
                // The player does not already have the quest

              // Display the messages
                
                rtbMessage.Text  = "You receive the " + newLocation.QuestAvailableHere.Name + " quest." + Environment.NewLine;
                rtbMessage.Text += newLocation.QuestAvailableHere.Description + Environment.NewLine;
                rtbMessage.Text += "To complete it, return with:" + Environment.NewLine;
               foreach (Queteacheve qci in newLocation.QuestAvailableHere.queteacheve)
               {
                  if (qci.Quantity == 1)
                  {
                      rtbMessage.Text += qci.Quantity.ToString() + " " + qci.Details.Name + Environment.NewLine;
                  }
                  else
                  {
                      rtbMessage.Text += qci.Quantity.ToString() + " " + qci.Details.Nameplural + Environment.NewLine;
                  }
               }
                rtbMessage.Text += Environment.NewLine;

                // Add the quest to the player's quest list
                _Edvars.Quests.Add(new EdvarsQuest(newLocation.QuestAvailableHere));
            }
            // Does the location have a monster?
            if (newLocation.MonsterLivingHere != null)
            {
                rtbMessage.Text += "You see a " + newLocation.MonsterLivingHere.Name + Environment.NewLine;

                // Make a new monster, using the values from the standard monster in the World.Monster list
                Monstres standardMonster = World.MonstreByID(newLocation.MonsterLivingHere.ID);

                _CurrentMonstres = new Monstres(standardMonster.ID, standardMonster.Name, standardMonster.MaximumDamage,
                     standardMonster.RewardGold, standardMonster.Défense,standardMonster.RewardexperienceSacrifice,standardMonster.RewardexperienceEpargner,standardMonster.Riposte, standardMonster.Currentpointvie, standardMonster.Maximunpointvie);

                foreach (LootItem lootItem in standardMonster.LootTable)
                {
                    _CurrentMonstres.LootTable.Add(lootItem);
                }

                cboWeapons.Visible = true;
                cboPotions.Visible = true;
                btnUseWeapons.Visible = true;
                btnUsePotions.Visible = true;

            }
            else
            {
                _CurrentMonstres = null;

                cboWeapons.Visible = false;
                cboPotions.Visible = false;
                btnUseWeapons.Visible = false;
                btnUsePotions.Visible = false;
            }

            // Refresh player's inventory list
            UpdateInventoryListUI();
            // Refresh player's quest list
            UpdateQuestListUI();
            // Refresh player's weapons combobox
            UpdateWeaponsListUI();
            // Refresh player's potions combobox
            UpdatePotionsListUI();

        }

        private void UpdateInventoryListUI()
        {
            dgvInventory.RowHeadersVisible = false;

            dgvInventory.ColumnCount = 2;
            dgvInventory.Columns[0].Name = "Name";
            dgvInventory.Columns[0].Width = 197;
            dgvInventory.Columns[1].Name = "Quantity";

            dgvInventory.Rows.Clear();

            foreach(InventoryItem ii in _Edvars.Inventory)
            {
                if (ii.Quantity > 0)
                {
                    dgvInventory.Rows.Add(new[] { ii.Details.Name, ii.Quantity.ToString() });
                }

            }

        }

        private void UpdateQuestListUI()
        {
            dgvQuests.RowHeadersVisible = false;

            dgvQuests.ColumnCount = 2;
            dgvQuests.Columns[0].Name = "Name";
            dgvQuests.Columns[0].Width = 197;
            dgvQuests.Columns[1].Name = "Done?";

            dgvQuests.Rows.Clear();

            foreach (EdvarsQuest EdvarsQuest in _Edvars.Quests)
            {
                dgvQuests.Rows.Add(new[] { EdvarsQuest.Details.Name, EdvarsQuest.IsCompleted.ToString() });
            }




        }

        private void UpdateWeaponsListUI()
        {
            List<Flamberge> Flamberges = new List<Flamberge>();

            foreach (InventoryItem inventoryItem in _Edvars.Inventory)
            {
                if (inventoryItem.Details is Flamberge)
                {
                    if (inventoryItem.Quantity > 0)
                    {
                        Flamberges.Add((Flamberge)inventoryItem.Details);
                    }
                }
            }

            if (Flamberges.Count == 0)
            {
                // The player doesn't have any Flamberges, so hide the Flamberge combobox and "Use" button
                cboWeapons.Visible = false;
                btnUseWeapons.Visible = false;
            }
            else
            {
                cboWeapons.DataSource = Flamberges;
                cboWeapons.DisplayMember = "Name";
                cboWeapons.ValueMember = "ID";

                cboWeapons.SelectedIndex = 0;
            }
        }

        private void UpdatePotionsListUI()
        {
            List<Hirondelle> healingPotions = new List<Hirondelle>();

            foreach (InventoryItem inventoryItem in _Edvars.Inventory)
            {
                if (inventoryItem.Details is Hirondelle)
                {
                    if (inventoryItem.Quantity > 0)
                    {
                        healingPotions.Add((Hirondelle)inventoryItem.Details);
                    }
                }
            }

            if (healingPotions.Count == 0)
            {
                // The player doesn't have any potions, so hide the potion combobox and "Use" button
                cboPotions.Visible = false;
                btnUsePotions.Visible = false;
            }
            else
            {
                cboPotions.DataSource = healingPotions;
                cboPotions.DisplayMember = "Name";
                cboPotions.ValueMember = "ID";

                cboPotions.SelectedIndex = 0;
            }


        }

        private void btnUseSacrifice_Click(object sender, EventArgs e)
        {
            btnUseEpargner.Visible = false;
            btnUseSacrifice.Visible = false;
            if (_CurrentMonstres.Currentpointvie <= 0)
            {

                
                btnUseEpargner.Visible = true;
                btnUseSacrifice.Visible = true;



            }

        }

        private void btnUseEpargner_Click(object sender, EventArgs e)
        {
            btnUseEpargner.Visible = false;
            btnUseSacrifice.Visible = false;
            if (_CurrentMonstres.Currentpointvie <= 0)
            {

                
                btnUseEpargner.Visible = true;
                btnUseSacrifice.Visible = true;


            }

        }

        private void btnUseHuiles_Click(object sender, EventArgs e)
        {
            Huiles huile = (Huiles)cbohuiles.SelectedItem;
            Flamberge CurrentFlamberge = (Flamberge)cboWeapons.SelectedItem;
            int DamageTomonster = RandomNumberGenerator.NumberBetween(CurrentFlamberge.MinimumDamage, CurrentFlamberge.MaximumDamage) + huile.SuppDamage;
            _CurrentMonstres.Currentpointvie = _CurrentMonstres.Currentpointvie - DamageTomonster;
            rtbMessage.Text += "You hit the " + _CurrentMonstres.Name + " for " + DamageTomonster.ToString() + " points." + Environment.NewLine;
            foreach (InventoryItem ii in _Edvars.Inventory)
            {
                if (ii.Details.ID == huile.ID)
                {
                    ii.Quantity -= ii.Quantity;
                    break;
                }
            }
            // Display message
            rtbMessage.Text += "You apply a " + huile.Name + Environment.NewLine;
            if (_CurrentMonstres.Currentpointvie <= 0)
            {

                rtbMessage.Text += Environment.NewLine;
                rtbMessage.Text += "You defeated the " + _CurrentMonstres.Name + Environment.NewLine;
                btnUseEpargner.Visible = true;
                btnUseSacrifice.Visible = true;

                _Edvars.Boursegold += _CurrentMonstres.RewardGold;
                rtbMessage.Text += "You receive " + _CurrentMonstres.RewardGold.ToString() + " gold" + Environment.NewLine;

                List<InventoryItem> LootedItems = new List<InventoryItem>();

                foreach (LootItem lootItem in _CurrentMonstres.LootTable)
                {
                    if (RandomNumberGenerator.NumberBetween(1, 100) <= lootItem.DropPercentage)
                    {
                        LootedItems.Add(new InventoryItem(lootItem.Details, 1));
                    }

                }
                if (LootedItems.Count == 0)
                {
                    foreach (LootItem lootItems in _CurrentMonstres.LootTable)
                    {
                        if (lootItems.IsDefaultItem)
                        {
                            LootedItems.Add(new InventoryItem(lootItems.Details, 1));
                        }

                    }

                }
                foreach (InventoryItem inventoryItem in LootedItems)
                {
                    _Edvars.AddItemInventory(inventoryItem.Details);
                    if (inventoryItem.Quantity == 1)
                    {
                        rtbMessage.Text += "You loot " + inventoryItem.Quantity.ToString() + " " + inventoryItem.Details.Name + Environment.NewLine;
                    }
                    else
                    {
                        rtbMessage.Text += "You loot " + inventoryItem.Quantity.ToString() + " " + inventoryItem.Details.Nameplural + Environment.NewLine;
                    }
                }
                // Refresh player information and inventory controls
                lblpointvie.Text = _Edvars.Currentpointvie.ToString();
                lblbourse.Text = _Edvars.Boursegold.ToString();
                UpdateInventoryListUI();
                UpdatePotionsListUI();
                UpdateWeaponsListUI();
                // Add a blank line to the messages box, just for appearance.
                rtbMessage.Text += Environment.NewLine;
                // Move player to current location (to heal player and create a new monster to fight)
                MoveTo(_Edvars.CurrentLocation);


            }
            else
            {
                int DamageToEdvars = RandomNumberGenerator.NumberBetween(0, _CurrentMonstres.MaximumDamage);
                rtbMessage.Text += "The " + _CurrentMonstres.Name + " did " + DamageToEdvars.ToString() + " points of damage." + Environment.NewLine;

                _Edvars.Currentpointvie = _Edvars.Currentpointvie - (DamageToEdvars - _Edvars.Armure);
                lblpointvie.Text = _Edvars.Currentpointvie.ToString();
                if (_Edvars.Currentpointvie <= 0)
                {

                    rtbMessage.Text += "The " + _CurrentMonstres.Name + " killed you." + Environment.NewLine;

                    MoveTo(World.LocationByID(World.LOCATION_ID_AVALON));
                }


            }




        }

        private void btnEchange_Click(object sender, EventArgs e)
        {
          EchangeMarchand echangeMarchand = new EchangeMarchand();
          echangeMarchand.StartPosition = FormStartPosition.CenterScreen;
          echangeMarchand.CurrentEdvars = _Edvars;
          echangeMarchand.ShowDialog(this);

        }
    }
    
}

           
