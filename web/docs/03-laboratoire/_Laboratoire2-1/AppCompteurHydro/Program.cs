using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCompteurHydro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool quitter = false;

            while (!quitter)
            {
                Console.Clear();

                Console.WriteLine("=== Menu Principal ===");
                Console.WriteLine("1 - Consommer une quantité de Kw/h");
                Console.WriteLine("2 - Afficher la consommation actuelle");
                Console.WriteLine("3 - Afficher le coût de la consommation");
                Console.WriteLine("Q - Quitter");
                Console.WriteLine("=======================");
                Console.Write("Veuillez sélectionner une option : ");
            }
        }
    }
}
