using System;
using System.Runtime.CompilerServices;

namespace AppMultiThermostat
{
    /// <summary>
    /// Ce programme instancie 3 objets de la classe Thermostat, car il permet de contrôler la température dans 3 emplacements différents,
    /// soit : la chambre, la cuisine ou encore le salon. Une quatrième variable va servir uniquement à référer sur le Thermostat courant.
    /// Au départ le Thermostat courant est celui de la chambre, ensuite l'utilisateur peut au besoin le changer pour celui de la cuisine ou du salon.
    /// Les options pour augmenter ou diminuer la température affecte uniquement le Thermostat courant. 
    /// </summary>
    internal class Program
    {
        // Variables globales
        static Thermostat m_objThermostatChambre = new Thermostat();
        static Thermostat m_objThermostatCuisine = new Thermostat();
        static Thermostat m_objThermostatSalon = new Thermostat();
        static Thermostat m_objThermostatCourant;
        static void Main(string[] args)
        {
            

            Thermostat m_objThermostatCourant = m_objThermostatChambre;

            bool quitter = false;

            while (!quitter)
            {
                Console.Clear();
                Console.WriteLine("Température : " + m_objThermostatCourant.Temperature);

                Console.WriteLine("=== Menu Principal ===");
                Console.WriteLine("1 - Augmenter la température du Thermostat courant");
                Console.WriteLine("2 - Diminuer la température du Thermostat courant");
                Console.WriteLine("3 - Température Maximale autorisée");
                Console.WriteLine("4 - Température Minimale autorisée");
                Console.WriteLine("5 - Fixe le Thermostat courant à celui de la chambre");
                Console.WriteLine("6 - Fixe le Thermostat courant à celui de la cuisine");
                Console.WriteLine("7 - Fixe le Thermostat courant à celui du salon");

                Console.WriteLine("Q - Quitter");
                Console.WriteLine("=======================");
                Console.Write("Veuillez sélectionner une option : ");

                char choix = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine(); // Aller à la ligne après l'entrée
                Console.Clear();
                switch (choix)
                {
                    case '1':
                        if (m_objThermostatCourant.Temperature < Thermostat.MAX_TEMPERATURE)
                            m_objThermostatCourant.augmenterTemperature();
                        else
                            Console.WriteLine("La température maximale a été atteinte !");
                        Console.WriteLine("Température : " + m_objThermostatCourant.Temperature);
                        break;
                    case '2':
                        if (m_objThermostatCourant.Temperature > Thermostat.MIN_TEMPERATURE)
                            m_objThermostatCourant.diminuerTemperature();
                        else
                            Console.WriteLine("La température minimale a été atteinte !");
                        Console.WriteLine("Température : " + m_objThermostatCourant.Temperature);
                        break;
                    case '3':
                        Console.WriteLine("Température maximale autorisée : " + Thermostat.MAX_TEMPERATURE);
                        break;
                    case '4':
                        Console.WriteLine("Température minimale autorisée : " + Thermostat.MIN_TEMPERATURE);
                        break;
                    case '5':
                        m_objThermostatCourant = m_objThermostatChambre;
                        Console.WriteLine("Température : " + m_objThermostatCourant.Temperature);
                        break;
                    case '6':
                        m_objThermostatCourant = m_objThermostatCuisine;
                        Console.WriteLine("Température : " + m_objThermostatCourant.Temperature);
                        break;
                    case '7':
                        m_objThermostatCourant = m_objThermostatSalon;
                        Console.WriteLine("Température : " + m_objThermostatCourant.Temperature);
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