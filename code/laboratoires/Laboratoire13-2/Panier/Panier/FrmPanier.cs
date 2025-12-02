using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;


namespace Panier
{

    public partial class FrmPanier : Form
    {

        const decimal TAUX_TAXE = 0.15m; // TAUX des taxes applicables
        const int INDEX_COL_DESCRIPTION = 0; // index de la colonne pour la description des items
        const int INDEX_COL_PRIX = 1; // index de la colonne pour le prix des items

        // Chemin du fichier contenant la liste des items.
        private readonly string cheminFichierItems = "../../Fichiers/Items.txt";

        // Chemin du fichier contenant les items du panier.
        private readonly string cheminFichierPanier = "../../Fichiers/Panier.txt";

        // ---------------------------------------------------------------------------------------------
        public FrmPanier()
        {
            InitializeComponent();
            // Charger les items disponibles
           


        }
        
    }
}




