using System;

namespace AppMontre
{
    /// <summary>
    /// Ce programme instancie une montre, il permet de modifier les heures, minutes et secondes de la montre.
    /// </summary>
    internal class Program
    {
        // Variable globale
        static Montre m_objMontre = new Montre(9, 5, 42);
        static void Main(string[] args)
        {
            

            bool quitter = false;

            while (!quitter)
            {
                Console.Clear();
                Console.WriteLine(m_objMontre.ObtenirTempsCourant());

                Console.WriteLine("=== Menu Principal ===");
                Console.WriteLine("1 - Avancer la montre d'une seconde");
                Console.WriteLine("2 - Initialiser la montre à 0:00:00");
                Console.WriteLine("3 - Initialiser la montre à 12:30:59");
                Console.WriteLine("4 - Initialiser la montre à 12:59:59");
                Console.WriteLine("5 - Initialiser la montre à 23:59:59");
                Console.WriteLine("Q - Quitter");
                Console.WriteLine("=======================");
                Console.Write("Veuillez sélectionner une option : ");

                char choix = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine(); // Aller à la ligne après l'entrée
                Console.Clear();
                switch (choix)
                {
                    case '1':
                        m_objMontre.AvancerUneSeconde();
                        Console.WriteLine(m_objMontre.ObtenirTempsCourant());
                        break;
                    case '2':
                        m_objMontre = new Montre();
                        Console.WriteLine(m_objMontre.ObtenirTempsCourant());
                        break;
                    case '3':
                        m_objMontre = new Montre(12, 30, 59);
                        Console.WriteLine(m_objMontre.ObtenirTempsCourant());
                        break;
                    case '4':
                        m_objMontre = new Montre(12, 59, 59);
                        Console.WriteLine(m_objMontre.ObtenirTempsCourant());
                        break;
                    case '5':
                        m_objMontre = new Montre(23, 59, 59);
                        Console.WriteLine(m_objMontre.ObtenirTempsCourant());
                        break;
                    case 'Q':
                        Console.WriteLine("Au revoir !");
                        quitter = true;
                        break;
                    default:
                        Console.WriteLine("Option non valide, essayez de nouveau  !");
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