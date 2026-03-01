using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adaptation_tp1_console
{
    // Version H26.1.0
    /// -----------------------------------------------------------------------------------------------------
    /// <summary>
    ///	 Modélise un morceau de musique. Les champs sont : artiste, album, titre, cote d'appréciation et durée.
    /// </summary>
    /// -----------------------------------------------------------------------------------------------------
    internal class Morceau
    {

        #region CHAMPS - Variables MEMBRE (5) et PROPRIÉTÉS

        /// =====================================================================
        private readonly string m_artiste;
        /// --------------------------
        /// <summary>
        /// Obtient l'artiste.
        /// </summary>
        /// --------------------------
        public string Artiste
        {
            get { return m_artiste; }
        }

        /// =====================================================================
        private readonly string m_album;
        /// -------------------------
        /// <summary>
        /// Obtient l'album.
        /// </summary>
        /// -------------------------
        public string Album
        {
            get { return m_album; }
        }

        /// =====================================================================
        private readonly string m_titre;
        /// --------------------------
        /// <summary>
        /// Obtient le titre.
        /// </summary>
        /// --------------------------
        public string Titre
        {
            get { return m_titre; }
        }
        /// =====================================================================
        private int m_cote;
        /// --------------------------
        /// <summary>
        /// Obtient la cote.
        /// </summary>
        /// --------------------------
        public int Cote
        {
            get { return m_cote; }
            set { m_cote = value; }
        }
        /// =====================================================================
        private readonly int m_durée;
        /// -------------------------------
        /// <summary>
        /// Obtient la durée en secondes.
        /// </summary>
        /// -------------------------------
        public int Durée
        {
            get { return m_durée; }
        }
        #endregion CHAMPS - Variables membre

        #region CONSTRUCTEURS - NE PAS MODIFIER
        ///==========================================================================================
        /// <summary>
        /// Initialise une instance de la classe Morceau avec les données passées en paramètre.
        /// </summary>
        /// <param name="pArtiste">Nom de l'artiste ou du groupe</param>
        /// <param name="pAlbum">Nom de l'album</param>
        /// <param name="pTitre">Titre du morceau</param>
        /// <param name="pCote">Cote du morceau /5</param>
        /// <param name="pDurée">Durée du morceau en secondes</param>
        /// ----------------------------------------------------------------------------------------
        public Morceau(string pArtiste, string pAlbum, string pTitre, int pCote, int pDurée)
        {
            m_artiste = pArtiste;
            m_album = pAlbum;
            m_titre = pTitre;
            m_cote = pCote;
            m_durée = pDurée;
        }
        #endregion CONSTRUCTEUR

        #region MÉTHODE - NE PAS MODIFIER 
        /// <summary>
        /// Fournis une version lisible incluant le nom de l'artiste ainsi que le titre
        /// </summary>
        /// <returns>L'artiste ainsi que le titre</returns>
        public override string ToString()
        {
            return m_titre + " par " + m_artiste;
        }

        #endregion
    }
}
