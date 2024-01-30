using System.Windows.Forms;

namespace RPG
{
    partial class RPG
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblpointvie = new System.Windows.Forms.Label();
            this.lblarmure = new System.Windows.Forms.Label();
            this.lblignis = new System.Windows.Forms.Label();
            this.lblquen = new System.Windows.Forms.Label();
            this.lblcomptence = new System.Windows.Forms.Label();
            this.lblexS = new System.Windows.Forms.Label();
            this.lblexE = new System.Windows.Forms.Label();
            this.lbllevelS = new System.Windows.Forms.Label();
            this.lbllevelE = new System.Windows.Forms.Label();
            this.lblbourse = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblaffinité = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cboWeapons = new System.Windows.Forms.ComboBox();
            this.cboPotions = new System.Windows.Forms.ComboBox();
            this.cboSort = new System.Windows.Forms.ComboBox();
            this.btnUseWeapons = new System.Windows.Forms.Button();
            this.btnUsePotions = new System.Windows.Forms.Button();
            this.btnUseSort = new System.Windows.Forms.Button();
            this.btnNord = new System.Windows.Forms.Button();
            this.btnSud = new System.Windows.Forms.Button();
            this.btnEst = new System.Windows.Forms.Button();
            this.btnOuest = new System.Windows.Forms.Button();
            this.rtbLocation = new System.Windows.Forms.RichTextBox();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.dgvQuests = new System.Windows.Forms.DataGridView();
            this.cbohuiles = new System.Windows.Forms.ComboBox();
            this.btnUseSacrifice = new System.Windows.Forms.Button();
            this.btnUseEpargner = new System.Windows.Forms.Button();
            this.btnUseHuiles = new System.Windows.Forms.Button();
            this.btnEchange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Point de vie :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Armure :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ignis :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quen ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Compétence :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ExpérienceSacrifice :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "ExpérienceEpargner :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 466);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "LevelSacrifice :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 496);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "LevelEpargner :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Bourse :";
            // 
            // lblpointvie
            // 
            this.lblpointvie.AutoSize = true;
            this.lblpointvie.Location = new System.Drawing.Point(88, 69);
            this.lblpointvie.Name = "lblpointvie";
            this.lblpointvie.Size = new System.Drawing.Size(0, 13);
            this.lblpointvie.TabIndex = 10;
            // 
            // lblarmure
            // 
            this.lblarmure.AutoSize = true;
            this.lblarmure.Location = new System.Drawing.Point(63, 100);
            this.lblarmure.Name = "lblarmure";
            this.lblarmure.Size = new System.Drawing.Size(0, 13);
            this.lblarmure.TabIndex = 11;
            // 
            // lblignis
            // 
            this.lblignis.AutoSize = true;
            this.lblignis.Location = new System.Drawing.Point(56, 272);
            this.lblignis.Name = "lblignis";
            this.lblignis.Size = new System.Drawing.Size(0, 13);
            this.lblignis.TabIndex = 12;
            // 
            // lblquen
            // 
            this.lblquen.AutoSize = true;
            this.lblquen.Location = new System.Drawing.Point(59, 301);
            this.lblquen.Name = "lblquen";
            this.lblquen.Size = new System.Drawing.Size(0, 13);
            this.lblquen.TabIndex = 13;
            // 
            // lblcomptence
            // 
            this.lblcomptence.AutoSize = true;
            this.lblcomptence.Location = new System.Drawing.Point(93, 327);
            this.lblcomptence.Name = "lblcomptence";
            this.lblcomptence.Size = new System.Drawing.Size(0, 13);
            this.lblcomptence.TabIndex = 14;
            // 
            // lblexS
            // 
            this.lblexS.AutoSize = true;
            this.lblexS.Location = new System.Drawing.Point(125, 397);
            this.lblexS.Name = "lblexS";
            this.lblexS.Size = new System.Drawing.Size(0, 13);
            this.lblexS.TabIndex = 15;
            // 
            // lblexE
            // 
            this.lblexE.AutoSize = true;
            this.lblexE.Location = new System.Drawing.Point(128, 433);
            this.lblexE.Name = "lblexE";
            this.lblexE.Size = new System.Drawing.Size(0, 13);
            this.lblexE.TabIndex = 16;
            // 
            // lbllevelS
            // 
            this.lbllevelS.AutoSize = true;
            this.lbllevelS.Location = new System.Drawing.Point(100, 466);
            this.lbllevelS.Name = "lbllevelS";
            this.lbllevelS.Size = new System.Drawing.Size(0, 13);
            this.lbllevelS.TabIndex = 17;
            // 
            // lbllevelE
            // 
            this.lbllevelE.AutoSize = true;
            this.lbllevelE.Location = new System.Drawing.Point(100, 496);
            this.lbllevelE.Name = "lbllevelE";
            this.lbllevelE.Size = new System.Drawing.Size(0, 13);
            this.lbllevelE.TabIndex = 18;
            // 
            // lblbourse
            // 
            this.lblbourse.AutoSize = true;
            this.lblbourse.Location = new System.Drawing.Point(64, 126);
            this.lblbourse.Name = "lblbourse";
            this.lblbourse.Size = new System.Drawing.Size(0, 13);
            this.lblbourse.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(11, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Statistiques personnages :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 243);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Sorts/compétences :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 359);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Évolution Personnage :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Affinité :";
            // 
            // lblaffinité
            // 
            this.lblaffinité.AutoSize = true;
            this.lblaffinité.Location = new System.Drawing.Point(59, 155);
            this.lblaffinité.Name = "lblaffinité";
            this.lblaffinité.Size = new System.Drawing.Size(0, 13);
            this.lblaffinité.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(926, 598);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Selectionner une  action :";
            // 
            // cboWeapons
            // 
            this.cboWeapons.FormattingEnabled = true;
            this.cboWeapons.Location = new System.Drawing.Point(790, 628);
            this.cboWeapons.Name = "cboWeapons";
            this.cboWeapons.Size = new System.Drawing.Size(121, 21);
            this.cboWeapons.TabIndex = 26;
            // 
            // cboPotions
            // 
            this.cboPotions.FormattingEnabled = true;
            this.cboPotions.Location = new System.Drawing.Point(790, 758);
            this.cboPotions.Name = "cboPotions";
            this.cboPotions.Size = new System.Drawing.Size(121, 21);
            this.cboPotions.TabIndex = 27;
            // 
            // cboSort
            // 
            this.cboSort.FormattingEnabled = true;
            this.cboSort.Location = new System.Drawing.Point(790, 712);
            this.cboSort.Name = "cboSort";
            this.cboSort.Size = new System.Drawing.Size(121, 21);
            this.cboSort.TabIndex = 28;
            // 
            // btnUseWeapons
            // 
            this.btnUseWeapons.Location = new System.Drawing.Point(979, 626);
            this.btnUseWeapons.Name = "btnUseWeapons";
            this.btnUseWeapons.Size = new System.Drawing.Size(75, 23);
            this.btnUseWeapons.TabIndex = 29;
            this.btnUseWeapons.Text = "Utiliser";
            this.btnUseWeapons.UseVisualStyleBackColor = true;
            this.btnUseWeapons.Click += new System.EventHandler(this.btnUseFlamberges_Click);
            // 
            // btnUsePotions
            // 
            this.btnUsePotions.Location = new System.Drawing.Point(979, 756);
            this.btnUsePotions.Name = "btnUsePotions";
            this.btnUsePotions.Size = new System.Drawing.Size(75, 23);
            this.btnUsePotions.TabIndex = 30;
            this.btnUsePotions.Text = "Utiliser";
            this.btnUsePotions.UseVisualStyleBackColor = true;
            this.btnUsePotions.Click += new System.EventHandler(this.btnUsepotions_Click);
            // 
            // btnUseSort
            // 
            this.btnUseSort.Location = new System.Drawing.Point(979, 712);
            this.btnUseSort.Name = "btnUseSort";
            this.btnUseSort.Size = new System.Drawing.Size(75, 23);
            this.btnUseSort.TabIndex = 31;
            this.btnUseSort.Text = "Utiliser";
            this.btnUseSort.UseVisualStyleBackColor = true;
            this.btnUseSort.Click += new System.EventHandler(this.btnUsesort_Click);
            // 
            // btnNord
            // 
            this.btnNord.Location = new System.Drawing.Point(929, 466);
            this.btnNord.Name = "btnNord";
            this.btnNord.Size = new System.Drawing.Size(75, 23);
            this.btnNord.TabIndex = 32;
            this.btnNord.Text = "Nord";
            this.btnNord.UseVisualStyleBackColor = true;
            this.btnNord.Click += new System.EventHandler(this.btnNord_Click);
            // 
            // btnSud
            // 
            this.btnSud.Location = new System.Drawing.Point(929, 555);
            this.btnSud.Name = "btnSud";
            this.btnSud.Size = new System.Drawing.Size(75, 23);
            this.btnSud.TabIndex = 33;
            this.btnSud.Text = "Sud";
            this.btnSud.UseVisualStyleBackColor = true;
            this.btnSud.Click += new System.EventHandler(this.btnSud_Click);
            // 
            // btnEst
            // 
            this.btnEst.Location = new System.Drawing.Point(1034, 513);
            this.btnEst.Name = "btnEst";
            this.btnEst.Size = new System.Drawing.Size(75, 23);
            this.btnEst.TabIndex = 34;
            this.btnEst.Text = "Est";
            this.btnEst.UseVisualStyleBackColor = true;
            this.btnEst.Click += new System.EventHandler(this.btnEst_Click);
            // 
            // btnOuest
            // 
            this.btnOuest.Location = new System.Drawing.Point(836, 513);
            this.btnOuest.Name = "btnOuest";
            this.btnOuest.Size = new System.Drawing.Size(75, 23);
            this.btnOuest.TabIndex = 35;
            this.btnOuest.Text = "Ouest";
            this.btnOuest.UseVisualStyleBackColor = true;
            this.btnOuest.Click += new System.EventHandler(this.btnOuest_Click);
            // 
            // rtbLocation
            // 
            this.rtbLocation.Location = new System.Drawing.Point(793, 12);
            this.rtbLocation.Name = "rtbLocation";
            this.rtbLocation.ReadOnly = true;
            this.rtbLocation.Size = new System.Drawing.Size(360, 105);
            this.rtbLocation.TabIndex = 36;
            this.rtbLocation.Text = "";
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(793, 138);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.ReadOnly = true;
            this.rtbMessage.Size = new System.Drawing.Size(360, 300);
            this.rtbMessage.TabIndex = 37;
            this.rtbMessage.Text = "";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventory.Location = new System.Drawing.Point(426, 138);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.Size = new System.Drawing.Size(312, 309);
            this.dgvInventory.TabIndex = 38;
            // 
            // dgvQuests
            // 
            this.dgvQuests.AllowUserToAddRows = false;
            this.dgvQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQuests.Location = new System.Drawing.Point(426, 477);
            this.dgvQuests.MultiSelect = false;
            this.dgvQuests.Name = "dgvQuests";
            this.dgvQuests.ReadOnly = true;
            this.dgvQuests.Size = new System.Drawing.Size(312, 189);
            this.dgvQuests.TabIndex = 39;
            // 
            // cbohuiles
            // 
            this.cbohuiles.FormattingEnabled = true;
            this.cbohuiles.Location = new System.Drawing.Point(790, 669);
            this.cbohuiles.Name = "cbohuiles";
            this.cbohuiles.Size = new System.Drawing.Size(121, 21);
            this.cbohuiles.TabIndex = 40;
            // 
            // btnUseSacrifice
            // 
            this.btnUseSacrifice.Location = new System.Drawing.Point(823, 832);
            this.btnUseSacrifice.Name = "btnUseSacrifice";
            this.btnUseSacrifice.Size = new System.Drawing.Size(75, 23);
            this.btnUseSacrifice.TabIndex = 42;
            this.btnUseSacrifice.Text = "SACRIFIER";
            this.btnUseSacrifice.UseVisualStyleBackColor = true;
            this.btnUseSacrifice.Click += new System.EventHandler(this.btnUseSacrifice_Click);
            // 
            // btnUseEpargner
            // 
            this.btnUseEpargner.Location = new System.Drawing.Point(1004, 832);
            this.btnUseEpargner.Name = "btnUseEpargner";
            this.btnUseEpargner.Size = new System.Drawing.Size(75, 23);
            this.btnUseEpargner.TabIndex = 43;
            this.btnUseEpargner.Text = "ÉPARGNER";
            this.btnUseEpargner.UseVisualStyleBackColor = true;
            this.btnUseEpargner.Click += new System.EventHandler(this.btnUseEpargner_Click);
            // 
            // btnUseHuiles
            // 
            this.btnUseHuiles.Location = new System.Drawing.Point(979, 669);
            this.btnUseHuiles.Name = "btnUseHuiles";
            this.btnUseHuiles.Size = new System.Drawing.Size(75, 23);
            this.btnUseHuiles.TabIndex = 44;
            this.btnUseHuiles.Text = "Utiliser";
            this.btnUseHuiles.UseVisualStyleBackColor = true;
            this.btnUseHuiles.Click += new System.EventHandler(this.btnUseHuiles_Click);
            // 
            // btnEchange
            // 
            this.btnEchange.Location = new System.Drawing.Point(531, 712);
            this.btnEchange.Name = "btnEchange";
            this.btnEchange.Size = new System.Drawing.Size(75, 23);
            this.btnEchange.TabIndex = 45;
            this.btnEchange.Text = "Echange";
            this.btnEchange.UseVisualStyleBackColor = true;
            this.btnEchange.Click += new System.EventHandler(this.btnEchange_Click);
            // 
            // RPG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 961);
            this.Controls.Add(this.btnEchange);
            this.Controls.Add(this.btnUseHuiles);
            this.Controls.Add(this.btnUseEpargner);
            this.Controls.Add(this.btnUseSacrifice);
            this.Controls.Add(this.cbohuiles);
            this.Controls.Add(this.dgvQuests);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.rtbLocation);
            this.Controls.Add(this.btnOuest);
            this.Controls.Add(this.btnEst);
            this.Controls.Add(this.btnSud);
            this.Controls.Add(this.btnNord);
            this.Controls.Add(this.btnUseSort);
            this.Controls.Add(this.btnUsePotions);
            this.Controls.Add(this.btnUseWeapons);
            this.Controls.Add(this.cboSort);
            this.Controls.Add(this.cboPotions);
            this.Controls.Add(this.cboWeapons);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblaffinité);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblbourse);
            this.Controls.Add(this.lbllevelE);
            this.Controls.Add(this.lbllevelS);
            this.Controls.Add(this.lblexE);
            this.Controls.Add(this.lblexS);
            this.Controls.Add(this.lblcomptence);
            this.Controls.Add(this.lblquen);
            this.Controls.Add(this.lblignis);
            this.Controls.Add(this.lblarmure);
            this.Controls.Add(this.lblpointvie);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RPG";
            this.Text = "RPG";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblpointvie;
        private System.Windows.Forms.Label lblarmure;
        private System.Windows.Forms.Label lblignis;
        private System.Windows.Forms.Label lblquen;
        private System.Windows.Forms.Label lblcomptence;
        private System.Windows.Forms.Label lblexS;
        private System.Windows.Forms.Label lblexE;
        private System.Windows.Forms.Label lbllevelS;
        private System.Windows.Forms.Label lbllevelE;
        private System.Windows.Forms.Label lblbourse;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblaffinité;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboWeapons;
        private System.Windows.Forms.ComboBox cboPotions;
        private System.Windows.Forms.ComboBox cboSort;
        private System.Windows.Forms.Button btnUseWeapons;
        private System.Windows.Forms.Button btnUsePotions;
        private System.Windows.Forms.Button btnUseSort;
        private System.Windows.Forms.Button btnNord;
        private System.Windows.Forms.Button btnSud;
        private System.Windows.Forms.Button btnEst;
        private System.Windows.Forms.Button btnOuest;
        private System.Windows.Forms.RichTextBox rtbLocation;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridView dgvQuests;
        private System.Windows.Forms.ComboBox cbohuiles;
        private System.Windows.Forms.Button btnUseSacrifice;
        private System.Windows.Forms.Button btnUseEpargner;
        private System.Windows.Forms.Button btnUseHuiles;
        private Button btnEchange;
    }
}

