using System;
using System.Windows.Forms;
using Librairie1N6;

namespace MultiThermostat
{
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "(DÉMO)";

        /// =================================================================================
        // TODO 01A : Déclarer une variable et Instancier un Thermostat pour la chambre à 25
        Thermostat m_objThermostatChambre = new Thermostat(25);

        // TODO 01B : Déclarer une variable et Instancier un Thermostat pour la cuisine à 20
        Thermostat m_objThermostatCuisine = new Thermostat();

        // TODO 01C : Déclarer une variable et Instancier un Thermostat pour le salon à 22
        Thermostat m_objThermostatSalon = new Thermostat(22);

        // TODO 01D : Déclarer une variable supplémentaire pour référer sur le Thermostat courant (NE PAS INSTANCIER)
        private Thermostat m_objThermostatCourant;
        //====================================================================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;

            // TODO 02A : Fixer le Thermostat courant à celui de la chambre
            m_objThermostatCourant = m_objThermostatChambre;

            // TODO 02B : Afficher la température du Thermostat courant
            lblTemperature.Text = m_objThermostatCourant.Température.ToString();
        }

        //====================================================================================
        private void radChambre_CheckedChanged(object sender, EventArgs e)
        {
            // TODO 03A : Modifier le Thermostat courant pour référer sur celui de la chambre
            m_objThermostatCourant = m_objThermostatChambre;
            // TODO 03B : Afficher la température du Thermostat courant
            lblTemperature.Text = m_objThermostatCourant.Température.ToString();
            // TODO 03C : Appeler la méthode ActualiserBoutonsSelonContexte
            ActualiserBoutonsSelonContexte();
        }
        //====================================================================================
        private void radCuisine_CheckedChanged(object sender, EventArgs e)
        {
            // TODO 04A : Modifier le Thermostat courant pour référer sur celui de la cuisine
            m_objThermostatCourant = m_objThermostatCuisine;
            // TODO 04B : Afficher la température du Thermostat courant
            lblTemperature.Text = m_objThermostatCourant.Température.ToString();
            // TODO 04C : Appeler la méthode ActualiserBoutonsSelonContexte
            ActualiserBoutonsSelonContexte();
        }
        //====================================================================================
        private void radSalon_CheckedChanged(object sender, EventArgs e)
        {
            // TODO 05A : Modifier le Thermostat courant pour référer sur celui du salon
            m_objThermostatCourant = m_objThermostatSalon;
            // TODO 05B : Afficher la température du Thermostat courant
            lblTemperature.Text = m_objThermostatCourant.Température.ToString();
            // TODO 05C : Appeler la méthode ActualiserBoutonsSelonContexte
            ActualiserBoutonsSelonContexte();
        }
        //====================================================================================
        private void btnAugmenter_Click(object sender, System.EventArgs e)
        {
            // TODO 06A : Augmenter la température du Thermostat courant
            m_objThermostatCourant.AugmenterTemperature();
            // TODO 06B : Afficher la température du Thermostat courant
            lblTemperature.Text = m_objThermostatCourant.Température.ToString();
            // TODO 06C : Appeler la méthode ActualiserBoutonsSelonContexte
            ActualiserBoutonsSelonContexte();
        }
        //====================================================================================
        private void btnDiminuer_Click(object sender, System.EventArgs e)
        {
            // TODO 07A : Diminuer la température du Thermostat courant
            m_objThermostatCourant.DiminuerTemperature();
            // TODO 07B : Afficher la température du Thermostat courant
            lblTemperature.Text = m_objThermostatCourant.Température.ToString();
            // TODO 07C : Appeler la méthode ActualiserBoutonsSelonContexte
            ActualiserBoutonsSelonContexte();
        }
        //====================================================================================
        private void mnuAffichageTempMin_Click(object sender, EventArgs e)
        {
            // TODO 08 : Afficher la température minimale permise par un Thermostat
            lblTemperature.Text = Thermostat.TEMPÉRATURE_MINIMALE.ToString();

            #region NE PAS MODIFIER // Démarrer l'horloge tmrTempératureCourante
            tmrTempératureCourante.Start();
            #endregion
        }
        //====================================================================================
        private void mnuAffichageTempMax_Click(object sender, EventArgs e)
        {
            // TODO 09 : Afficher la température maximale permise par un Thermostat
            lblTemperature.Text = Thermostat.TEMPÉRATURE_MAXIMALE.ToString();

            #region NE PAS MODIFIER //  Démarrer l'horloge tmrTempératureCourante
            tmrTempératureCourante.Start();
            #endregion
        }
        //====================================================================================
        private void TmrTempératureCourante_Tick(object sender, EventArgs e)
        {
            #region NE PAS MODIFIER // Arrêter l'horloge tmrTempérature
            tmrTempératureCourante.Stop();
            #endregion

            // TODO 10 : Afficher la température actuelle du Thermostat courant
            lblTemperature.Text = m_objThermostatCourant.Température.ToString();
        }
        //====================================================================================
        private void ActualiserBoutonsSelonContexte()
        {
            // TODO 11A : btnDiminuer est actif seulement si la température courante est supérieure à TEMPÉRATURE_MINIMALE
            btnDiminuer.Enabled = m_objThermostatCourant.Température > Thermostat.TEMPÉRATURE_MINIMALE;
            // TODO 11B : btnAugmenter est actif seulement si la température courante est inférieure à TEMPÉRATURE_MAXIMALE
            btnAugmenter.Enabled = m_objThermostatCourant.Température < Thermostat.TEMPÉRATURE_MAXIMALE;
        }

        //====================================================================================
        private void mnuFichierQuitter_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}