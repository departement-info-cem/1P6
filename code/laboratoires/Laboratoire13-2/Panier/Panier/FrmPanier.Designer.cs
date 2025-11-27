namespace Panier
{
    partial class FrmPanier
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierViderPanier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSéparateur2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFichierChargerPanier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierEnregistrerPanier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparateur1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAjouterAuPanier = new System.Windows.Forms.Button();
           
           
            this.lstPanier = new System.Windows.Forms.ListBox();
            this.lblPanier = new System.Windows.Forms.Label();
            this.BtnRetirerDuPanier = new System.Windows.Forms.Button();
            this.lblDirectives = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.lblItemDescription = new System.Windows.Forms.Label();
            this.lblItemsDisponibles = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.txtItemPrix = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panPanier = new System.Windows.Forms.Panel();
            this.panTotal = new System.Windows.Forms.Panel();
            this.txtTotalAvecTaxes = new System.Windows.Forms.TextBox();
            this.lblTotalAvecTaxes = new System.Windows.Forms.Label();
            this.txtTaxes = new System.Windows.Forms.TextBox();
            this.lblTaxes = new System.Windows.Forms.Label();
            this.panFacture = new System.Windows.Forms.Panel();
            this.txtNbItemsPanier = new System.Windows.Forms.TextBox();
            this.lblNombreItems = new System.Windows.Forms.Label();
            this.lstItemsDisponibles = new System.Windows.Forms.ListBox();
            this.menuPrincipal.SuspendLayout();
            this.panPanier.SuspendLayout();
            this.panFacture.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuPrincipal.Size = new System.Drawing.Size(1779, 24);
            this.menuPrincipal.TabIndex = 3;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierViderPanier,
            this.mnuSéparateur2,
            this.mnuFichierChargerPanier,
            this.mnuFichierEnregistrerPanier,
            this.mnuSeparateur1,
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(54, 20);
            this.mnuFichier.Tag = "A15PC";
            this.mnuFichier.Text = "&Fichier";
            // 
            // mnuFichierViderPanier
            // 
            this.mnuFichierViderPanier.Name = "mnuFichierViderPanier";
            this.mnuFichierViderPanier.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFichierViderPanier.Size = new System.Drawing.Size(218, 22);
            this.mnuFichierViderPanier.Text = "&Vider le Panier";
           
            // 
            // mnuSéparateur2
            // 
            this.mnuSéparateur2.Name = "mnuSéparateur2";
            this.mnuSéparateur2.Size = new System.Drawing.Size(215, 6);
            // 
            // mnuFichierChargerPanier
            // 
            this.mnuFichierChargerPanier.Name = "mnuFichierChargerPanier";
            this.mnuFichierChargerPanier.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuFichierChargerPanier.Size = new System.Drawing.Size(218, 22);
            this.mnuFichierChargerPanier.Text = "&Charger le Panier";
           
            // 
            // mnuFichierEnregistrerPanier
            // 
            this.mnuFichierEnregistrerPanier.Name = "mnuFichierEnregistrerPanier";
            this.mnuFichierEnregistrerPanier.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuFichierEnregistrerPanier.Size = new System.Drawing.Size(218, 22);
            this.mnuFichierEnregistrerPanier.Text = "&Enregistrer le Panier";
          
            // 
            // mnuSeparateur1
            // 
            this.mnuSeparateur1.Name = "mnuSeparateur1";
            this.mnuSeparateur1.Size = new System.Drawing.Size(215, 6);
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(218, 22);
            this.mnuFichierQuitter.Text = "&Quitter";
           
            // 
            // btnAjouterAuPanier
            // 
            this.btnAjouterAuPanier.Enabled = false;
            this.btnAjouterAuPanier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterAuPanier.Location = new System.Drawing.Point(28, 22);
            this.btnAjouterAuPanier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjouterAuPanier.Name = "btnAjouterAuPanier";
            this.btnAjouterAuPanier.Size = new System.Drawing.Size(395, 50);
            this.btnAjouterAuPanier.TabIndex = 8;
            this.btnAjouterAuPanier.Text = "&Ajouter au Panier";
            this.btnAjouterAuPanier.UseVisualStyleBackColor = true;
           
            // 
            
            // 
            // lstPanier
            // 
            this.lstPanier.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPanier.FormattingEnabled = true;
            this.lstPanier.ItemHeight = 18;
            this.lstPanier.Location = new System.Drawing.Point(28, 107);
            this.lstPanier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstPanier.Name = "lstPanier";
            this.lstPanier.Size = new System.Drawing.Size(828, 328);
            this.lstPanier.TabIndex = 2;
           
            // 
            // lblPanier
            // 
            this.lblPanier.AutoSize = true;
            this.lblPanier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanier.Location = new System.Drawing.Point(24, 84);
            this.lblPanier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPanier.Name = "lblPanier";
            this.lblPanier.Size = new System.Drawing.Size(121, 16);
            this.lblPanier.TabIndex = 9;
            this.lblPanier.Text = "Panier des achats :";
            // 
            // BtnRetirerDuPanier
            // 
            this.BtnRetirerDuPanier.Enabled = false;
            this.BtnRetirerDuPanier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRetirerDuPanier.Location = new System.Drawing.Point(464, 22);
            this.BtnRetirerDuPanier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnRetirerDuPanier.Name = "BtnRetirerDuPanier";
            this.BtnRetirerDuPanier.Size = new System.Drawing.Size(395, 50);
            this.BtnRetirerDuPanier.TabIndex = 9;
            this.BtnRetirerDuPanier.Text = "&Retirer du Panier";
            this.BtnRetirerDuPanier.UseVisualStyleBackColor = true;
           
            // 
            // lblDirectives
            // 
            this.lblDirectives.AutoSize = true;
            this.lblDirectives.Location = new System.Drawing.Point(24, 695);
            this.lblDirectives.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDirectives.Name = "lblDirectives";
            this.lblDirectives.Size = new System.Drawing.Size(380, 16);
            this.lblDirectives.TabIndex = 6;
            this.lblDirectives.Text = "Double-cliquer sur un item pour l\'ajouter directement au Panier :";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(24, 448);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(448, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Double-cliquer sur un item du Panier pour le retirer.";
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemDescription.Location = new System.Drawing.Point(28, 71);
            this.txtItemDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.ReadOnly = true;
            this.txtItemDescription.Size = new System.Drawing.Size(635, 24);
            this.txtItemDescription.TabIndex = 1;
            // 
            // lblItemDescription
            // 
            this.lblItemDescription.AutoSize = true;
            this.lblItemDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemDescription.Location = new System.Drawing.Point(24, 48);
            this.lblItemDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemDescription.Name = "lblItemDescription";
            this.lblItemDescription.Size = new System.Drawing.Size(206, 16);
            this.lblItemDescription.TabIndex = 0;
            this.lblItemDescription.Text = "Description de l\'item sélectionné :";
            // 
            // lblItemsDisponibles
            // 
            this.lblItemsDisponibles.AutoSize = true;
            this.lblItemsDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsDisponibles.Location = new System.Drawing.Point(24, 122);
            this.lblItemsDisponibles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemsDisponibles.Name = "lblItemsDisponibles";
            this.lblItemsDisponibles.Size = new System.Drawing.Size(184, 16);
            this.lblItemsDisponibles.TabIndex = 4;
            this.lblItemsDisponibles.Text = "Items disponibles pour achat :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(517, 27);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(105, 16);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "&Total des items :";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrix.Location = new System.Drawing.Point(681, 48);
            this.lblPrix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(35, 16);
            this.lblPrix.TabIndex = 2;
            this.lblPrix.Text = "Prix :";
            // 
            // txtItemPrix
            // 
            this.txtItemPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemPrix.Location = new System.Drawing.Point(685, 71);
            this.txtItemPrix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtItemPrix.Name = "txtItemPrix";
            this.txtItemPrix.ReadOnly = true;
            this.txtItemPrix.Size = new System.Drawing.Size(115, 24);
            this.txtItemPrix.TabIndex = 3;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(689, 20);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(167, 26);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(824, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 689);
            this.panel1.TabIndex = 6;
            // 
            // panPanier
            // 
            this.panPanier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panPanier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panPanier.Controls.Add(this.lstPanier);
            this.panPanier.Controls.Add(this.btnAjouterAuPanier);
            this.panPanier.Controls.Add(this.lblPanier);
            this.panPanier.Controls.Add(this.label3);
            this.panPanier.Controls.Add(this.BtnRetirerDuPanier);
            this.panPanier.Location = new System.Drawing.Point(855, 48);
            this.panPanier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panPanier.Name = "panPanier";
            this.panPanier.Size = new System.Drawing.Size(891, 481);
            this.panPanier.TabIndex = 7;
            // 
            // panTotal
            // 
            this.panTotal.BackColor = System.Drawing.Color.Gray;
            this.panTotal.Location = new System.Drawing.Point(521, 107);
            this.panTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panTotal.Name = "panTotal";
            this.panTotal.Size = new System.Drawing.Size(337, 5);
            this.panTotal.TabIndex = 14;
            // 
            // txtTotalAvecTaxes
            // 
            this.txtTotalAvecTaxes.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAvecTaxes.Location = new System.Drawing.Point(689, 126);
            this.txtTotalAvecTaxes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalAvecTaxes.Name = "txtTotalAvecTaxes";
            this.txtTotalAvecTaxes.ReadOnly = true;
            this.txtTotalAvecTaxes.Size = new System.Drawing.Size(167, 26);
            this.txtTotalAvecTaxes.TabIndex = 16;
            this.txtTotalAvecTaxes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalAvecTaxes
            // 
            this.lblTotalAvecTaxes.AutoSize = true;
            this.lblTotalAvecTaxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAvecTaxes.Location = new System.Drawing.Point(517, 133);
            this.lblTotalAvecTaxes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAvecTaxes.Name = "lblTotalAvecTaxes";
            this.lblTotalAvecTaxes.Size = new System.Drawing.Size(112, 16);
            this.lblTotalAvecTaxes.TabIndex = 15;
            this.lblTotalAvecTaxes.Text = "Total avec taxes :";
            // 
            // txtTaxes
            // 
            this.txtTaxes.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxes.Location = new System.Drawing.Point(689, 59);
            this.txtTaxes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTaxes.Name = "txtTaxes";
            this.txtTaxes.ReadOnly = true;
            this.txtTaxes.Size = new System.Drawing.Size(167, 26);
            this.txtTaxes.TabIndex = 13;
            this.txtTaxes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTaxes
            // 
            this.lblTaxes.AutoSize = true;
            this.lblTaxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxes.Location = new System.Drawing.Point(517, 66);
            this.lblTaxes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaxes.Name = "lblTaxes";
            this.lblTaxes.Size = new System.Drawing.Size(88, 16);
            this.lblTaxes.TabIndex = 12;
            this.lblTaxes.Text = "Taxes (15%) :";
            // 
            // panFacture
            // 
            this.panFacture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panFacture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panFacture.Controls.Add(this.txtNbItemsPanier);
            this.panFacture.Controls.Add(this.lblNombreItems);
            this.panFacture.Controls.Add(this.txtTotal);
            this.panFacture.Controls.Add(this.panTotal);
            this.panFacture.Controls.Add(this.lblTotal);
            this.panFacture.Controls.Add(this.lblTaxes);
            this.panFacture.Controls.Add(this.txtTotalAvecTaxes);
            this.panFacture.Controls.Add(this.txtTaxes);
            this.panFacture.Controls.Add(this.lblTotalAvecTaxes);
            this.panFacture.Location = new System.Drawing.Point(855, 537);
            this.panFacture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panFacture.Name = "panFacture";
            this.panFacture.Size = new System.Drawing.Size(891, 174);
            this.panFacture.TabIndex = 17;
            // 
            // txtNbItemsPanier
            // 
            this.txtNbItemsPanier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNbItemsPanier.Location = new System.Drawing.Point(297, 20);
            this.txtNbItemsPanier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNbItemsPanier.Name = "txtNbItemsPanier";
            this.txtNbItemsPanier.ReadOnly = true;
            this.txtNbItemsPanier.Size = new System.Drawing.Size(67, 26);
            this.txtNbItemsPanier.TabIndex = 18;
            this.txtNbItemsPanier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombreItems
            // 
            this.lblNombreItems.AutoSize = true;
            this.lblNombreItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreItems.Location = new System.Drawing.Point(24, 27);
            this.lblNombreItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreItems.Name = "lblNombreItems";
            this.lblNombreItems.Size = new System.Drawing.Size(199, 16);
            this.lblNombreItems.TabIndex = 17;
            this.lblNombreItems.Text = "&Nombre d\'items dans le panier  :";
            // 
            // lstItemsDisponibles
            // 
            this.lstItemsDisponibles.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstItemsDisponibles.FormattingEnabled = true;
            this.lstItemsDisponibles.ItemHeight = 18;
            this.lstItemsDisponibles.Location = new System.Drawing.Point(28, 145);
            this.lstItemsDisponibles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstItemsDisponibles.Name = "lstItemsDisponibles";
            this.lstItemsDisponibles.Size = new System.Drawing.Size(772, 508);
            this.lstItemsDisponibles.TabIndex = 18;

           
            // 
            // FrmQ1
            // 
            this.AcceptButton = this.btnAjouterAuPanier;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1779, 724);
            this.Controls.Add(this.lstItemsDisponibles);
            this.Controls.Add(this.panFacture);
            this.Controls.Add(this.panPanier);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtItemPrix);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.lblItemsDisponibles);
            this.Controls.Add(this.lblItemDescription);
            this.Controls.Add(this.txtItemDescription);
            this.Controls.Add(this.lblDirectives);
            this.Controls.Add(this.menuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmQ1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panier des achats";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.panPanier.ResumeLayout(false);
            this.panPanier.PerformLayout();
            this.panFacture.ResumeLayout(false);
            this.panFacture.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuPrincipal;
        public System.Windows.Forms.ToolStripMenuItem mnuFichier;
        public System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        public System.Windows.Forms.Button btnAjouterAuPanier;
      
        private System.Windows.Forms.ListBox lstPanier;
        private System.Windows.Forms.Label lblPanier;
        public System.Windows.Forms.Button BtnRetirerDuPanier;
        private System.Windows.Forms.Label lblDirectives;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.Label lblItemDescription;
        private System.Windows.Forms.Label lblItemsDisponibles;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.TextBox txtItemPrix;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierViderPanier;
        private System.Windows.Forms.ToolStripSeparator mnuSeparateur1;
        private System.Windows.Forms.ToolStripSeparator mnuSéparateur2;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierChargerPanier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierEnregistrerPanier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panPanier;
        private System.Windows.Forms.TextBox txtTotalAvecTaxes;
        private System.Windows.Forms.Label lblTotalAvecTaxes;
        private System.Windows.Forms.TextBox txtTaxes;
        private System.Windows.Forms.Label lblTaxes;
        private System.Windows.Forms.Panel panTotal;
        private System.Windows.Forms.Panel panFacture;
        private System.Windows.Forms.TextBox txtNbItemsPanier;
        private System.Windows.Forms.Label lblNombreItems;
        private System.Windows.Forms.ListBox lstItemsDisponibles;
    }
}


