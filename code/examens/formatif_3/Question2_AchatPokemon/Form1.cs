/*
 * QUESTION 2 - Interface d'achat de cartes Pokemon
 * 
 * DESCRIPTION:
 * À partir des mêmes données qu'à la première question, mais cette fois c'est un tableau 3D directement 
 * dans le code, compléter l'interface pour qu'on puisse acheter une carte Pokemon.
 * 
 * OBJECTIF:
 * Lors du clic acheter, confirmer l'achat avec un MessageBox qui vous donnera les informations 
 * de la commande: "{Nom_du_client} a acheté la carte {nom_de_la_carte} - {prix}$ ({rarete})"
 * 
 * INSTRUCTIONS:
 * - Récupérer le nom du client dans le champ texte
 * - Afficher les cartes dans le ListBox
 * - Lors du changement d'item sélectionné dans le ListBox (listBoxCartes_SelectedIndexChanged), 
 * afficher l'image de la carte dans le PictureBox pbCarte
 * - Le bouton "Acheter" affiche un MessageBox avec les informations de la commande
 * 
 * EXEMPLE DE RÉSULTAT ATTENDU:
 * Si l'utilisateur saisit "Jean Tremblay" comme nom et sélectionne "Dracaufeu" à 463,35$,
 * le MessageBox devrait afficher:
 *   "Jean Tremblay a acheté la carte Dracaufeu - 463,35$ (Rare Holo)"
 */

namespace Question2_AchatPokemon
{
    public partial class Form1 : Form
    {
        // Array des cartes Pokemon
        string [,] cartes = {
                {"Dracaufeu", "Rare Holo", "https://images.pokemontcg.io/base1/4.png", "463,35"},
                {"Noctali VMAX", "Rare Holo VMAX", "https://images.pokemontcg.io/swsh7/215.png", "2006,42"},
                {"Keunotor", "Common", "https://images.pokemontcg.io/swsh12pt5/111.png", "0.11"},
                {"Lugia", "Rare Holo", "https://images.pokemontcg.io/neo1/9.png", "272.53"},
                {"Mewtwo & Mew-GX", "Rare Holo GX", "https://images.pokemontcg.io/sm11/71.png", "89.72"},
                {"Pikachu", "Common", "https://images.pokemontcg.io/g1/RC29.png", "82.94"},
                {"Carchacrok C", "Rare Holo LV.X", "https://images.pokemontcg.io/pl3/60.png", "6.72"},
                {"Miamiasme", "Common", "https://images.pokemontcg.io/swsh2/117.png", "0.13"},
                {"Arceus VSTAR", "Rare Holo VSTAR", "https://images.pokemontcg.io/swsh9/123.png", "4.99"},
                {"Ectoplasma", "Rare Holo", "https://images.pokemontcg.io/base3/5.png", "196.40"},
                {"Rayquaza", "Rare Holo EX", "https://images.pokemontcg.io/xy6/75.png", "25.06"},
                {"Papilusion", "Rare Holo", "https://images.pokemontcg.io/ex6/2.png", "27.24"},
                {"Ratentif", "Common", "https://images.pokemontcg.io/bw1/77.png", "0.20"}
            };

        public Form1()
        {
            InitializeComponent();
            InitialiserInterface();
        }


        private void InitialiserInterface()
        {
            // Remplir le ListBox avec les cartes
            
        }

        private void listBoxCartes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            // Charger l'image de la carte
            // pictureBoxCarte.Load avec comme paramètre l'adresse de l'image

        }

        private void btnAcheter_Click(object sender, EventArgs e)
        {
            // Récupérer les informations

            // Afficher le message de confirmation

        }
    }
}
