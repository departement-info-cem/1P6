using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Task2Do
{
    public partial class FrmTasks : Form
    {
        // Chemin du fichier contenant la liste des tâches à faire.
        private readonly string cheminFichierTachesAFaire = "../../Fichiers/tachesAFAire.txt";

        // Chemin du fichier contenant la liste des tâches réalisées.
        private readonly string cheminFichierTachesRealisees = "../../Fichiers/tachesRealisees.txt";

        // Chemin du fichier contenant la liste des tâches disponibles.
        private readonly string cheminFichierTachesDisponibles = "../../Fichiers/tachesDisponibles.txt";

       
        public FrmTasks()
        {
            InitializeComponent();

            // Chargement des tâches
            
           
            

        }

        
    }
}

