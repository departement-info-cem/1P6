using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1_1_Ex3
{
    internal class Program
    {
        static void Main()
        {
            // Instancie un objet de type Personnage en lui attribuant le nom “Link”
            Personnage unPersonnage = new Personnage("Link");

            Console.WriteLine(unPersonnage.afficherEtat());
            Console.WriteLine("Le personnage s'entraine...");

            // Augmenter les points jusqu'à 15
            while (unPersonnage.Points < Personnage.PALIER_HERO)
            {

                unPersonnage.GagnerUnPoint();
                Console.Write(".");

                // Changement d'état
                if (unPersonnage.Points == Personnage.PALIER_APPRENTI)
                {
                    unPersonnage.Niveau = Personnage.NIVEAU_APPRENTI;
                    Console.WriteLine($"\n>>> Nouveau niveau atteint: {unPersonnage.Niveau} (Nb points {unPersonnage.Points})");
                }
                else if (unPersonnage.Points == Personnage.PALIER_GUERRIER)
                {
                    unPersonnage.Niveau = Personnage.NIVEAU_GUERRIER;
                    Console.WriteLine($"\n>>> Nouveau niveau atteint: {unPersonnage.Niveau} (Nb points {unPersonnage.Points})");
                }
                else if (unPersonnage.Points == Personnage.PALIER_HERO)
                {
                    unPersonnage.Niveau = Personnage.NIVEAU_HERO;
                    Console.WriteLine($"\n>>> Nouveau niveau atteint: {unPersonnage.Niveau} (Nb points {unPersonnage.Points})");
                }
            }

            Console.WriteLine("\n--- Fin ---");
            Console.WriteLine(unPersonnage.afficherEtat());
        }
    }
}

