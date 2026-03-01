using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1_1_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Définir une liste vide de nombres décimaux
            List<double> notes = new List<double>();

            Console.WriteLine("=== Statistiques de notes (10 étudiants) ===");

            // Saisie des 10 notes
            for (int i = 1; i <= 10; i++)
            {
                double note = 0;
                bool noteInvalide = true;
                while (noteInvalide)
                {
                    Console.Write($"Entrez la note #{i} (sur 100) : ");
                    string saisie = Console.ReadLine();

                    if (!double.TryParse(saisie, out note) || note > 100 || note < 0)
                    {

                        Console.WriteLine("❌ Note invalide. Entrez un nombre entre 0 et 100.");
                    }
                    else
                    {
                        noteInvalide = false;

                    }

                }

                notes.Add(note);
            }

            // Appel des méthodes pour le calcul des statistiques
            double moyenne = CalculerMoyenne(notes);
            double noteMax = TrouverNoteMax(notes);
            double noteMin = TrouverNoteMin(notes);
            int nbAuDessusOuEgal = CompterAuDessusDeLaMoyenne(notes, moyenne);

            // Affichage des statistiques
            Console.WriteLine("\n--- Résultats ---");
            Console.WriteLine("Notes : " + string.Join(" ", notes));
            Console.WriteLine($"Moyenne : {moyenne.ToString("F2")}");
            Console.WriteLine($"Note maximale : {noteMax.ToString("F2")}");
            Console.WriteLine($"Note minimale : {noteMin.ToString("F2")}");
            Console.WriteLine($"Nombre d’étudiants avec une note supérieure ou égale à la moyenne : {nbAuDessusOuEgal}");
        }

        // ================================
        // Méthodes demandées
        // ================================
        #region Méthodes demandées
        /// <summary>
        /// Calcule et renvoie la moyenne des valeurs d’une liste de notes.
        /// </summary>
        /// <param name="notes">liste de notes</param>
        /// <returns>moyenne des notes</returns>
        static double CalculerMoyenne(List<double> notes)
        {
            double somme = 0;

            for (int i = 0; i < notes.Count; i++)
            {
                somme += notes[i];
            }

            return somme / notes.Count;
        }
        /// <summary>
        /// Recherche et renvoie la valeur maximale d’une liste de notes
        /// </summary>
        /// <param name="notes">liste de notes</param>
        /// <returns>note maximale</returns>
        static double TrouverNoteMax(List<double> notes)
        {
            double max = notes[0];

            for (int i = 1; i < notes.Count; i++)
            {
                if (notes[i] > max)
                {
                    max = notes[i];
                }
            }

            return max;
        }
        /// <summary>
        /// Recherche et renvoie la valeur minimale d’une liste de notes
        /// </summary>
        /// <param name="notes">liste de notes</param>
        /// <returns>note minimale</returns>
        static double TrouverNoteMin(List<double> notes)
        {
            double min = notes[0];

            for (int i = 1; i < notes.Count; i++)
            {
                if (notes[i] < min)
                {
                    min = notes[i];
                }
            }

            return min;
        }
        /// <summary>
        /// Compte et renvoie le nombre de notes au-dessus de la moyenne
        /// </summary>
        /// <param name="notes">liste de notes</param>
        /// <param name="moyenne"></param>
        /// <returns>nombre de notes au-dessus de la moyenne</returns>
        static int CompterAuDessusDeLaMoyenne(List<double> notes, double moyenne)
        {
            int compteur = 0;

            for (int i = 0; i < notes.Count; i++)
            {
                if (notes[i] >= moyenne)
                {
                    compteur++;
                }
            }

            return compteur;
        }
        #endregion
    }

}

