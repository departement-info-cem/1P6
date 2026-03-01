using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCompteurHydro
{
    internal class Program
    {
        // Variable globale
        static CompteurHydro compteur = new CompteurHydro();
        static void Main(string[] args)
        {
            

            bool quitter = false;

            while (!quitter)
            {
                Console.Clear();

                Console.WriteLine("=== Menu Principal ===");
                Console.WriteLine("1 - Consommer une quantité de kWh");
                Console.WriteLine("2 - Afficher la consommation actuelle");
                Console.WriteLine("3 - Afficher le coût de la consommation");
                Console.WriteLine("Q - Quitter");
                Console.WriteLine("=======================");
                Console.Write("Veuillez sélectionner une option : ");

                string choix = Console.ReadLine().ToUpper();

                switch (choix)
                {
                    case "1":
                        Console.Write("\nEntrez la quantité à consommer (kWh) : ");

                        int quantite;

                        if (int.TryParse(Console.ReadLine(), out quantite) && quantite > 0)
                        {
                            compteur.Consommer(quantite);
                            Console.WriteLine("\nConsommation ajoutée avec succès !");
                        }
                        else
                        {
                            Console.WriteLine("\n❌ Quantité invalide !");
                        }

                       
                        break;

                    case "2":
                        Console.WriteLine($"\nConsommation actuelle : {compteur.ConsommationActuelle} kWh");

                        
                        break;

                    case "3":
                        double cout = compteur.CoutConsommation();

                        Console.WriteLine($"\nCoût total : {cout:F2} $");

                        
                        break;

                    case "Q":
                        quitter = true;
                        break;

                    default:
                        Console.WriteLine("\n❌ Choix invalide !");                        
                        break;
                }
                if (!quitter)
                {
                    Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                    Console.ReadKey();
                }
            }
        }

        

    }
}
