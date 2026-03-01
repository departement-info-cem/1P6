using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCompteurHydro
{
    public class CompteurHydro
    {
        /// <summary>
        /// Constante : stocke le prix (en dollars) d'un KWh
        /// </summary>
        public const double PRIX_KWH = 0.6905;

        /// <summary>
        /// Champ : stocke la consommation actuelle du compteur.
        /// </summary>
        private int m_consommationActuelle;

        /// <summary>
        /// Propriété : permet d'accéder à la consommation actuelle du compteur.
        /// </summary>
        public int ConsommationActuelle
        {
            // Accès en lecture uniquement
            get { return m_consommationActuelle; }
        }

        /// <summary>
        /// Constructeur : initialise une nouvelle instance de la classe CompteurHydro.
        /// </summary>
        public CompteurHydro()
        {
            // Initialisation du champ
            m_consommationActuelle = 0;
        }

        /// <summary>
        /// Méthode : ajoute une quantité d'électricité à la consommation actuelle.
        /// </summary>
        /// <param name="pQuantitéKwh">
        /// Quantité d'électricité (en kWh) à ajouter.
        /// </param>
        public void Consommer(int pQuantitéKwh)
        {
            // Mise à jour du champ
            m_consommationActuelle += pQuantitéKwh;
        }
        /// <summary>
        /// Méthode : Calcule le cout de la consommation
        /// </summary>
        /// <returns>coût (en dollars) de la consommation actuelle</returns>
        public double CoutConsommation()
        {

            return PRIX_KWH * m_consommationActuelle / 100;
        }
    }
}
