using System;
using System.Windows.Forms;
using Librairie1N6;

namespace MultiThermostat
{
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "(Matériel)";

        /// =================================================================================
        // TODO 01A : Déclarer une variable et Instancier un Thermostat pour la chambre à 25
        

        // TODO 01B : Déclarer une variable et Instancier un Thermostat pour la cuisine à 20
       

        // TODO 01C : Déclarer une variable et Instancier un Thermostat pour le salon à 22
      

        // TODO 01D : Déclarer une variable supplémentaire pour référer sur le Thermostat courant (NE PAS INSTANCIER)
       
        //====================================================================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;

            // TODO 02A : Fixer le Thermostat courant à celui de la chambre
          

            // TODO 02B : Afficher la température du Thermostat courant
            
        }

        //====================================================================================
        private void radChambre_CheckedChanged(object sender, EventArgs e)
        {
            // TODO 03A : Modifier le Thermostat courant pour référer sur celui de la chambre
            
            // TODO 03B : Afficher la température du Thermostat courant
        
            // TODO 03C : Appeler la méthode ActualiserBoutonsSelonContexte
           
        }
        //====================================================================================
        private void radCuisine_CheckedChanged(object sender, EventArgs e)
        {
            // TODO 04A : Modifier le Thermostat courant pour référer sur celui de la cuisine
           
            // TODO 04B : Afficher la température du Thermostat courant
           
            // TODO 04C : Appeler la méthode ActualiserBoutonsSelonContexte
           
        }
        //====================================================================================
        private void radSalon_CheckedChanged(object sender, EventArgs e)
        {
            // TODO 05A : Modifier le Thermostat courant pour référer sur celui du salon
          
            // TODO 05B : Afficher la température du Thermostat courant
           
            // TODO 05C : Appeler la méthode ActualiserBoutonsSelonContexte
          
        }
        //====================================================================================
        private void btnAugmenter_Click(object sender, System.EventArgs e)
        {
            // TODO 06A : Augmenter la température du Thermostat courant
           
            // TODO 06B : Afficher la température du Thermostat courant
           
            // TODO 06C : Appeler la méthode ActualiserBoutonsSelonContexte
           
        }
        //====================================================================================
        private void btnDiminuer_Click(object sender, System.EventArgs e)
        {
            // TODO 07A : Diminuer la température du Thermostat courant
           
            // TODO 07B : Afficher la température du Thermostat courant
           
            // TODO 07C : Appeler la méthode ActualiserBoutonsSelonContexte
           
        }
        //====================================================================================
        private void mnuAffichageTempMin_Click(object sender, EventArgs e)
        {
            // TODO 08A : Afficher la température minimale permise par un Thermostat


            #region NE PAS MODIFIER // Démarrer l'horloge tmrTempératureCourante
            tmrTempératureCourante.Start();
            #endregion

        }
        //====================================================================================
        private void mnuAffichageTempMax_Click(object sender, EventArgs e)
        {
            // TODO 09A : Afficher la température maximale permise par un Thermostat

            #region NE PAS MODIFIER // Démarrer l'horloge tmrTempératureCourante
            tmrTempératureCourante.Start();
            #endregion
        }
        //====================================================================================
        private void TmrTempératureCourante_Tick(object sender, EventArgs e)
        {
            // TODO 10A : Arrêter l'horloge tmrTempérature
           
            // TODO 10B : Afficher la température actuelle du Thermostat courant
           
        }
        //====================================================================================
        private void ActualiserBoutonsSelonContexte()
        {
            // TODO 11A : btnDiminuer est actif seulement si la température courante est supérieure à TEMPÉRATURE_MINIMALE
           
            // TODO 11B : btnAugmenter est actif seulement si la température courante est inférieure à TEMPÉRATURE_MAXIMALE
           
        }

        //====================================================================================
        private void mnuFichierQuitter_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}