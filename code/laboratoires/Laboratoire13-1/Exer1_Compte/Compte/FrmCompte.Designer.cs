namespace Compte
{
    partial class FrmCompte
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
            this.lblMontant = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.btnDepot = new System.Windows.Forms.Button();
            this.btnRetrait = new System.Windows.Forms.Button();
            this.txtSolde = new System.Windows.Forms.TextBox();
            this.grpInformations = new System.Windows.Forms.GroupBox();
            this.lblProprietaire = new System.Windows.Forms.Label();
            this.txtProprietaire = new System.Windows.Forms.TextBox();
            this.lblSoldeInfo = new System.Windows.Forms.Label();
            this.grpInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(23, 14);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(52, 13);
            this.lblMontant.TabIndex = 8;
            this.lblMontant.Text = "Montant :";
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(103, 12);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(120, 20);
            this.txtMontant.TabIndex = 9;
            // 
            // btnDepot
            // 
            this.btnDepot.Location = new System.Drawing.Point(23, 54);
            this.btnDepot.Name = "btnDepot";
            this.btnDepot.Size = new System.Drawing.Size(100, 23);
            this.btnDepot.TabIndex = 10;
            this.btnDepot.Text = "Déposer";
            this.btnDepot.Click += new System.EventHandler(this.btnDepot_Click);
            // 
            // btnRetrait
            // 
            this.btnRetrait.Location = new System.Drawing.Point(143, 54);
            this.btnRetrait.Name = "btnRetrait";
            this.btnRetrait.Size = new System.Drawing.Size(100, 23);
            this.btnRetrait.TabIndex = 11;
            this.btnRetrait.Text = "Retirer";
            this.btnRetrait.Click += new System.EventHandler(this.btnRetrait_Click);
            // 
            // txtSolde
            // 
            this.txtSolde.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSolde.Location = new System.Drawing.Point(98, 60);
            this.txtSolde.Name = "txtSolde";
            this.txtSolde.ReadOnly = true;
            this.txtSolde.Size = new System.Drawing.Size(146, 20);
            this.txtSolde.TabIndex = 0;
            // 
            // grpInformations
            // 
            this.grpInformations.Controls.Add(this.lblProprietaire);
            this.grpInformations.Controls.Add(this.txtProprietaire);
            this.grpInformations.Controls.Add(this.lblSoldeInfo);
            this.grpInformations.Controls.Add(this.txtSolde);
            this.grpInformations.Location = new System.Drawing.Point(23, 93);
            this.grpInformations.Name = "grpInformations";
            this.grpInformations.Size = new System.Drawing.Size(263, 96);
            this.grpInformations.TabIndex = 12;
            this.grpInformations.TabStop = false;
            this.grpInformations.Text = "Informations du compte";
            // 
            // lblProprietaire
            // 
            this.lblProprietaire.AutoSize = true;
            this.lblProprietaire.Location = new System.Drawing.Point(17, 32);
            this.lblProprietaire.Name = "lblProprietaire";
            this.lblProprietaire.Size = new System.Drawing.Size(66, 13);
            this.lblProprietaire.TabIndex = 0;
            this.lblProprietaire.Text = "Propriétaire :";
            // 
            // txtProprietaire
            // 
            this.txtProprietaire.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtProprietaire.Location = new System.Drawing.Point(98, 29);
            this.txtProprietaire.Name = "txtProprietaire";
            this.txtProprietaire.ReadOnly = true;
            this.txtProprietaire.Size = new System.Drawing.Size(146, 20);
            this.txtProprietaire.TabIndex = 1;
            // 
            // lblSoldeInfo
            // 
            this.lblSoldeInfo.AutoSize = true;
            this.lblSoldeInfo.Location = new System.Drawing.Point(17, 63);
            this.lblSoldeInfo.Name = "lblSoldeInfo";
            this.lblSoldeInfo.Size = new System.Drawing.Size(55, 13);
            this.lblSoldeInfo.TabIndex = 2;
            this.lblSoldeInfo.Text = "Solde ($) :";
            // 
            // FrmCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 203);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.btnDepot);
            this.Controls.Add(this.btnRetrait);
            this.Controls.Add(this.grpInformations);
            this.Name = "FrmCompte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compte bancaire";
            this.grpInformations.ResumeLayout(false);
            this.grpInformations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Button btnDepot;
        private System.Windows.Forms.Button btnRetrait;
        private System.Windows.Forms.TextBox txtSolde;
        private System.Windows.Forms.GroupBox grpInformations;
        private System.Windows.Forms.Label lblProprietaire;
        private System.Windows.Forms.TextBox txtProprietaire;
        private System.Windows.Forms.Label lblSoldeInfo;
    }
}

