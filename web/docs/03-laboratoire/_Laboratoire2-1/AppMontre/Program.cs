using System;

namespace AppMontre
{
    /// <summary>
    /// Ce programme instancie une montre, il permet de modifier les heures, minutes et secondes de la montre.
    /// Il permet également de faire avancer le temps de la montre d'une seconde.
    /// 
    ///  TODO : Ajoutez une nouvelle classe au projet nommée AppMontre qui correspond à la structure de classe fournie
    /// dans l'énoncé.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {

            bool quitter = false;

            while (!quitter)
            {
                Console.Clear();

                Console.WriteLine("=== Menu Principal ===");
                Console.WriteLine("1 - Avancer la montre d'une seconde");
                Console.WriteLine("2 - Initialiser la montre à 0:00:00");
                Console.WriteLine("3 - Initialiser la montre à 12:30:59");
                Console.WriteLine("4 - Initialiser la montre à 12:59:59");
                Console.WriteLine("5 - Initialiser la montre à 23:59:59");
                Console.WriteLine("Q - Quitter");
                Console.WriteLine("=======================");
                Console.Write("Veuillez sélectionner une option : ");
            }
        }
    }
}