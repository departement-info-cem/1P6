using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compte
{
    public partial class FrmCompte : Form
    {
        // TODO 01 : Définir une variable m_objThermostat pour Thermostat
       

        public FrmCompte()
        {
            InitializeComponent();


            // TODO 02 : Instancier la variable compte pour créer un compte à votre nom            
            
            // TODO 03 : Utiliser la méthode AfficherInfosCompte pour afficher les informations du compte
           

        }

        private void btnDepot_Click(object sender, EventArgs e)
        {
            // TODO 05 : Compléter le code pour permettre de déposer un montant et actualiser l'affichage des informations du compte
            // Utiliser la méthode Deposer() de l'objet
            
        }

        private void btnRetrait_Click(object sender, EventArgs e)
        {
            // TODO 06 : Compléter le code pour permettre de retirer un montant et actualiser l'affichage des informations du compte
            // Utiliser la méthode Retirer() de l'objet
           
        }
        private void AfficherInfosCompte()
        {
            // TODO 04 : Compléter le code pour afficher les informations du compte    
           

        }

       
    }
}

