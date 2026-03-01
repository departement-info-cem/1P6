using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppParcometre
{
    internal class Program
    {
        // Variable globale
        static Parcometre p = new Parcometre();
        static void Main(string[] args)
        {
            
            bool quitter = false;

            while (!quitter)
            {
                Console.Clear();
                Console.WriteLine("=== Menu Principal ===");
                Console.WriteLine("1 - Est en infraction?");
                Console.WriteLine("2 - Obtenir le temps restant");
                Console.WriteLine("3 - Inserer de la monnaie");
                Console.WriteLine("4 - Avancer le temps d'une minute");
                Console.WriteLine("Q - Quitter");
                Console.WriteLine("=======================");
                Console.Write("Veuillez sélectionner une option : ");

                string choix = Console.ReadLine().Trim().ToUpper();

                switch (choix)
                {
                    case "1":
                        if (p.EstEnInfraction())
                            Console.WriteLine("\n🚫 Oui, le parcomètre est en infraction (0 minute restante).");
                        else
                            Console.WriteLine("\n✅ Non, le parcomètre n'est pas en infraction.");
                       
                        break;

                    case "2":
                        Console.WriteLine($"\nTemps restant : {p.TempsRestant()}");
                        
                        break;

                    case "3":
                        Console.Write("\nEntrez un montant à insérer (en cents) : ");
                        int montant;

                        if (int.TryParse(Console.ReadLine(), out montant) && montant >= Parcometre.MONTANT_MINIMUM)
                        {
                            p.insererMonnaie(montant);
                            Console.WriteLine("\nMonnaie insérée avec succès.");
                            Console.WriteLine($"Montant total : {p.MontantTotal} cents");
                            Console.WriteLine($"Temps restant : {p.TempsRestant()}");
                        }
                        else
                        {
                            Console.WriteLine($"\n❌ Montant invalide. Minimum : {Parcometre.MONTANT_MINIMUM} cents.");
                        }

                        
                        break;

                    case "4":
                        // Empêcher d'aller en négatif (optionnel mais recommandé)
                        if (!p.EstEnInfraction())
                        {
                            p.consommerUneMinuteDeTemps();
                            Console.WriteLine("\n⏱️ Une minute s'est écoulée.");
                        }
                        else
                        {
                            Console.WriteLine("\n⚠️ Impossible d'avancer : déjà à 0 minute (infraction).");
                        }

                        Console.WriteLine($"Temps restant : {p.TempsRestant()}");
                       
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

        static void Pause()
        {
            Console.WriteLine("\nAppuyez sur une touche pour continuer...");
            Console.ReadKey();
        }

    }
}
