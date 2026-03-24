namespace AppGuichet
{
    partial class FrmPrincipal
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
            components = new System.ComponentModel.Container();
            grpIdentification = new GroupBox();
            txtMotDePasse = new TextBox();
            btnConnexion = new Button();
            lblMotDePasse = new Label();
            txtNumClient = new TextBox();
            lblNumClient = new Label();
            grpInfosClient = new GroupBox();
            txtSorteCompte = new TextBox();
            btnRetirer = new Button();
            lblSorteCompte = new Label();
            btnDeposer = new Button();
            cboMontant = new ComboBox();
            label1 = new Label();
            txtSolde = new TextBox();
            lblSolde = new Label();
            txtNom = new TextBox();
            lblNom = new Label();
            mnuPrincipal = new MenuStrip();
            mnuFichier = new ToolStripMenuItem();
            mnuFichierQuitter = new ToolStripMenuItem();
            mnuAdministrateur = new ToolStripMenuItem();
            mnuAdminListeClients = new ToolStripMenuItem();
            mnuAdminListeTransactions = new ToolStripMenuItem();
            errIdentification = new ErrorProvider(components);
            grpIdentification.SuspendLayout();
            grpInfosClient.SuspendLayout();
            mnuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errIdentification).BeginInit();
            SuspendLayout();
            // 
            // grpIdentification
            // 
            grpIdentification.Controls.Add(txtMotDePasse);
            grpIdentification.Controls.Add(btnConnexion);
            grpIdentification.Controls.Add(lblMotDePasse);
            grpIdentification.Controls.Add(txtNumClient);
            grpIdentification.Controls.Add(lblNumClient);
            grpIdentification.Location = new Point(14, 39);
            grpIdentification.Margin = new Padding(4);
            grpIdentification.Name = "grpIdentification";
            grpIdentification.Padding = new Padding(4);
            grpIdentification.Size = new Size(402, 158);
            grpIdentification.TabIndex = 0;
            grpIdentification.TabStop = false;
            grpIdentification.Text = "Identification";
            // 
            // txtMotDePasse
            // 
            txtMotDePasse.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMotDePasse.Location = new Point(133, 69);
            txtMotDePasse.Margin = new Padding(4);
            txtMotDePasse.Name = "txtMotDePasse";
            txtMotDePasse.Size = new Size(255, 22);
            txtMotDePasse.TabIndex = 3;
            txtMotDePasse.UseSystemPasswordChar = true;
            // 
            // btnConnexion
            // 
            btnConnexion.Location = new Point(20, 107);
            btnConnexion.Margin = new Padding(4);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(368, 26);
            btnConnexion.TabIndex = 4;
            btnConnexion.Text = "Se connecter";
            btnConnexion.UseVisualStyleBackColor = true;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // lblMotDePasse
            // 
            lblMotDePasse.AutoSize = true;
            lblMotDePasse.Location = new Point(17, 69);
            lblMotDePasse.Margin = new Padding(4, 0, 4, 0);
            lblMotDePasse.Name = "lblMotDePasse";
            lblMotDePasse.Size = new Size(83, 15);
            lblMotDePasse.TabIndex = 2;
            lblMotDePasse.Text = "Mot de passe :";
            // 
            // txtNumClient
            // 
            txtNumClient.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNumClient.Location = new Point(133, 34);
            txtNumClient.Margin = new Padding(4);
            txtNumClient.Name = "txtNumClient";
            txtNumClient.Size = new Size(255, 22);
            txtNumClient.TabIndex = 1;
            // 
            // lblNumClient
            // 
            lblNumClient.AutoSize = true;
            lblNumClient.Location = new Point(17, 39);
            lblNumClient.Margin = new Padding(4, 0, 4, 0);
            lblNumClient.Name = "lblNumClient";
            lblNumClient.Size = new Size(105, 15);
            lblNumClient.TabIndex = 0;
            lblNumClient.Text = "Numéro de client :";
            // 
            // grpInfosClient
            // 
            grpInfosClient.Controls.Add(txtSorteCompte);
            grpInfosClient.Controls.Add(btnRetirer);
            grpInfosClient.Controls.Add(lblSorteCompte);
            grpInfosClient.Controls.Add(btnDeposer);
            grpInfosClient.Controls.Add(cboMontant);
            grpInfosClient.Controls.Add(label1);
            grpInfosClient.Controls.Add(txtSolde);
            grpInfosClient.Controls.Add(lblSolde);
            grpInfosClient.Controls.Add(txtNom);
            grpInfosClient.Controls.Add(lblNom);
            grpInfosClient.Enabled = false;
            grpInfosClient.Location = new Point(14, 204);
            grpInfosClient.Margin = new Padding(4);
            grpInfosClient.Name = "grpInfosClient";
            grpInfosClient.Padding = new Padding(4);
            grpInfosClient.Size = new Size(402, 133);
            grpInfosClient.TabIndex = 1;
            grpInfosClient.TabStop = false;
            grpInfosClient.Text = "Informations/Opérations";
            // 
            // txtSorteCompte
            // 
            txtSorteCompte.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSorteCompte.Location = new Point(291, 26);
            txtSorteCompte.Margin = new Padding(4);
            txtSorteCompte.Name = "txtSorteCompte";
            txtSorteCompte.ReadOnly = true;
            txtSorteCompte.Size = new Size(91, 20);
            txtSorteCompte.TabIndex = 10;
            // 
            // btnRetirer
            // 
            btnRetirer.Location = new Point(109, 87);
            btnRetirer.Margin = new Padding(4);
            btnRetirer.Name = "btnRetirer";
            btnRetirer.Size = new Size(106, 26);
            btnRetirer.TabIndex = 9;
            btnRetirer.Text = "Retirer";
            btnRetirer.UseVisualStyleBackColor = true;
            btnRetirer.Click += btnRetirer_Click;
            // 
            // lblSorteCompte
            // 
            lblSorteCompte.AutoSize = true;
            lblSorteCompte.Location = new Point(227, 31);
            lblSorteCompte.Margin = new Padding(4, 0, 4, 0);
            lblSorteCompte.Name = "lblSorteCompte";
            lblSorteCompte.Size = new Size(56, 15);
            lblSorteCompte.TabIndex = 2;
            lblSorteCompte.Text = "Compte :";
            // 
            // btnDeposer
            // 
            btnDeposer.Location = new Point(109, 64);
            btnDeposer.Margin = new Padding(4);
            btnDeposer.Name = "btnDeposer";
            btnDeposer.Size = new Size(106, 26);
            btnDeposer.TabIndex = 6;
            btnDeposer.Text = "Deposer";
            btnDeposer.UseVisualStyleBackColor = true;
            btnDeposer.Click += btnDeposer_Click;
            // 
            // cboMontant
            // 
            cboMontant.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMontant.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboMontant.FormattingEnabled = true;
            cboMontant.Items.AddRange(new object[] { "20", "40", "60", "80", "100", "200", "300", "500" });
            cboMontant.Location = new Point(20, 66);
            cboMontant.Margin = new Padding(4);
            cboMontant.Name = "cboMontant";
            cboMontant.Size = new Size(68, 21);
            cboMontant.TabIndex = 4;
            cboMontant.SelectedIndexChanged += cboMontant_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 69);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 5;
            label1.Text = "$";
            // 
            // txtSolde
            // 
            txtSolde.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSolde.Location = new Point(280, 66);
            txtSolde.Margin = new Padding(4);
            txtSolde.Name = "txtSolde";
            txtSolde.ReadOnly = true;
            txtSolde.Size = new Size(108, 20);
            txtSolde.TabIndex = 8;
            txtSolde.TextAlign = HorizontalAlignment.Right;
            // 
            // lblSolde
            // 
            lblSolde.AutoSize = true;
            lblSolde.Location = new Point(227, 69);
            lblSolde.Margin = new Padding(4, 0, 4, 0);
            lblSolde.Name = "lblSolde";
            lblSolde.Size = new Size(42, 15);
            lblSolde.TabIndex = 7;
            lblSolde.Text = "Solde :";
            // 
            // txtNom
            // 
            txtNom.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNom.Location = new Point(56, 26);
            txtNom.Margin = new Padding(4);
            txtNom.Name = "txtNom";
            txtNom.ReadOnly = true;
            txtNom.Size = new Size(159, 20);
            txtNom.TabIndex = 1;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(17, 30);
            lblNom.Margin = new Padding(4, 0, 4, 0);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(40, 15);
            lblNom.TabIndex = 0;
            lblNom.Text = "Nom :";
            // 
            // mnuPrincipal
            // 
            mnuPrincipal.Items.AddRange(new ToolStripItem[] { mnuFichier, mnuAdministrateur });
            mnuPrincipal.Location = new Point(0, 0);
            mnuPrincipal.Name = "mnuPrincipal";
            mnuPrincipal.Padding = new Padding(7, 2, 0, 2);
            mnuPrincipal.Size = new Size(430, 24);
            mnuPrincipal.TabIndex = 2;
            mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            mnuFichier.DropDownItems.AddRange(new ToolStripItem[] { mnuFichierQuitter });
            mnuFichier.Name = "mnuFichier";
            mnuFichier.Size = new Size(54, 20);
            mnuFichier.Tag = "H15PCSD";
            mnuFichier.Text = "&Fichier";
            // 
            // mnuFichierQuitter
            // 
            mnuFichierQuitter.Name = "mnuFichierQuitter";
            mnuFichierQuitter.ShortcutKeys = Keys.Control | Keys.Q;
            mnuFichierQuitter.Size = new Size(154, 22);
            mnuFichierQuitter.Text = "&Quitter";
            mnuFichierQuitter.Click += mnuFichierQuitter_Click;
            // 
            // mnuAdministrateur
            // 
            mnuAdministrateur.DropDownItems.AddRange(new ToolStripItem[] { mnuAdminListeClients, mnuAdminListeTransactions });
            mnuAdministrateur.Enabled = false;
            mnuAdministrateur.Name = "mnuAdministrateur";
            mnuAdministrateur.Size = new Size(98, 20);
            mnuAdministrateur.Text = "&Administrateur";
            mnuAdministrateur.Click += mnuAdministrateur_Click;
            // 
            // mnuAdminListeClients
            // 
            mnuAdminListeClients.Enabled = false;
            mnuAdminListeClients.Name = "mnuAdminListeClients";
            mnuAdminListeClients.ShortcutKeys = Keys.Alt | Keys.C;
            mnuAdminListeClients.Size = new Size(232, 22);
            mnuAdminListeClients.Text = "Liste des clients...";
            mnuAdminListeClients.Click += mnuAdminListeClients_Click;
            // 
            // mnuAdminListeTransactions
            // 
            mnuAdminListeTransactions.Enabled = false;
            mnuAdminListeTransactions.Name = "mnuAdminListeTransactions";
            mnuAdminListeTransactions.ShortcutKeys = Keys.Alt | Keys.T;
            mnuAdminListeTransactions.Size = new Size(232, 22);
            mnuAdminListeTransactions.Text = "Liste des transactions...";
            mnuAdminListeTransactions.Click += mnuAdminListeTransactions_Click;
            // 
            // errIdentification
            // 
            errIdentification.ContainerControl = this;
            // 
            // FrmPrincipal
            // 
            AcceptButton = btnConnexion;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 395);
            Controls.Add(grpInfosClient);
            Controls.Add(grpIdentification);
            Controls.Add(mnuPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = mnuPrincipal;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guichet Automatique ";
            FormClosing += FrmPrincipal_FormClosing;
            grpIdentification.ResumeLayout(false);
            grpIdentification.PerformLayout();
            grpInfosClient.ResumeLayout(false);
            grpInfosClient.PerformLayout();
            mnuPrincipal.ResumeLayout(false);
            mnuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errIdentification).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox grpIdentification;
        public System.Windows.Forms.Label lblNumClient;
        public System.Windows.Forms.Button btnConnexion;
        public System.Windows.Forms.Label lblMotDePasse;
        public System.Windows.Forms.TextBox txtNumClient;
        public System.Windows.Forms.GroupBox grpInfosClient;
        public System.Windows.Forms.TextBox txtSolde;
        public System.Windows.Forms.Label lblSolde;
        public System.Windows.Forms.TextBox txtNom;
        public System.Windows.Forms.Label lblNom;
        public System.Windows.Forms.Button btnDeposer;
        public System.Windows.Forms.ComboBox cboMontant;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.MenuStrip mnuPrincipal;
        public System.Windows.Forms.ToolStripMenuItem mnuFichier;
        public System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        public System.Windows.Forms.Label lblSorteCompte;
        public System.Windows.Forms.ToolStripMenuItem mnuAdministrateur;
        public System.Windows.Forms.ToolStripMenuItem mnuAdminListeClients;
        public System.Windows.Forms.ToolStripMenuItem mnuAdminListeTransactions;
        public System.Windows.Forms.TextBox txtMotDePasse;
        public System.Windows.Forms.ErrorProvider errIdentification;
        public System.Windows.Forms.Button btnRetirer;
        public TextBox txtSorteCompte;
    }
}

