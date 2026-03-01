using adaptation_tp1_console;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestsUnitaires
{
    [TestClass]
    public sealed class TestsDeBase
    {

        #region TESTS TODO 01
        /// <summary>
        /// Teste le chargement correct des morceaux provenant d'un fichier existant.
        /// Vérifie la lecture adéquate du fichier, la création d'un objet Morceau et l'ajout à la liste.
        /// </summary>
        [TestMethod]
        public void ChargerMorceaux_FichierValide()
        {
            List<Morceau> listeMorceauxTest = new List<Morceau>();

            listeMorceauxTest = adaptation_tp1_console.Program.ChargerMorceaux("../../../Bibliothèque_Test.csv", listeMorceauxTest);

            Assert.AreEqual(10, listeMorceauxTest.Count);
        }

        /// <summary>
        /// Teste le chargement de morceaux provenant d'un fichier inexistant.
        /// </summary>
        [TestMethod]
        public void ChargerMorceaux_FichierInexistant()
        {

            List<Morceau> listeMorceauxTest = new List<Morceau>();

            listeMorceauxTest = adaptation_tp1_console.Program.ChargerMorceaux("fichier_invalide.csv", listeMorceauxTest);

            Assert.AreEqual(0, listeMorceauxTest.Count);
        }

        #endregion

        #region TEST TODO 03
        /// <summary>
        /// Teste l'ajout d'un morceau valide à une liste de morceaux.
        /// </summary>
        [TestMethod]
        public void AjouterMorceau_Valide()
        {

            List<Morceau> listeMorceauxTest = new List<Morceau>();

            listeMorceauxTest = adaptation_tp1_console.Program.OpérationAjouter(listeMorceauxTest, "Artiste", "Album", "Titre", 3, 120);

            Assert.AreEqual(1, listeMorceauxTest.Count);
        }
        #endregion

        #region TEST TODO 04
        /// <summary>
        /// Teste la suppression d'un morceau en utilisant un index valide.
        /// </summary>
        [TestMethod]
        public void SupprimerMorceau_IndexValide()
        {

            List<Morceau> listeMorceauxTest = new List<Morceau>
            {
                new Morceau("R.E.M.", "Out Of Time", "Losing My Religion", 3, 268),
                new Morceau("Leonard Cohen", "Songs Of Leonard Cohen", "So Long, Marianne", 1, 340)
            };

            listeMorceauxTest = adaptation_tp1_console.Program.OpérationSupprimer(listeMorceauxTest, 0);

            Assert.AreEqual(1, listeMorceauxTest.Count);
        }
        #endregion

        #region TEST TODO 05
        /// <summary>
        /// Teste la modification de la cote d'un morceau d'une liste. L'index et la nouvelle cote sont valides.
        /// </summary>
        [TestMethod]
        public void ModifierCote_CoteValide()
        {
            List<Morceau> listeMorceauxTest = new List<Morceau>
            {
                new Morceau("R.E.M.", "Out Of Time", "Losing My Religion", 3, 268),
                new Morceau("Leonard Cohen", "Songs Of Leonard Cohen", "So Long, Marianne", 1, 340)
            };

            listeMorceauxTest = adaptation_tp1_console.Program.OpérationModiferCote(listeMorceauxTest, 1, 5);

            Assert.AreEqual(5, listeMorceauxTest[1].Cote);
        }
        #endregion

        #region TEST TODO 06
        /// <summary>
        /// Teste le triage des morceaux d'une liste en ordre décroissant de leur cote d'appréciation.
        /// </summary>
        [TestMethod]
        public void TrierMorceaux_OrdreDecroissant()
        {
            List<Morceau> listeMorceauxTest = new List<Morceau>
            {
                new Morceau("R.E.M.", "Out Of Time", "Losing My Religion", 3, 268),
                new Morceau("Leonard Cohen", "Songs Of Leonard Cohen", "So Long, Marianne", 1, 340),
                new Morceau("Geoffroy", "Field Study", "Piece of Art", 5, 126),
                new Morceau("Harry Styles", "Kiss All The Time. Disco, Occasionally.", "Aperture", 4, 311)

            };

            listeMorceauxTest = adaptation_tp1_console.Program.OpérationTrier(listeMorceauxTest);

            Assert.AreEqual(5, listeMorceauxTest[0].Cote);
            Assert.AreEqual(1, listeMorceauxTest[3].Cote);
        }
        #endregion

        #region TEST TODO 09
        /// <summary>
        /// Teste l'écriture correcte des morceaux dans un fichier CSV.
        /// Vérifie que le fichier est créé et que son contenu correspond aux objets Morceau fournis.
        /// </summary>
        [TestMethod]
        public void OperationQuitter_FichierValide()
        {
            
            string nomFichierTest = "../../../Bibliothèque_Sortie_Test.csv";

            List<Morceau> listeMorceauxTest = new List<Morceau>
            {
                new Morceau("R.E.M.", "Out Of Time", "Losing My Religion", 3, 268),
                new Morceau("Leonard Cohen", "Songs Of Leonard Cohen", "So Long, Marianne", 1, 340)
            };

            
            adaptation_tp1_console.Program.OpérationQuitter(nomFichierTest, listeMorceauxTest);

            
            Assert.IsTrue(File.Exists(nomFichierTest), "Le fichier n'a pas été créé.");

            string[] lignes = File.ReadAllLines(nomFichierTest);
            Assert.AreEqual(2, lignes.Length);

            Assert.AreEqual(
                "R.E.M.|Out Of Time|Losing My Religion|3|04:28",
                lignes[0]
            );

            Assert.AreEqual(
                "Leonard Cohen|Songs Of Leonard Cohen|So Long, Marianne|1|05:40",
                lignes[1]
            );


            File.Delete(nomFichierTest);
        }

        #endregion


    }
}
