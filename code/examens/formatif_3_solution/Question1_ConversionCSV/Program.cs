/*
 * QUESTION 1 - Conversion de prix USD vers CAD
 * 
 * DESCRIPTION:
 * Le fichier pokemons.csv contient une liste de cartes Pokemon de notre collection personnelle,
 * mais malheureusement les prix sont en dollars US.
 * 
 * OBJECTIF:
 * Lire le fichier pokemons.csv, pour chaque enregistrement, faire la conversion en dollars canadien 
 * (le taux de change actuel est de 1,38, donc montant_cad = montant_usd * 1.38), puis enregistrer 
 * les informations du fichier avec le montant en dollars canadiens dans un nouveau fichier nommé pokemon_cad.csv
 * 
 * INSTRUCTIONS:
 * - Utiliser StreamReader pour lire le fichier
 * - Utiliser StreamWriter pour écrire le fichier
 * - Le fichier CSV utilise le point-virgule (;) comme séparateur
 * - Formater le prix avec 2 décimales
 * 
 * EXEMPLE DE RÉSULTAT ATTENDU:
 * Si le fichier pokemons.csv contient:
 *   Nom;Rareté;Image;Prix
 *   Dracaufeu;Rare Holo;https://images.pokemontcg.io/base1/4.png;463,35
 * 
 * Le fichier pokemon_cad.csv devrait contenir:
 *   Nom;Rareté;Image;Prix
 *   Dracaufeu;Rare Holo;https://images.pokemontcg.io/base1/4.png;639,42
 */

namespace Question1_ConversionCSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: Implémenter la conversion USD -> CAD
            // Taux de change: 1.38
            const double TAUX_CHANGE = 1.38;
            string fichierEntree = "../../../pokemons.csv";
            string fichierSortie = "../../../pokemon_cad.csv";

            
            StreamReader reader = new StreamReader(fichierEntree);
            StreamWriter writer = new StreamWriter(fichierSortie);

            // Lire et écrire la première ligne (en-tête)
            string entete = reader.ReadLine();
            if (entete != null)
            {
                writer.WriteLine(entete);
            }

            // Lire chaque ligne du fichier
            
            while (!reader.EndOfStream)
            {
                string ligne = reader.ReadLine();
                // Séparer les colonnes par le point-virgule
                string[] colonnes = ligne.Split(';');

                // Récupérer les données
                string nom = colonnes[0];
                string rarete = colonnes[1];
                string image = colonnes[2];
                string prixUSD = colonnes[3];

                // Convertir le prix USD en CAD
                double prixUSDDouble = double.Parse(prixUSD);
                double prixCAD = prixUSDDouble * TAUX_CHANGE;

                // Formater le prix avec 2 décimales
                string prixCADFormate = prixCAD.ToString("F2");
                // ou encore
                prixCADFormate = prixCAD.ToString("0.00");

                // Écrire la ligne dans le nouveau fichier
                writer.WriteLine($"{nom};{rarete};{image};{prixCADFormate}");

            }
            reader.Close();
            writer.Close();
        }
    }
}
