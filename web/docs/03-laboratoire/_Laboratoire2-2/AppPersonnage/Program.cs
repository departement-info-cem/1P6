using System;


namespace AppPersonnage
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            bool quitter = false;

            while (!quitter)
            {
               
                Console.WriteLine("\n=== MENU PERSONNAGE ===");
                Console.WriteLine("1. Créer un personnage");
                Console.WriteLine("2. Afficher la fiche");
                Console.WriteLine("3. Recevoir des dégâts");
                Console.WriteLine("4. Se soigner");
                Console.WriteLine("5. Calculer la puissance d'attaque");
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
