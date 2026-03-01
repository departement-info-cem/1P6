using System;
using AppRobot;

namespace AppRobot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot monRobot = null;

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

                switch (choix)
                {
                    case "1":
                        Console.Write("Entrez le nom du robot : ");
                        string nom = Console.ReadLine();
                        monRobot = new Robot(nom);
                        Console.WriteLine($"Robot {monRobot.Nom} créé !");
                        break;

                    case "2":
                        if (monRobot != null)
                        {
                            monRobot.demarrer();
                            Console.WriteLine("Moteur démarré !");
                        }
                        else
                        {
                            Console.WriteLine("Créez d'abord un robot !");
                        }
                        break;

                    case "3":
                        if (monRobot != null)
                        {
                            monRobot.arreter();
                            Console.WriteLine("Moteur arrêté !");
                        }
                        else
                        {
                            Console.WriteLine("Créez d'abord un robot !");
                        }
                        break;

                    case "4":
                        if (monRobot != null)
                        {
                            if (monRobot.EstAllume)
                            {
                                Console.Write("Vitesse à ajouter (km/h) : ");
                                if (int.TryParse(Console.ReadLine(), out int vitesse))
                                {
                                    monRobot.accelerer(vitesse);
                                    Console.WriteLine($"Vitesse actuelle : {monRobot.VitesseActuelle} km/h");
                                }
                                else
                                {
                                    Console.WriteLine("Entrée invalide !");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Le moteur est éteint. Démarrez le moteur d'abord !");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Créez d'abord un robot !");
                        }
                        break;

                    case "5":
                        if (monRobot != null)
                        {
                            if (monRobot.EstAllume)
                            {
                                Console.Write("Vitesse à réduire (km/h) : ");
                                if (int.TryParse(Console.ReadLine(), out int vitesse))
                                {
                                    monRobot.ralentir(vitesse);
                                    Console.WriteLine($"Vitesse actuelle : {monRobot.VitesseActuelle} km/h");
                                }
                                else
                                {
                                    Console.WriteLine("Entrée invalide !");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Le moteur est éteint. Impossible de ralentir !");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Créez d'abord un robot !");
                        }
                        break;

                    case "6":
                        if (monRobot != null)
                        {
                            Console.WriteLine(monRobot.Infos());
                        }
                        else
                        {
                            Console.WriteLine("Créez d'abord un robot !");
                        }
                        break;

                    case "Q":
                    case "q":
                        quitter = true;
                        Console.WriteLine("Au revoir !");
                        break;

                    default:
                        Console.WriteLine("Choix invalide !");
                        break;
                }
                Console.WriteLine("Appuyez sur une touche pour continuer...");
                Console.ReadKey(true);
                Console.Clear();
            }
        }
    }
}
