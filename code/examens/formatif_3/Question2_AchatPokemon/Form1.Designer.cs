namespace Question2_AchatPokemon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNomClient = new Label();
            txtNomClient = new TextBox();
            lblCartes = new Label();
            listBoxCartes = new ListBox();
            pictureBoxCarte = new PictureBox();
            btnAcheter = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCarte).BeginInit();
            SuspendLayout();
            // 
            // lblNomClient
            // 
            lblNomClient.AutoSize = true;
            lblNomClient.Font = new Font("Segoe UI", 10F);
            lblNomClient.Location = new Point(20, 20);
            lblNomClient.Name = "lblNomClient";
            lblNomClient.Size = new Size(102, 19);
            lblNomClient.TabIndex = 0;
            lblNomClient.Text = "Nom du client :";
            // 
            // txtNomClient
            // 
            txtNomClient.Font = new Font("Segoe UI", 10F);
            txtNomClient.Location = new Point(20, 45);
            txtNomClient.Name = "txtNomClient";
            txtNomClient.Size = new Size(350, 25);
            txtNomClient.TabIndex = 1;
            // 
            // lblCartes
            // 
            lblCartes.AutoSize = true;
            lblCartes.Font = new Font("Segoe UI", 10F);
            lblCartes.Location = new Point(20, 90);
            lblCartes.Name = "lblCartes";
            lblCartes.Size = new Size(152, 19);
            lblCartes.TabIndex = 2;
            lblCartes.Text = "Sélectionnez une carte :";
            // 
            // listBoxCartes
            // 
            listBoxCartes.Font = new Font("Segoe UI", 9F);
            listBoxCartes.FormattingEnabled = true;
            listBoxCartes.ItemHeight = 15;
            listBoxCartes.Location = new Point(20, 115);
            listBoxCartes.Name = "listBoxCartes";
            listBoxCartes.Size = new Size(350, 304);
            listBoxCartes.TabIndex = 3;
            listBoxCartes.SelectedIndexChanged += listBoxCartes_SelectedIndexChanged;
            // 
            // pictureBoxCarte
            // 
            pictureBoxCarte.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxCarte.Location = new Point(390, 115);
            pictureBoxCarte.Name = "pictureBoxCarte";
            pictureBoxCarte.Size = new Size(250, 350);
            pictureBoxCarte.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCarte.TabIndex = 4;
            pictureBoxCarte.TabStop = false;
            // 
            // btnAcheter
            // 
            btnAcheter.BackColor = Color.FromArgb(76, 175, 80);
            btnAcheter.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAcheter.ForeColor = Color.White;
            btnAcheter.Location = new Point(20, 435);
            btnAcheter.Name = "btnAcheter";
            btnAcheter.Size = new Size(350, 45);
            btnAcheter.TabIndex = 5;
            btnAcheter.Text = "Acheter";
            btnAcheter.UseVisualStyleBackColor = false;
            btnAcheter.Click += btnAcheter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 501);
            Controls.Add(btnAcheter);
            Controls.Add(pictureBoxCarte);
            Controls.Add(listBoxCartes);
            Controls.Add(lblCartes);
            Controls.Add(txtNomClient);
            Controls.Add(lblNomClient);
            Name = "Form1";
            Text = "Achat de cartes Pokemon";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCarte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxCarte;
        private ListBox listBoxCartes;
        private TextBox txtNomClient;
        private Button btnAcheter;
        private Label lblNomClient;
        private Label lblCartes;
    }
}
