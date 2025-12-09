/*
 * QUESTION 3 - Cartes Pokemon en vedette
 * 
 * DESCRIPTION:
 * Toujours à partir de la même collection de cartes Pokemon, récupérer la carte avec la plus 
 * grande valeur et la placer dans objet nommé carteEnVedette.
 * 
 * OBJECTIF:
 * Afficher la carte en vedette dans la console, puis par la suite, afficher toutes les autres cartes.
 * La carte en vedette ne doivent pas être affichée 2 fois.
 * 
 * INSTRUCTIONS:
 * - Trouver la carte avec le prix le plus élevé
 * - La placer dans carteEnVedette
 * - Afficher d'abord la carte en vedette
 * - Afficher ensuite toutes les autres cartes (sans répéter la carte en vedette)
 * 
 * EXEMPLE DE RÉSULTAT ATTENDU:
 * === CARTES EN VEDETTE ===
 * Noctali VMAX - 2006,42$
 * 
 * === AUTRES CARTES ===
 * Dracaufeu - 463,35$
 * Keunotor - 0,11$
 * Lugia - 272,53$
 * Mewtwo & Mew-GX - 89,72$
 * ... (toutes les autres cartes)
 */

using Question2_AchatPokemon;

namespace Question3_CartesVedette
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Créer le tableau avec toutes les cartes Pokemon
            CartePokemon[] toutesLesCartes = new CartePokemon[]
            {
                new CartePokemon("Dracaufeu", "Rare Holo", "https://images.pokemontcg.io/base1/4.png", 463.35),
                new CartePokemon("Noctali VMAX", "Rare Holo VMAX", "https://images.pokemontcg.io/swsh7/215.png", 2006.42),
                new CartePokemon("Keunotor", "Common", "https://images.pokemontcg.io/swsh12pt5/111.png", 0.11),
                new CartePokemon("Lugia", "Rare Holo", "https://images.pokemontcg.io/neo1/9.png", 272.53),
                new CartePokemon("Mewtwo & Mew-GX", "Rare Holo GX", "https://images.pokemontcg.io/sm11/71.png", 89.72),
                new CartePokemon("Pikachu", "Common", "https://images.pokemontcg.io/g1/RC29.png", 82.94),
                new CartePokemon("Carchacrok C", "Rare Holo LV.X", "https://images.pokemontcg.io/pl3/60.png", 6.72),
                new CartePokemon("Miamiasme", "Common", "https://images.pokemontcg.io/swsh2/117.png", 0.13),
                new CartePokemon("Arceus VSTAR", "Rare Holo VSTAR", "https://images.pokemontcg.io/swsh9/123.png", 4.99),
                new CartePokemon("Ectoplasma", "Rare Holo", "https://images.pokemontcg.io/base3/5.png", 196.40),
                new CartePokemon("Rayquaza", "Rare Holo EX", "https://images.pokemontcg.io/xy6/75.png", 25.06),
                new CartePokemon("Papilusion", "Rare Holo", "https://images.pokemontcg.io/ex6/2.png", 27.24),
                new CartePokemon("Ratentif", "Common", "https://images.pokemontcg.io/bw1/77.png", 0.20)
            };

            

        }
    }
}
