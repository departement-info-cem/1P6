namespace AppGuichet
{
    partial class FrmListeTransactions
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
            lsvTransactions = new ListView();
            clhOperation = new ColumnHeader();
            clhNoClient = new ColumnHeader();
            clhDate = new ColumnHeader();
            clhMontant = new ColumnHeader();
            lblOpération = new Label();
            cboOpération = new ComboBox();
            lblNbrTransactions = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lsvTransactions
            // 
            lsvTransactions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lsvTransactions.Columns.AddRange(new ColumnHeader[] { clhOperation, clhNoClient, clhDate, clhMontant });
            lsvTransactions.FullRowSelect = true;
            lsvTransactions.GridLines = true;
            lsvTransactions.Location = new Point(9, 60);
            lsvTransactions.Margin = new Padding(4, 3, 4, 3);
            lsvTransactions.MultiSelect = false;
            lsvTransactions.Name = "lsvTransactions";
            lsvTransactions.Size = new Size(411, 371);
            lsvTransactions.TabIndex = 1;
            lsvTransactions.UseCompatibleStateImageBehavior = false;
            lsvTransactions.View = View.Details;
            // 
            // clhOperation
            // 
            clhOperation.Text = "Opération";
            clhOperation.Width = 80;
            // 
            // clhNoClient
            // 
            clhNoClient.Text = "Numéro client";
            clhNoClient.TextAlign = HorizontalAlignment.Right;
            clhNoClient.Width = 100;
            // 
            // clhDate
            // 
            clhDate.Text = "Date";
            clhDate.Width = 130;
            // 
            // clhMontant
            // 
            clhMontant.Text = "Montant";
            clhMontant.TextAlign = HorizontalAlignment.Right;
            clhMontant.Width = 100;
            // 
            // lblOpération
            // 
            lblOpération.AutoSize = true;
            lblOpération.Location = new Point(9, 17);
            lblOpération.Margin = new Padding(4, 0, 4, 0);
            lblOpération.Name = "lblOpération";
            lblOpération.Size = new Size(93, 15);
            lblOpération.TabIndex = 2;
            lblOpération.Text = "Filtre opération :";
            // 
            // cboOpération
            // 
            cboOpération.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOpération.FormattingEnabled = true;
            cboOpération.Items.AddRange(new object[] { "Toutes", "Dépôt", "Retrait" });
            cboOpération.Location = new Point(112, 14);
            cboOpération.Margin = new Padding(4, 3, 4, 3);
            cboOpération.Name = "cboOpération";
            cboOpération.Size = new Size(210, 23);
            cboOpération.TabIndex = 3;
            cboOpération.SelectedIndexChanged += cboOpération_SelectedIndexChanged;
            // 
            // lblNbrTransactions
            // 
            lblNbrTransactions.BorderStyle = BorderStyle.FixedSingle;
            lblNbrTransactions.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNbrTransactions.Location = new Point(372, 14);
            lblNbrTransactions.Margin = new Padding(4, 0, 4, 0);
            lblNbrTransactions.Name = "lblNbrTransactions";
            lblNbrTransactions.Size = new Size(44, 24);
            lblNbrTransactions.TabIndex = 4;
            lblNbrTransactions.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 5;
            label1.Text = "Nbr :";
            // 
            // FrmListeTransactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 444);
            Controls.Add(label1);
            Controls.Add(lblNbrTransactions);
            Controls.Add(cboOpération);
            Controls.Add(lblOpération);
            Controls.Add(lsvTransactions);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(446, 11532);
            MinimumSize = new Size(446, 167);
            Name = "FrmListeTransactions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Liste des transactions à ce guichet";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView lsvTransactions;
        public System.Windows.Forms.ColumnHeader clhOperation;
        public System.Windows.Forms.ColumnHeader clhNoClient;
        public System.Windows.Forms.ColumnHeader clhDate;
        public System.Windows.Forms.ColumnHeader clhMontant;
        public System.Windows.Forms.Label lblOpération;
        public System.Windows.Forms.ComboBox cboOpération;
        private System.Windows.Forms.Label lblNbrTransactions;
        public System.Windows.Forms.Label label1;
    }
}