namespace Task2Do
{
    partial class FrmTasks
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        private void InitializeComponent()
        {
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblAFaire = new System.Windows.Forms.Label();
            this.lblRealise = new System.Windows.Forms.Label();
            this.lstAFaire = new System.Windows.Forms.ListBox();
            this.lstRealisee = new System.Windows.Forms.ListBox();
            this.cmbNouvelleTache = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimerAFaire = new System.Windows.Forms.Button();
            this.btnVersRealise = new System.Windows.Forms.Button();
            this.btnVersAFaire = new System.Windows.Forms.Button();
            this.panelHaut = new System.Windows.Forms.Panel();
            this.panelBas = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnregistrer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.panelHaut.SuspendLayout();
            this.panelBas.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(0, 0);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(1416, 43);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Gestion de tâches";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAFaire
            // 
            this.lblAFaire.AutoSize = true;
            this.lblAFaire.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAFaire.Location = new System.Drawing.Point(45, 85);
            this.lblAFaire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAFaire.Name = "lblAFaire";
            this.lblAFaire.Size = new System.Drawing.Size(100, 19);
            this.lblAFaire.TabIndex = 2;
            this.lblAFaire.Text = "Tâches à faire";
            // 
            // lblRealise
            // 
            this.lblRealise.AutoSize = true;
            this.lblRealise.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRealise.Location = new System.Drawing.Point(789, 85);
            this.lblRealise.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRealise.Name = "lblRealise";
            this.lblRealise.Size = new System.Drawing.Size(115, 19);
            this.lblRealise.TabIndex = 3;
            this.lblRealise.Text = "Tâches réalisées";
            // 
            // lstAFaire
            // 
            this.lstAFaire.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstAFaire.FormattingEnabled = true;
            this.lstAFaire.ItemHeight = 17;
            this.lstAFaire.Location = new System.Drawing.Point(45, 112);
            this.lstAFaire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstAFaire.Name = "lstAFaire";
            this.lstAFaire.Size = new System.Drawing.Size(587, 276);
            this.lstAFaire.TabIndex = 4;
           
            // 
            // lstRealisee
            // 
            this.lstRealisee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstRealisee.FormattingEnabled = true;
            this.lstRealisee.ItemHeight = 17;
            this.lstRealisee.Location = new System.Drawing.Point(789, 112);
            this.lstRealisee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstRealisee.Name = "lstRealisee";
            this.lstRealisee.Size = new System.Drawing.Size(585, 276);
            this.lstRealisee.TabIndex = 5;
            // 
            // cmbNouvelleTache
            // 
            this.cmbNouvelleTache.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbNouvelleTache.Location = new System.Drawing.Point(45, 9);
            this.cmbNouvelleTache.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbNouvelleTache.Name = "cmbNouvelleTache";
            this.cmbNouvelleTache.Size = new System.Drawing.Size(621, 25);
            this.cmbNouvelleTache.TabIndex = 0;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAjouter.Location = new System.Drawing.Point(685, 9);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(125, 32);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerAFaire
            // 
            this.btnSupprimerAFaire.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSupprimerAFaire.Location = new System.Drawing.Point(45, 395);
            this.btnSupprimerAFaire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSupprimerAFaire.Name = "btnSupprimerAFaire";
            this.btnSupprimerAFaire.Size = new System.Drawing.Size(297, 42);
            this.btnSupprimerAFaire.TabIndex = 6;
            this.btnSupprimerAFaire.Text = "Supprimer";
            this.btnSupprimerAFaire.UseVisualStyleBackColor = true;
            // 
            // btnVersRealise
            // 
            this.btnVersRealise.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnVersRealise.Location = new System.Drawing.Point(652, 192);
            this.btnVersRealise.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVersRealise.Name = "btnVersRealise";
            this.btnVersRealise.Size = new System.Drawing.Size(115, 37);
            this.btnVersRealise.TabIndex = 7;
            this.btnVersRealise.Text = "→ Réalisée";
            this.btnVersRealise.UseVisualStyleBackColor = true;
            // 
            // btnVersAFaire
            // 
            this.btnVersAFaire.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnVersAFaire.Location = new System.Drawing.Point(652, 251);
            this.btnVersAFaire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVersAFaire.Name = "btnVersAFaire";
            this.btnVersAFaire.Size = new System.Drawing.Size(115, 37);
            this.btnVersAFaire.TabIndex = 8;
            this.btnVersAFaire.Text = "← À faire";
            this.btnVersAFaire.UseVisualStyleBackColor = true;
            // 
            // panelHaut
            // 
            this.panelHaut.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHaut.Controls.Add(this.lblTitre);
            this.panelHaut.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHaut.Location = new System.Drawing.Point(0, 27);
            this.panelHaut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelHaut.Name = "panelHaut";
            this.panelHaut.Size = new System.Drawing.Size(1416, 43);
            this.panelHaut.TabIndex = 1;
            // 
            // panelBas
            // 
            this.panelBas.Controls.Add(this.cmbNouvelleTache);
            this.panelBas.Controls.Add(this.btnAjouter);
            this.panelBas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBas.Location = new System.Drawing.Point(0, 443);
            this.panelBas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelBas.Name = "panelBas";
            this.panelBas.Size = new System.Drawing.Size(1416, 48);
            this.panelBas.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1416, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEnregistrer,
            this.mnuQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(60, 23);
            this.mnuFichier.Text = "Fichier";
            // 
            // mnuEnregistrer
            // 
            this.mnuEnregistrer.Name = "mnuEnregistrer";
            this.mnuEnregistrer.Size = new System.Drawing.Size(144, 24);
            this.mnuEnregistrer.Text = "Enregistrer";
            // 
            // mnuQuitter
            // 
            this.mnuQuitter.Name = "mnuQuitter";
            this.mnuQuitter.Size = new System.Drawing.Size(144, 24);
            this.mnuQuitter.Text = "Quitter";
            // 
            // FrmTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1416, 491);
            this.Controls.Add(this.panelBas);
            this.Controls.Add(this.btnVersAFaire);
            this.Controls.Add(this.btnVersRealise);
            this.Controls.Add(this.btnSupprimerAFaire);
            this.Controls.Add(this.lstRealisee);
            this.Controls.Add(this.lstAFaire);
            this.Controls.Add(this.lblRealise);
            this.Controls.Add(this.lblAFaire);
            this.Controls.Add(this.panelHaut);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(912, 509);
            this.Name = "FrmTasks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de tâches";
            this.panelHaut.ResumeLayout(false);
            this.panelBas.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblAFaire;
        private System.Windows.Forms.Label lblRealise;
        private System.Windows.Forms.ListBox lstAFaire;
        private System.Windows.Forms.ListBox lstRealisee;
        private System.Windows.Forms.ComboBox cmbNouvelleTache;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimerAFaire;
        private System.Windows.Forms.Button btnVersRealise;
        private System.Windows.Forms.Button btnVersAFaire;
        private System.Windows.Forms.Panel panelHaut;
        private System.Windows.Forms.Panel panelBas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuEnregistrer;
        private System.Windows.Forms.ToolStripMenuItem mnuQuitter;
    }
}

