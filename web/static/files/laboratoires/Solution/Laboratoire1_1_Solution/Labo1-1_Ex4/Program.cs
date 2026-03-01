using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Labo1_1_Ex4
{
    internal class Program
    {

        static void Main()
        {
            // ================================
            // Constantes
            // ================================
             // Chemin complet au fichier CSV d'entrée
            const string fichierEntree = "../../personnages.csv";

            // ================================
            // variables
            // ================================
            // Liste de personnages
            List<Personnage> personnages = new List<Personnage>();
            
            // Tableau contenant tous les niveaux de personnages, utilisé pour filtrer la liste de personnages
            string[] niveaux =
           {
                Personnage.NIVEAU_DEBUTANT,
                Personnage.NIVEAU_APPRENTI,
                Personnage.NIVEAU_GUERRIER,
                Personnage.NIVEAU_HERO
            };


            // ================================
            // Vérification du fichier CSV
            // ================================
            if (!File.Exists(fichierEntree))
            {
                Console.WriteLine($"Fichier introuvable : {fichierEntree}");
                Console.WriteLine("Créez un fichier personnages.csv.");
                return;
            }

            // ================================
            // Chargement des personnages
            // ================================
            personnages = ChargerPersonnages(fichierEntree);
            Console.WriteLine($"Personnages chargés : {personnages.Count}");



            // ================================
            // Filtrage et sauvegarde par niveau
            // ================================
            foreach (string niveau in niveaux)
            {
                // Filtrage des personnages
                List<Personnage> filtres = FiltrerParNiveau(personnages, niveau);

                
                // Définition du fichier de sortie
                string nomFichierSortie = "../../" + niveau + ".csv";
                // Sauvegarde des personnages filtrés
                Enregistrer(filtres, nomFichierSortie);

                Console.WriteLine($"{niveau,-9} -> {filtres.Count} personnages(es) sauvegardé(s) dans {nomFichierSortie}");
            }

            Console.WriteLine("Terminé.");
        }



        // ================================
        // Méthodes demandées
        // ================================
        #region Méthode demandées
        /// <summary>
        /// Charge la liste de personnages à partir d'un fichier CSV
        /// Format du fichier CSV : Nom;Points;Niveau
        /// </summary>
        /// <param name="nomFichierCsv">Eemplacement du fichier CSV</param>
        /// <returns>liste de personnages</returns>
        static List<Personnage> ChargerPersonnages(string nomFichierCsv)
        {
            List<Personnage> liste = new List<Personnage>();


            using (StreamReader reader = new StreamReader(nomFichierCsv))
            {

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine().Trim();

                    string[] tabLigne = line.Split(';');

                    string nom = tabLigne[0].Trim();
                    int points = int.Parse(tabLigne[1].Trim());
                    string niveau = tabLigne[2].Trim();


                    liste.Add(new Personnage(nom, points, niveau));
                }
            }


            return liste;
        }


        /// <summary>
        /// Filtre une liste de personnages selon un niveau donné
        /// </summary>
        /// <param name="liste">Lisyte de personnages</param>
        /// <param name="niveau">niveau</param>
        /// <returns>Liste de personnages ayant le niveau spécifié</returns>
        static List<Personnage> FiltrerParNiveau(List<Personnage> liste, string niveau)
        {
            List<Personnage> resultat = new List<Personnage>();

            for (int i = 0; i < liste.Count; i++)
            {
                if (liste[i].Niveau == niveau)
                    resultat.Add(liste[i]);
            }

            return resultat;
        }

    
        /// <summary>
        /// Sauvegarde une liste de personnages dans un fichier CSV
        /// </summary>
        /// <param name="liste">La liste de personnages à sauvegarder</param>
        /// <param name="nomFichierCsv">Le chemin complet du fichier CSV de destination</param>
        static void Enregistrer(List<Personnage> liste, string nomFichierCsv)
        {
            using (StreamWriter writer = new StreamWriter(nomFichierCsv))
            {

                for (int i = 0; i < liste.Count; i++)
                {
                    Personnage p = liste[i];
                    writer.WriteLine($"{p.Nom};{p.Points};{p.Niveau}");
                }
            }
        }
        #endregion
    }
}
