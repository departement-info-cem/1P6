using System;

namespace AppMultiThermostat
{
    /// ------------------------------------------------------------------------------------
    /// <summary>
    /// Représente un thermostat électronique contrôlant la température d'une 
    /// plinthe de chauffage,ce qui correspond généralement à une pièce d'un établissement.
    /// </summary>
    /// ------------------------------------------------------------------------------------
    public class Thermostat
    {
        #region Constantes
        /// ================================================================================
        /// <summary>
        /// Température minimale autorisée par un Thermostat
        /// </summary>
        public const double MIN_TEMPERATURE = 5.0;

        /// ================================================================================
        /// <summary>
        /// Température maximale autorisée par un Thermostat
        /// </summary>
        public const double MAX_TEMPERATURE = 35.0;

        /// ================================================================================
        /// <summary>
        /// Température initiale d'un Thermostat
        /// </summary>
        private const double TEMPERATURE_DÉFAUT = 20.0;

        #endregion

        #region CHAMPS (variables membre) ET PROPRIÉTÉS
        ///==================================================================================
        private double m_temperature;
        /// ---------------------------------------------------------------------------------
        /// <summary>
        ///    Obtient la température actuelle du thermostat
        /// </summary>
        public double Temperature
        {
            get { return m_temperature; }

        }
        #endregion

        #region CONSTRUCTEUR
        ///======================================================================================
        /// <summary>
        ///   Initialise une nouvelle instance de la classe Thermostat à la température initiale. 
        /// </summary>
        ///--------------------------------------------------------------------------------------
        public Thermostat()
        {
            m_temperature = TEMPERATURE_DÉFAUT;
        }

        #endregion

        #region MÉTHODES
        ///==================================================================================
        /// <summary>
        ///   Augmente la température d'un degré.
        /// </summary>
        /// ---------------------------------------------------------------------------------
        public void augmenterTemperature()
        {
            if (m_temperature < MAX_TEMPERATURE)
            {
                m_temperature++;
            }
        }
        ///==================================================================================
        /// <summary>
        ///   Diminue la température d'un degré.
        /// </summary>
        /// ---------------------------------------------------------------------------------
        public void diminuerTemperature()
        {
            if (m_temperature > MIN_TEMPERATURE)
            {
                m_temperature--;
            }

        }

        #endregion
    }
}
