using System.ComponentModel;
using System.Net.NetworkInformation;
using static System.Net.Mime.MediaTypeNames;

namespace adaptation_tp1_console
{
    public class Program
    {

        #region TODO 00 : Prendre connaissance des constantes et variables fournies, ainsi que de la classe Morceau

        //------------ Constantes et variables --------------------------------
        const string BIBLIOTHEQUE = "../../../Bibliotheque.csv";

        // DÉCOMMENTER LA LIGNE SUIVANTE LORSQUE VOUS SEREZ À LA PARTIE 2
        //static Utilisateur utilisateurCourant = null;

        //---------------------------------------------------------------------
        #endregion


        static void Main(string[] args)
        {
            List<Morceau> repertoireRadioEtudiante = new List<Morceau>(); // Partie 1
            List<Morceau> listeLectureUtilisateur = new List<Morceau>(); // Partie 2


            #region TODO 11 : Chargements des listes à partir des fichiers CSV (5%)
            // TODO 11 : Appeler la méthode ChargerMorceaux() pour charger le répertoire musical de la radio étudiante, ainsi
            // que la liste de lecture de l'utilisateur SI APPROPRIÉ
           
            #endregion

            #region TODO 12 : Lier l'ensemble des fonctions (18%)
            /// TODO 12 :
            /// Effectuer la logique du menu utilisateur dans une boucle qui prend fin seulement lorsque l'utilisateur décide de quitter.
            /// Astuces : la boucle while et le switch-case vous seront utiles ;)
            
            #endregion

        }

        #region Partie 1 (~65%)

        #region TODO 01 : Charger le répertoire musical de la radio étudiante (7%)
        /// Nom de la méthode : ChargerMorceaux()
        /// <summary>
        /// Lit les informations dans le fichier CSV et les charge en mémoire dans une liste.
        /// </summary>
        /// <param name="pNomDuFichier"> nom du fichier à lire</param>
        /// <param name="pListeMorceaux"> liste de morceaux à remplir </param>
        /// <returns>  liste de morceaux. Remplie si le fichier existe, vide s'il n'existe pas  </returns>
        /// ----------------------------------------------------------------------------------------------------
        internal static List<Morceau> ChargerMorceaux(string pNomDuFichier, List<Morceau> pListeMorceaux)
        {
            // À COMPLÉTER...

            return pListeMorceaux;
        }
        #endregion

        #region TODO 02 : Afficher le répertoire musical (4%)
        /// Nom de la méthode : AfficherListeDeMorceaux()
        /// <summary>
        /// Affiche la version lisible des morceaux d'une liste dans la console.
        /// </summary>
        /// <param name="pListeMorceaux"> liste de morceaux </param>
        /// ----------------------------------------------------------------------------------------
        
        #endregion

        #region TODO 03 : Ajouter un morceau au répertoire (3%)
        /// Nom de la méthode : OpérationAjouter()
        /// <summary>
        /// Permet d'ajouter un nouvel objet Morceau à une liste de morceaux
        /// </summary>
        /// <param name="pListeMorceaux"> liste de morceaux </param>
        /// <param name="pArtiste"> nom de l'artiste </param>
        /// <param name="pAlbum"> titre de l'album </param>
        /// <param name="pTitre"> titre du morceau </param>
        /// <param name="pCote"> cote d'appréciation (1 à 5) </param>
        /// <param name="pDurée"> durée du morceau en secondes </param>
        /// <returns>  liste de morceaux contenant une chanson additionnelle  </returns>
        /// ----------------------------------------------------------------------------------------
        
        #endregion

        #region TODO 04 : Supprimer un morceau du répertoire (2%)
        /// Nom de la méthode : OpérationSupprimer()
        /// <summary>
        /// Permet de supprimer un objet Morceau d'une liste de morceaux
        /// </summary>
        /// <param name="pListeMorceaux"> liste de morceaux </param>
        /// <param name="pIndexMorceau"> index du morceau à supprimer dans la liste </param>
        /// <returns>  liste de morceaux contenant une chanson en moins  </returns>
        /// ----------------------------------------------------------------------------------------
        
        #endregion

