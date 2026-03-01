using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AppRobot
{
    public class Robot
    {
        // =======================
        // Constantes
        // =======================
        public const int VITESSE_MAX = 10;
        public const string NOM_PAR_DEFAUT = "Anonyme"; // km/h


        // =======================
        // Champs privés
        // =======================
        private int m_vitesseActuelle; // km/h
        private bool m_estAllume; // true si le robot est allumé

        // =======================
        // Propriétés classiques
        // =======================


        public string Nom { get; private set; }


        // =======================
        // Propriétés calculées
        // =======================
        public bool EnMouvement
        {
            get { return m_vitesseActuelle > 0; }
        }

        public int VitesseActuelle
        {
            get { return m_vitesseActuelle; }
            private set { m_vitesseActuelle = value; }
        }

        public bool EstAllume
        {
            get { return m_estAllume; }
            private set { m_estAllume = value; }
        }

        // =======================
        // Constructeurs
        // =======================
        public Robot()
        {
            Nom = NOM_PAR_DEFAUT;
            m_vitesseActuelle = 0;
            m_estAllume = false;
        }

        public Robot(string nom)
        {
            if (nom.Length < 3)
            {
                Nom = NOM_PAR_DEFAUT;
            }
            else
            {
                Nom = nom;
            }
            VitesseActuelle = 0;
            m_estAllume = false;
        }

        // =======================
        // Méthodes
        // =======================
        public void demarrer()
        {
            if (!m_estAllume)
            {
                m_estAllume = true;

            }

        }

        public void arreter()
        {
            if (m_estAllume)
            {
                m_estAllume = false;
                VitesseActuelle = 0;

            }

        }

        public void accelerer(int vitesse)
        {
            if (m_estAllume)
            {
                if (VitesseActuelle + vitesse > VITESSE_MAX)
                    VitesseActuelle = VITESSE_MAX;
                else
                    VitesseActuelle += vitesse;
            }

        }

        public void ralentir(int vitesse)
        {
            if (m_estAllume)
            {
                int nouvelleVitesse = VitesseActuelle - vitesse;
                if (nouvelleVitesse < 0)
                    VitesseActuelle = 0;
                else
                    VitesseActuelle = nouvelleVitesse;

            }

        }


        public string Infos()
        {
            string moteur = m_estAllume ? "Oui" : "Non";
            string mouvement = EnMouvement ? "Oui" : "Non";

            return $"Robot {Nom}, Vitesse actuelle: {VitesseActuelle} km/h, Moteur en marche: {moteur}, En mouvement: {mouvement}";

        }
    }

}
