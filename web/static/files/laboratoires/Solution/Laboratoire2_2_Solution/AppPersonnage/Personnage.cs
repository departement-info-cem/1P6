using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPersonnage
{

    public class Personnage
    {
        // =========================
        // Constantes
        // =========================
        public const int PV_MAX = 100;
        public const int AGE_MIN = 12;
        public const int AGE_MAX = 80;

        public const string NOM_PAR_DEFAUT = "Anonyme";
        public const int AGE_PAR_DEFAUT = 18;
        public const char CLASSE_PAR_DEFAUT = 'G';

        // =========================
        // Champs privés
        // =========================
        private string m_nom;
        private int m_age;
        private char m_classe;
        private int m_pointsDeVie;

        // =========================
        // Propriétés
        // =========================
        public string Nom
        {
            get { return m_nom; }
            private set { m_nom = value; }

        }

        public int Age
        {
            get { return m_age; }
            private set { m_age = value; }
        }

        public char Classe
        {
            get { return m_classe; }
            private set { m_classe = value; }
        }

        public int PointsDeVie
        {
            get { return m_pointsDeVie; }
            private set { m_pointsDeVie = value; }

        }

        // =========================
        // Propriétés automatiques
        // =========================
        public int Force { get; private set; }
        public int Intelligence { get; private set; }
        // =========================
        // Propriétés calculées
        // =========================
        public int Vitesse
        {
            get
            {
                switch (m_classe)
                {
                    case 'G': return 2;
                    case 'M': return 3;
                    case 'V': return 4;
                    default: return 2;
                }
                ;
            }
        }

        public bool EstVivant
        {
            get
            {

                return PointsDeVie > 0;
            }
        }
        public int StatPrincipale
        {
            get
            {

                switch (m_classe)
                {
                    case 'G': return Force;
                    case 'M': return Intelligence;
                    case 'V': return Vitesse;
                    default: return Force;
                }
                ;
            }
        }

        // =========================
        // Constructeurs
        // =========================
        public Personnage()
        {
            Nom = NOM_PAR_DEFAUT;
            Age = AGE_PAR_DEFAUT;
            Classe = CLASSE_PAR_DEFAUT;

            calculerStatistiques();
        }

        public Personnage(string nom, int age, char classe)
        {
            if (nom == "")
            {
                Nom = NOM_PAR_DEFAUT;
            }
            else { Nom = nom; }
            if (!(age >= AGE_MIN && age <= AGE_MAX))
            {
                age = AGE_PAR_DEFAUT;
            }
            else { Age = age; }
            if (classe != 'G' && classe != 'M' && classe != 'V')
            {
                Classe = CLASSE_PAR_DEFAUT;
            }
            else
            {
                Classe = classe;
            }


                calculerStatistiques();

        }

        // =========================
        // Méthodes publiques
        // =========================
        public void recevoirDegats(int degats)
        {
            if (degats < 0) return;
            if ((PointsDeVie - degats) >0)
            {
                PointsDeVie -= degats;
            }
            else
            {
                PointsDeVie = 0;
            }
                
        }

        public void soigner(int points)
        {
            if (points < 0) return;

            if ((PointsDeVie + points) <= PV_MAX)
            {
                PointsDeVie += points;
            }
            else
            {
                PointsDeVie = PV_MAX;
            }
            
        }

        public int PuissanceAttaque()
        {
            if (!EstVivant) return 0;

            return StatPrincipale * 2;
        }

        public string Fiche()
        {
            return
                $"Nom           : {Nom}\n" +
                $"Âge           : {Age}\n" +
                $"Classe        : {Classe}\n" +
                $"PV            : {PointsDeVie}/{PV_MAX}\n" +
                $"Force         : {Force}\n" +
                $"Intelligence  : {Intelligence}\n" +
                $"Vitesse       : {Vitesse}\n" +
                $"Stat principale : {StatPrincipale}\n" +
                $"État          : {(EstVivant ? "Vivant" : "Mort")}";
        }

        // =========================
        // Méthodes privées
        // =========================
        private void calculerStatistiques()
        {


            switch (m_classe)
            {
                case 'G':
                    Intelligence = 5;
                    Force = 15;
                    PointsDeVie = 20;
                    break;
                case 'M':
                    Intelligence = 18;
                    Force = 5;
                    PointsDeVie = 12;
                    break;
                case 'V':
                    Intelligence = 10;
                    Force = 10;
                    PointsDeVie = 15;
                    break;
            }

            if (m_age > 40)
            {
                Intelligence += 10;
                Force += 10;
                PointsDeVie -= 10;
            }
            else
            {
                Intelligence -= 5;
                Force -= 5;
            }
        }
    }


}
