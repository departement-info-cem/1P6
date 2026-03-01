
namespace Labo1_1_Ex3
{
    public class Personnage
    {
        // Constantes (paliers)
        public const int PALIER_APPRENTI = 5;
        public const int PALIER_GUERRIER = 10;
        public const int PALIER_HERO = 15;

        // Constantes (niveaux)
        public const string NIVEAU_DEBUTANT = "DEBUTANT";
        public const string NIVEAU_APPRENTI = "APPRENTI";
        public const string NIVEAU_GUERRIER = "GUERRIER";
        public const string NIVEAU_HERO = "HERO";

        public string Nom { get; private set; }
        public int Points { get; private set; }
        public string Niveau { get; set; } 

        public Personnage(string nom)
        {
            Nom = nom;
            Points = 0;
            Niveau = NIVEAU_DEBUTANT;
        }
   
        public Personnage(string nom, int points, string niveau)
        {
            Nom = nom;
            Points = points;
            Niveau = niveau;
        }

        public void GagnerUnPoint()
        {
            Points++;
        }

        public string afficherEtat()
        {
                return $"{Nom} | Points {Points} | Niveau : {Niveau}";
        }
    }


}