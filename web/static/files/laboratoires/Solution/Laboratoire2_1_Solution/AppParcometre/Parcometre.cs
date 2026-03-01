using System;

namespace AppParcometre
{

    /// =============================================================================
    /// <summary>
    /// Représente un parcomètre dans lequel on peut insérer des pièces de monnaie
    /// et simuler le temps qui passe.
    /// </summary>
    public class Parcometre
    {
        #region Constantes
        public const int COUT_PAR_MINUTE = 5; // 5 cents la minute
        public const int MONTANT_MINIMUM = 25; // 25 cents
        #endregion

        #region Champs et Propriétés
        // =============================================================================
        // Nombre de minutes qui reste
        private int m_minutesRestantes;

        /// =============================================================================
        private int m_montantTotal; // montant total ajouté dans le parcomètre
        ///-----------------------------------------------------------------------------
        /// <summary>
        /// Permet d'obtenir le montant total ajouté dans le parcomètre
        /// </summary>
        public int MontantTotal
        {
            get
            {
                return m_montantTotal;
            }
        }
        #endregion

        #region Constructeurs
        /// =============================================================================
        /// <summary>
        ///  Initialise une nouvelle instance de la classe Parcomètre. 
        ///  Il n'y a pas d'argent dans le parcomètre.
        /// </summary>
        public Parcometre()
        {
            m_montantTotal = 0;
            m_minutesRestantes = 0;
        }
        #endregion

        #region Méthodes
        /// =============================================================================
        /// <summary>
        ///  Insère un montant d'argent en cents ajoute des minutes au parcomètre
        /// </summary>
        /// <param name="pMonnaie">montant à inséré</param>
        public void insererMonnaie(int pMonnaie)
        {
            m_minutesRestantes += pMonnaie / COUT_PAR_MINUTE;
            m_montantTotal += pMonnaie;
        }
        /// =============================================================================
        /// <summary>
        ///   Simuler le temps qui passe par étape de 1 minute.
        /// </summary>
        public void consommerUneMinuteDeTemps()
        {
            m_minutesRestantes--;
        }

        /// =============================================================================
        /// <summary>
        ///  Obtient le temps qui reste avant l'infraction.
        ///  L'information est formatée dans un chaîne comme suit : HH:MM
        /// </summary>
        public string TempsRestant()
        {
            int nbHeures = m_minutesRestantes / 60;
            int nbMinutes = m_minutesRestantes % 60;
            return nbHeures.ToString("00") + ":" + nbMinutes.ToString("00");
        }

        /// <summary>
        /// Obtient l'état de la transaction avec l'utilisateur.
        /// Il est en infraction si le nombre de minutes restantes est 0
        /// </summary>
        /// <returns>retourne vrai si en infraction</returns>
        public bool EstEnInfraction()
        {
            return m_minutesRestantes == 0;
        }
        #endregion
    }
}
