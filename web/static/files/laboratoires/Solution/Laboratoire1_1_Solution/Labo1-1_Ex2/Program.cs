using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1_1_Ex2
{
    internal class Program
    {
        static void Main()
        {
            // Définir et initialiser une liste d'entiers
            List<int> nombres = new List<int> { 12, 5, 8, 21, 15, 4, 18, 7, 13, 9, 2, 6 };
            // Appel de la méthode GarderPairs
            GarderPairs(nombres);
        }

        // ================================
        // Méthode demandée
        // ================================
        #region Méthode demandée
        /// <summary>
        /// Filtre une liste de nombres entiers afin de ne conserver que les nombres pairs
        /// </summary>
        /// <param name="liste">liste de nombres enteirs</param>
        static void GarderPairs(List<int> liste)
        {
            // Affichage avant
            Console.WriteLine("Avant : " + string.Join(" ", liste));

            // Suppression des impairs (parcours à l'envers)
            for (int i = liste.Count - 1; i >= 0; i--)
            {
                if (liste[i] % 2 != 0)
                {
                    liste.RemoveAt(i);
                }
            }

            // Affichage après
            Console.WriteLine("Après : " + string.Join(" ", liste));
        }
        #endregion
    }
}
