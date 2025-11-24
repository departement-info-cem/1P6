using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Librairie1P6;
namespace DemoPouleMagique
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Créer une nouvelle instance de PouletMagique
            PouletMagique poule = new PouletMagique();

            // La poule se met à danser
            poule.Danser();

            // La poule pond un œuf
            poule.Pondre();

            // La poule pousse son cri de guerre
            poule.CrisDeGuerre();

            // La poule mange 2 grains de maïs
            poule.MangerMais(2);

            // La poule exécute son action spéciale
            poule.ActionSpeciale();


            // Récupérer le nombre total de poules créées (propriété statique)
            int nbPoules = PouletMagique.NombrePoules;

            // Créer une nouvelle poule et vérifier à nouveau le compteur
            PouletMagique autrePoule = new PouletMagique();
            nbPoules = PouletMagique.NombrePoules;

            // Obtenir la taille maximale possible d'une poule (constante de la classe)
            int tailleMax = PouletMagique.TAILLE_MAX;

        }
    }
}


