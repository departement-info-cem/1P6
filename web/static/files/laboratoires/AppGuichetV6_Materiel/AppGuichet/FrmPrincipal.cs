using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Models;

namespace AppGuichet
{
    /// =====================================================================================================================
    /// <summary>
    /// Représente l’utilisation d’un guichet automatique. Un client peut se connecter avec son numéro et son mot de passe.
    /// Il peut retirer de l’argent si son solde le permet. L’administrateur du guichet peut demander la liste des clients
    /// où la liste des transactions effectuées sur le guichet.
    /// </summary>
    /// ======================================================================================================================
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "(Démo)";

        #region Constantes
        //--- CHAMPS: constantes ----------------------------------------------------------
        public const string CHEMIN_FICHIER_CLIENTS = "../../../Fichiers/Clients.csv";
               public const string CHEMIN_FICHIER_TRANSACTIONS = "../../../Fichiers/Transactions.csv";
        #endregion

        #region Champs et Propriétés
       


        #endregion

        #region Constructeur
        //---------------------------------------------------------------------------------
        public FrmPrincipal()
        {
            InitializeComponent();
            this.Text += APP_INFO;
           

        }
        #endregion





        #region Menu Administrateur
        //---------------------------------------------------------------------------------
        private void mnuAdminListeClients_Click(object sender, EventArgs e)
        {
          
        }
        //---------------------------------------------------------------------------------
        private void mnuAdminListeTransactions_Click(object sender, EventArgs e)
        {
           
        }


        #endregion

        private void FrmPrincipal_FormClosing(object sender, EventArgs e)
        {
           
            
        }
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
           
           
           
        }

       

        #region Bouton Connexion/Déconnexion 
        //---------------------------------------------------------------------------------
        public void btnConnexion_Click(object sender, EventArgs e)
        {
            

            
        }
        #endregion

        #region Bouton Retirer et Événement Combo Montant à retirer
        //---------------------------------------------------------------------------------
        //Retire le montant choisi
        public void btnDeposer_Click(object sender, EventArgs e)
        {
            

           
        }
        //---------------------------------------------------------------------------------
        //Choix du montant à retirer
        private void cboMontant_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        #endregion

        private void btnRetirer_Click(object sender, EventArgs e)
        {
            

           
        }

        

        private void mnuAdministrateur_Click(object sender, EventArgs e)
        {

        }
    }
}