        #region TODO 05 : Modifier la cote d'appréciation d'un morceau (2%)
        /// Nom de la méthode : OpérationModiferCote()
        /// <summary>
        /// Permet de modifier la cote d'un morceau d'une liste.
        /// </summary>
        /// <param name="pListeMorceaux"> liste de morceaux </param>
        /// <param name="pIndexMorceau"> index du morceau à supprimer dans la liste </param>
        /// <param name="pCote"> valeur de la nouvelle cote </param>
        /// <returns>  liste de morceaux modifiée  </returns>
        /// ----------------------------------------------------------------------------------------

        #endregion

        #region TODO 06 : Trier les morceaux du répertoire selon leur cote d'appréciation (10%)
        /// Nom de la méthode : OpérationTrier()
        /// <summary>
        /// Permet de trier en ordre DÉCROISSANT les morceaux d'une liste selon leur cote d'appréciation.
        /// </summary>
        /// <param name="pListeMorceaux"> liste de morceaux </param>
        /// <returns>  liste de morceaux triée  </returns>
        /// ----------------------------------------------------------------------------------------
        #endregion

        #region TODO 07 : Afficher les informations d'un morceau (3%)
        /// Nom de la méthode : AfficherMorceauCourant()
        /// <summary>
        /// Permet d'afficher l'ensemble des informations d'un morceau (i.e. titre du morceau,
        /// nom de l'artiste, titre de l'album, cote d'appréciation, durée)
        /// </summary>
        /// <param name="pListeMorceaux"> liste de morceaux </param>
        /// <param name="pIndexMorceau"> index du morceau sélectionné </param>
        /// ----------------------------------------------------------------------------------------
       
        #endregion

        #region TODO 08 : Afficher les statistiques du répertoire (5%)
        /// Nom de la méthode : AfficherStats()
        /// <summary>
        /// Permet d'afficher les statistiques (# de chansons, durée totale en hh:mm:ss) d'une liste de morceaux
        /// </summary>
        /// <param name="pListeMorceaux"> liste de morceaux </param>
        /// ----------------------------------------------------------------------------------------
       
        #endregion

        #region TODO 09 : Enregistrer les modifications au moment de quitter (5%)
        /// Nom de la méthode : OpérationQuitter()
        /// <summary>
        /// Au moment de quitter le programme, on sauvegarde la liste dans le fichier approprié.
        /// On sépare chaque information d'un morceau avec le séparateur "|".
        /// La durée d'un morceau doit être affichée dans le format mm:ss.
        /// Voici un exemple 
        ///  artiste|album|titre|cote|minutes:secondes
        ///  Susan Boyle|I Dreamed A Dream|Wild Horses|1|04:53
        /// </summary>
        /// <param name="pNomDuFichier"> nom du fichier dans lequel sauvegarder les informations </param>
        /// <param name="pListeMorceaux"> liste de morceaux à sauvegarder </param>
        /// -----------------------------------------------------------------------------------------------

        #endregion

        #region TODO 10 : Afficher le menu utilisateur dans la console (4%)
        /// Nom de la méthode : AfficherMenu()
        /// <summary>
        /// Permet d'afficher les options du menu dans la console
        /// </summary>
        /// -----------------------------------------------------------------------------------------------
       

        #endregion



        #endregion Partie 1

        #region Partie 2 (~35%)

        // TODO 13 : créer une classe Utilisateur à l'aide du diagramme de classe fournit (23%)

        #region TODO 14 : Page de connexion (7%)
        /// Nom de la méthode : PageDémarrage()
        /// <summary>
        /// Permet d'afficher les options de connexions au démarrage : "se créer un compte" et "continuer en tant qu'invité"
        /// </summary>
        /// -----------------------------------------------------------------------------------------------
       
        #endregion

        #region TODO 15 : Afficher le profil d'un utilisateur connecté (2%)
        /// Nom de la méthode : AfficherProfil()
        /// <summary>
        /// Permet d'afficher les informations d'un utilisateur : son nom d'utilisateur, son mot de passe caché par des *, son statut 
        /// </summary>
        /// -----------------------------------------------------------------------------------------------
       
        #endregion



        #endregion Partie 2

    }
}
