using System;

namespace AppThermostat
{
    /// <summary>
    /// Ce programme instancie un objet de la classe Thermostat, il permet d'augmenter ou de diminuer la température
    /// d'un degrés à la fois. La température autorisée est entre 5 et 35 degrés Celsuis.
    /// </summary>
    internal class Program
    {
        // Variable globale
        static Thermostat m_objThermostat = new Thermostat();
        static void Main(string[] args)
        {
            

            bool quitter = false;

            while (!quitter)
            {
                Console.Clear();
                Console.WriteLine("Température : " + m_objThermostat.Temperature);

                Console.WriteLine("=== Menu Principal ===");
                Console.WriteLine("1 - Augmenter la température");
                Console.WriteLine("2 - Diminuer la température");
                Console.WriteLine("3 - Température Maximale autorisée");
                Console.WriteLine("4 - Température Minimale autorisée");
                Console.WriteLine("Q - Quitter");
                Console.WriteLine("=======================");
                Console.Write("Veuillez sélectionner une option : ");

                char choix = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine(); 
                Console.Clear();
                switch (choix)
                {
                    case '1':
                        if (m_objThermostat.Temperature < Thermostat.MAX_TEMPERATURE)
                            m_objThermostat.augmenterTemperature();
                        else
                            Console.WriteLine("La température maximale a été atteinte !");
                        Console.WriteLine("Température : " + m_objThermostat.Temperature);
                        break;
                    case '2':
                        if (m_objThermostat.Temperature > Thermostat.MIN_TEMPERATURE)
                            m_objThermostat.diminuerTemperature();
                        else
                            Console.WriteLine("La température minimale a été atteinte !");
                        Console.WriteLine("Température : " + m_objThermostat.Temperature);
                        break;
                    case '3':
                        Console.WriteLine("Température maximale autorisée : " + Thermostat.MAX_TEMPERATURE);
                        break;
                    case '4':
                        Console.WriteLine("Température minimale autorisée : " + Thermostat.MIN_TEMPERATURE);
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