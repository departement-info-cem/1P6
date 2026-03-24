using System.Runtime.InteropServices;

namespace AppGuichet
{
    partial class FrmListeClients
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
            lsvClients = new ListView();
            clhNo = new ColumnHeader();
            clhNom = new ColumnHeader();
            clhRole = new ColumnHeader();
            clhSorte = new ColumnHeader();
            clhSolde = new ColumnHeader();
            SuspendLayout();
            // 
            // lsvClients
            // 
            lsvClients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lsvClients.Columns.AddRange(new ColumnHeader[] { clhNo, clhNom, clhRole, clhSorte, clhSolde });
            lsvClients.FullRowSelect = true;
            lsvClients.GridLines = true;
            lsvClients.Location = new Point(9, 14);
            lsvClients.Margin = new Padding(4, 3, 4, 3);
            lsvClients.MultiSelect = false;
            lsvClients.Name = "lsvClients";
            lsvClients.Size = new Size(500, 189);
            lsvClients.TabIndex = 2;
            lsvClients.UseCompatibleStateImageBehavior = false;
            lsvClients.View = View.Details;
            // 
            // clhNo
            // 
            clhNo.Text = "No";
            clhNo.Width = 50;
            // 
            // clhNom
            // 
            clhNom.Text = "Nom";
            clhNom.Width = 120;
            // 
            // clhRole
            // 
            clhRole.Text = "Rôle";
            clhRole.Width = 120;
            // 
            // clhSorte
            // 
            clhSorte.Text = "Sorte compte";
            clhSorte.Width = 90;
            // 
            // clhSolde
            // 
            clhSolde.Text = "Solde";
            clhSolde.Width = 110;
            // 
            // FrmListeClients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 215);
            Controls.Add(lsvClients);
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(538, 11532);
            MinimizeBox = false;
            MinimumSize = new Size(538, 167);
            Name = "FrmListeClients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Liste des clients de la banque";
            ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView lsvClients;
        public System.Windows.Forms.ColumnHeader clhNo;
        public System.Windows.Forms.ColumnHeader clhNom;
        public System.Windows.Forms.ColumnHeader clhSolde;
        private ColumnHeader clhRole;
        private ColumnHeader clhSorte;
    }
}