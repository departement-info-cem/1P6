using System;
using AppRobot;

namespace AppRobot
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            bool quitter = false;
            while (!quitter)
            {
                Console.WriteLine("\n=== MENU ROBOT ===");
                Console.WriteLine("1. Créer un robot");
                Console.WriteLine("2. Démarrer");
                Console.WriteLine("3. Arrêter");
                Console.WriteLine("4. Accélérer");
                Console.WriteLine("5. Ralentir");
                Console.WriteLine("6. Afficher les infos du robot");
                Console.WriteLine("Q. Quitter");
                Console.Write("Veuillez sélectionner une option : ");

                string choix = Console.ReadLine();
                Console.WriteLine();

               
                Console.WriteLine("Appuyez sur une touche pour continuer...");
                Console.ReadKey(true);
                Console.Clear();
            }
        }
    }
}
