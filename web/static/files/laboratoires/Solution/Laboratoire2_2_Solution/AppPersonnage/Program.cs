using System;


namespace AppPersonnage
{
    internal class Program
    {
        // Variable globale
        static Personnage perso;
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

                switch (choix)
                {
                    case "1":
                        Console.Write("Nom du personnage : ");
                        string nom = Console.ReadLine();

                        Console.Write("Âge du personnage : ");
                        if (!int.TryParse(Console.ReadLine(), out int age))
                        {
                            Console.WriteLine("Âge invalide, valeur par défaut utilisée.");
                            age = Personnage.AGE_PAR_DEFAUT;
                        }

                        Console.Write("Classe (G - Guerrier, M - Mage, V - Voleur) : ");
                        char classe = 'G';
                        string inputClasse = Console.ReadLine();
                        if (!string.IsNullOrEmpty(inputClasse))
                        {
                            classe = char.ToUpper(inputClasse[0]);
                        }

                        perso = new Personnage(nom, age, classe);
                        Console.WriteLine($"Personnage {perso.Nom} créé !");
                        break;

                    case "2":
                        if (perso != null)
                        {
                            Console.WriteLine(perso.Fiche());
                        }
                        else
                        {
                            Console.WriteLine("Créez d'abord un personnage !");
                        }
                        break;

                    case "3":
                        if (perso != null)
                        {
                            Console.Write("Nombre de dégâts reçus : ");
                            if (int.TryParse(Console.ReadLine(), out int degats))
                            {
                                perso.recevoirDegats(degats);
                                Console.WriteLine($"{perso.Nom} a maintenant {perso.PointsDeVie} PV.");
                            }
                            else
                            {
                                Console.WriteLine("Valeur invalide !");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Créez d'abord un personnage !");
                        }
                        break;

                    case "4":
                        if (perso != null)
                        {
                            Console.Write("Nombre de points de soin : ");
                            if (int.TryParse(Console.ReadLine(), out int soin))
                            {
                                perso.soigner(soin);
                                Console.WriteLine($"{perso.Nom} a maintenant {perso.PointsDeVie} PV.");
                            }
                            else
                            {
                                Console.WriteLine("Valeur invalide !");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Créez d'abord un personnage !");
                        }
                        break;

                    case "5":
                        if (perso != null)
                        {
                            int puissance = perso.PuissanceAttaque();
                            Console.WriteLine($"Puissance d'attaque de {perso.Nom} : {puissance}");
                        }
                        else
                        {
                            Console.WriteLine("Créez d'abord un personnage !");
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
                if (!quitter)
                {
                    Console.WriteLine("Appuyez sur une touche pour continuer...");
                    Console.ReadKey(true);
                    Console.Clear();

                }
                
            }
        }
    }
}
