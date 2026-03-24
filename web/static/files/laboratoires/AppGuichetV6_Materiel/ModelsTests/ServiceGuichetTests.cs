//Décommenter les lignes suivantes pour activer les tests
//#define TestClasseServiceGuichet

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using System;
using System.IO;

namespace Models.Tests
{
    
    /// <summary>
    /// Classe de test pour Models, destinée à contenir tous
    /// les tests unitaires de la classe ServiceGuichet
    /// </summary>
    [TestClass()]
    public class CorrecteurServiceGuichet
    {
       
        public static string m_version = "Correcteur ServiceGuichet H26.5.0";

        #region Variables et constructeur des tests

        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        private static int m_totalScore;
        private static int m_maxScore;

        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            m_totalScore = 0;
            m_maxScore = 0;
        }

        [ClassCleanup()]
        public static void MyClassCleanup()
        {
            StreamWriter ficScore = new StreamWriter("../../../ScoreServiceGuichet.txt");
            ficScore.Write(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            ficScore.Write("\nRésultat de la correction (" + m_version + ")\nScore : " + m_totalScore + "/" + m_maxScore);
            ficScore.Close();
        }

        #endregion
#if TestClasseServiceGuichet
#region Méthodes utilitaires

        private string CreerDossierTemporaire()
        {
            string dossier = Path.Combine(Path.GetTempPath(), "Tests_ServiceGuichet_" + Guid.NewGuid().ToString("N"));
            Directory.CreateDirectory(dossier);
            return dossier;
        }

        private string CreerFichier(string dossier, string nomFichier, string[] lignes)
        {
            string chemin = Path.Combine(dossier, nomFichier);
            File.WriteAllLines(chemin, lignes);
            return chemin;
        }

        private ServiceGuichet CreerServiceValide()
        {
            string dossier = CreerDossierTemporaire();

            string cheminClients = CreerFichier(dossier, "Clients.csv", new string[]
            {
                "000001,Jean Tremblay,abc,0,0,500",
                "000002,Admin Principal,admin,1,1,1000"
            });

            string cheminTransactions = CreerFichier(dossier, "Transactions.csv", new string[]
            {
                "0,000001,2026-03-12 10:00:00,100",
                "1,000002,2026-03-12 11:00:00,50"
            });

            return new ServiceGuichet(cheminClients, cheminTransactions);
        }

        private bool InstancierAvecArgumentException(string pCheminClients, string pCheminTransactions)
        {
            try
            {
                ServiceGuichet service = new ServiceGuichet(pCheminClients, pCheminTransactions);
                return false;
            }
            catch (ArgumentException)
            {
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool CreerTransactionAvecArgumentException(
            ServiceGuichet pService,
            SorteTransactions pSorte,
            string pNumClient,
            DateTime pDate,
            int pMontant)
        {
            try
            {
                pService.CreerTransaction(pSorte, pNumClient, pDate, pMontant);
                return false;
            }
            catch (ArgumentException)
            {
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private string CreerNomFichierTemp(string prefixe)
        {
            return Path.Combine(Path.GetTempPath(), prefixe + "_" + Guid.NewGuid().ToString("N") + ".csv");
        }

        private ServiceGuichet CreerServiceValideAvecFichiersTemporaires(
    out string cheminClients,
    out string cheminTransactions)
        {
            string dossier = CreerDossierTemporaire();

            cheminClients = CreerFichier(dossier, "Clients.csv", new string[]
            {
                "000001,Jean Tremblay,abc,0,0,500",
                "000002,Admin Principal,admin,1,1,1000"
            });

            cheminTransactions = CreerFichier(dossier, "Transactions.csv", new string[]
            {
                "0,000001,2026-03-12 10:00:00,100",
                "1,000002,2026-03-12 11:00:00,50"
            });

            return new ServiceGuichet(cheminClients, cheminTransactions);
        }
        #endregion

        #region Tests de la classe ServiceGuichet


        /// <summary>
        /// Test pour le constructeur avec chemins valides
        /// </summary>
        [TestMethod()]
        public void A01_ConstructeurValideTest()
        {
            m_maxScore += 3;

            ServiceGuichet target = CreerServiceValide();

            Assert.IsNotNull(target.Clients);
            Assert.IsNotNull(target.Transactions);
            Assert.AreEqual(0, target.Clients.Count);
            Assert.AreEqual(0, target.Transactions.Count);
            Assert.IsNull(target.ClientCourant);

            Assert.IsTrue(File.Exists(target.CheminFichierClients));
            Assert.IsTrue(File.Exists(target.CheminFichierTransactions));

            m_totalScore += 3;
        }

        /// <summary>
        /// Test pour le constructeur avec chemin clients invalide
        /// </summary>
        [TestMethod()]
        public void A02_ConstructeurCheminClientsInvalideTest()
        {
            m_maxScore += 2;

            string dossier = CreerDossierTemporaire();
            string cheminClients = Path.Combine(dossier, "ClientsInexistant.csv");
            string cheminTransactions = CreerFichier(dossier, "Transactions.csv", new string[] { });

            Assert.IsTrue(InstancierAvecArgumentException(cheminClients, cheminTransactions));

            m_totalScore += 2;
        }

        /// <summary>
        /// Test pour le constructeur avec chemin transactions invalide
        /// </summary>
        [TestMethod()]
        public void A03_ConstructeurCheminTransactionsInvalideTest()
        {
            m_maxScore += 2;

            string dossier = CreerDossierTemporaire();
            string cheminClients = CreerFichier(dossier, "Clients.csv", new string[] { });
            string cheminTransactions = Path.Combine(dossier, "TransactionsInexistant.csv");

            Assert.IsTrue(InstancierAvecArgumentException(cheminClients, cheminTransactions));

            m_totalScore += 2;
        }

        /// <summary>
        /// Test pour ChargerClients avec données valides
        /// </summary>
        [TestMethod()]
        public void A04_ChargerClientsValideTest()
        {
            m_maxScore += 3;

            ServiceGuichet target = CreerServiceValide();

            int nbErreurs = target.ChargerClients();

            Assert.AreEqual(0, nbErreurs);
            Assert.AreEqual(2, target.Clients.Count);

            Assert.AreEqual("000001", target.Clients[0].NumClient);
            Assert.AreEqual("Jean Tremblay", target.Clients[0].Nom);
            Assert.AreEqual("abc", target.Clients[0].MotDePasse);

            Assert.AreEqual("000002", target.Clients[1].NumClient);
            Assert.AreEqual("Admin Principal", target.Clients[1].Nom);
            Assert.AreEqual("admin", target.Clients[1].MotDePasse);

            m_totalScore += 3;
        }

        /// <summary>
        /// Test pour ChargerClients avec ligne invalide
        /// </summary>
        [TestMethod()]
        public void A05_ChargerClientsInvalideTest()
        {
            m_maxScore += 2;

            string dossier = CreerDossierTemporaire();

            string cheminClients = CreerFichier(dossier, "Clients.csv", new string[]
            {
                "000001,Jean Tremblay,abc,0,0,500",
                "ligne_invalide"
            });

            string cheminTransactions = CreerFichier(dossier, "Transactions.csv", new string[] { });

            ServiceGuichet target = new ServiceGuichet(cheminClients, cheminTransactions);

            int nbErreurs = target.ChargerClients();

            Assert.AreEqual(1, nbErreurs);
            Assert.AreEqual(1, target.Clients.Count);

            m_totalScore += 2;
        }

        /// <summary>
        /// Test pour ChargerTransactions avec données valides
        /// </summary>
        [TestMethod()]
        public void A06_ChargerTransactionsValideTest()
        {
            m_maxScore += 4;

            ServiceGuichet target = CreerServiceValide();

            target.ChargerClients();
            int nbErreurs = target.ChargerTransactions();

            Assert.AreEqual(0, nbErreurs);
            Assert.AreEqual(2, target.Transactions.Count);

            Assert.AreEqual(SorteTransactions.Dépôt, target.Transactions[0].SorteTransaction);
            Assert.AreEqual("000001", target.Transactions[0].NumClient);
            Assert.AreEqual(DateTime.Parse("2026-03-12 10:00:00"), target.Transactions[0].Date);
            Assert.AreEqual(100, target.Transactions[0].Montant);

            Assert.AreEqual(SorteTransactions.Retrait, target.Transactions[1].SorteTransaction);
            Assert.AreEqual("000002", target.Transactions[1].NumClient);
            Assert.AreEqual(DateTime.Parse("2026-03-12 11:00:00"), target.Transactions[1].Date);
            Assert.AreEqual(50, target.Transactions[1].Montant);

            Assert.AreEqual(1, target.TrouverClient("000001").Transactions.Count);
            Assert.AreEqual(1, target.TrouverClient("000002").Transactions.Count);

            m_totalScore += 4;
        }

        /// <summary>
        /// Test pour ChargerTransactions avec ligne invalide
        /// </summary>
        [TestMethod()]
        public void A07_ChargerTransactionsInvalideTest()
        {
            m_maxScore += 2;

            string dossier = CreerDossierTemporaire();

            string cheminClients = CreerFichier(dossier, "Clients.csv", new string[]
            {
                "000001,Jean Tremblay,abc,0,0,500"
            });

            string cheminTransactions = CreerFichier(dossier, "Transactions.csv", new string[]
            {
                "0,000001,2026-03-12 10:00:00,100",
                "ligne_invalide"
            });

            ServiceGuichet target = new ServiceGuichet(cheminClients, cheminTransactions);

            target.ChargerClients();
            int nbErreurs = target.ChargerTransactions();

            Assert.AreEqual(1, nbErreurs);
            Assert.AreEqual(1, target.Transactions.Count);

            m_totalScore += 2;
        }

        /// <summary>
        /// Test pour ChargerTransactions avec client introuvable
        /// </summary>
        [TestMethod()]
        public void A08_ChargerTransactionsClientInvalideTest()
        {
            m_maxScore += 2;

            string dossier = CreerDossierTemporaire();

            string cheminClients = CreerFichier(dossier, "Clients.csv", new string[]
            {
                "000001,Jean Tremblay,abc,0,0,500"
            });

            string cheminTransactions = CreerFichier(dossier, "Transactions.csv", new string[]
            {
                "0,999,2026-03-12 10:00:00,100"
            });

            ServiceGuichet target = new ServiceGuichet(cheminClients, cheminTransactions);

            target.ChargerClients();
            int nbErreurs = target.ChargerTransactions();

            Assert.AreEqual(1, nbErreurs);
            Assert.AreEqual(0, target.Transactions.Count);

            m_totalScore += 2;
        }

        /// <summary>
        /// Test pour TrouverClient
        /// </summary>
        [TestMethod()]
        public void A09_TrouverClientTest()
        {
            m_maxScore += 2;

            ServiceGuichet target = CreerServiceValide();
            target.ChargerClients();

            Client trouve = target.TrouverClient("000001");
            Client introuvable = target.TrouverClient("999");

            Assert.IsNotNull(trouve);
            Assert.AreEqual("000001", trouve.NumClient);
            Assert.IsNull(introuvable);

            m_totalScore += 2;
        }

        /// <summary>
        /// Test pour Connexion valide
        /// </summary>
        [TestMethod()]
        public void A10_ConnexionValideTest()
        {
            m_maxScore += 2;

            ServiceGuichet target = CreerServiceValide();
            target.ChargerClients();

            bool resultat = target.Connexion("000001", "abc");

            Assert.IsTrue(resultat);
            Assert.IsNotNull(target.ClientCourant);
            Assert.AreEqual("000001", target.ClientCourant.NumClient);

            m_totalScore += 2;
        }

        /// <summary>
        /// Test pour Connexion invalide
        /// </summary>
        [TestMethod()]
        public void A11_ConnexionInvalideTest()
        {
            m_maxScore += 2;

            ServiceGuichet target = CreerServiceValide();
            target.ChargerClients();

            Assert.IsFalse(target.Connexion("999", "abc"));
            Assert.IsNull(target.ClientCourant);

            Assert.IsFalse(target.Connexion("001", "mauvais"));
            Assert.IsNull(target.ClientCourant);

            m_totalScore += 2;
        }

        /// <summary>
        /// Test pour Deconnexion
        /// </summary>
        [TestMethod()]
        public void A12_DeconnexionTest()
        {
            m_maxScore += 2;

            ServiceGuichet target = CreerServiceValide();
            target.ChargerClients();
            target.Connexion("001", "abc");

            bool resultat = target.Deconnexion();

            Assert.IsTrue(resultat);
            Assert.IsNull(target.ClientCourant);

            m_totalScore += 2;
        }

        /// <summary>
        /// Test pour CreerTransaction valide
        /// </summary>
        [TestMethod()]
        public void A13_CreerTransactionValideTest()
        {
            m_maxScore += 3;

            ServiceGuichet target = CreerServiceValide();
            target.ChargerClients();

            Client client = target.TrouverClient("000001");
            int nbTransactionsServiceAvant = target.Transactions.Count;
            int nbTransactionsClientAvant = client.Transactions.Count;

            DateTime date = new DateTime(2026, 03, 12, 14, 30, 45);

            target.CreerTransaction(SorteTransactions.Dépôt, "000001", date, 100);

            Assert.AreEqual(nbTransactionsServiceAvant + 1, target.Transactions.Count);
            Assert.AreEqual(nbTransactionsClientAvant + 1, client.Transactions.Count);

            Transaction t = target.Transactions[target.Transactions.Count - 1];
            Assert.AreEqual(SorteTransactions.Dépôt, t.SorteTransaction);
            Assert.AreEqual("000001", t.NumClient);
            Assert.AreEqual(date, t.Date);
            Assert.AreEqual(100, t.Montant);

            m_totalScore += 3;
        }

        /// <summary>
        /// Test pour CreerTransaction avec client invalide
        /// </summary>
        [TestMethod()]
        public void A14_CreerTransactionClientInvalideTest()
        {
            m_maxScore += 2;

            ServiceGuichet target = CreerServiceValide();
            target.ChargerClients();

            Assert.IsTrue(CreerTransactionAvecArgumentException(
                target,
                SorteTransactions.Dépôt,
                "999",
                DateTime.Now,
                100));

            m_totalScore += 2;
        }

        /// <summary>
        /// Test pour SauvegarderClients
        /// </summary>
        [TestMethod()]
        public void A15_SauvegarderClientsTest()
        {
            m_maxScore += 3;

            ServiceGuichet target = CreerServiceValide();
            target.ChargerClients();

            string fichier = CreerNomFichierTemp("Clients");

            target.SauvegarderClients(fichier);

            Assert.IsTrue(File.Exists(fichier));

            string[] lignes = File.ReadAllLines(fichier);
            Assert.AreEqual(target.Clients.Count, lignes.Length);

            for (int i = 0; i < target.Clients.Count; i++)
            {
                Assert.AreEqual(target.Clients[i].ToCsv(), lignes[i]);
            }

            m_totalScore += 3;
        }

        /// <summary>
        /// Test pour SauvegarderTransactions
        /// </summary>
        [TestMethod()]
        public void A16_SauvegarderTransactionsTest()
        {
            m_maxScore += 3;

            ServiceGuichet target = CreerServiceValide();
            target.ChargerClients();
            target.ChargerTransactions();

            string fichier = CreerNomFichierTemp("Transactions");

            target.SauvegarderTransactions(fichier);

            Assert.IsTrue(File.Exists(fichier));

            string[] lignes = File.ReadAllLines(fichier);
            Assert.AreEqual(target.Transactions.Count, lignes.Length);

            for (int i = 0; i < target.Transactions.Count; i++)
            {
                Assert.AreEqual(target.Transactions[i].ToCsv(), lignes[i]);
            }

            m_totalScore += 3;
        }

        /// <summary>
        /// Test pour Sauvegarde
        /// </summary>
        [TestMethod()]
        public void A17_SauvegardeTest()
        {
            m_maxScore += 2;

            ServiceGuichet target = CreerServiceValide();
            target.ChargerClients();
            target.ChargerTransactions();

            bool resultat = target.Sauvegarde();

            Assert.IsTrue(resultat);

            m_totalScore += 2;
        }

        /// <summary>
        /// Test pour vérifier le contenu exact du fichier Clients après Sauvegarde()
        /// </summary>
        [TestMethod()]
        public void A18_SauvegardeContenuClientsTest()
        {
            m_maxScore += 3;

            string cheminClients;
            string cheminTransactions;

            ServiceGuichet target = CreerServiceValideAvecFichiersTemporaires(
                out cheminClients,
                out cheminTransactions);

            target.ChargerClients();

            bool resultat = target.Sauvegarde();

            Assert.IsTrue(resultat);
            Assert.IsTrue(File.Exists(cheminClients));

            string[] lignes = File.ReadAllLines(cheminClients);

            Assert.AreEqual(target.Clients.Count, lignes.Length);

            for (int i = 0; i < target.Clients.Count; i++)
            {
                Assert.AreEqual(target.Clients[i].ToCsv(), lignes[i]);
            }

            m_totalScore += 3;
        }

        /// <summary>
        /// Test pour vérifier le contenu exact du fichier Transactions après Sauvegarde()
        /// </summary>
        [TestMethod()]
        public void A19_SauvegardeContenuTransactionsTest()
        {
            m_maxScore += 3;

            string cheminClients;
            string cheminTransactions;

            ServiceGuichet target = CreerServiceValideAvecFichiersTemporaires(
                out cheminClients,
                out cheminTransactions);

            target.ChargerClients();
            target.ChargerTransactions();

            bool resultat = target.Sauvegarde();

            Assert.IsTrue(resultat);
            Assert.IsTrue(File.Exists(cheminTransactions));

            string[] lignes = File.ReadAllLines(cheminTransactions);

            Assert.AreEqual(target.Transactions.Count, lignes.Length);

            for (int i = 0; i < target.Transactions.Count; i++)
            {
                Assert.AreEqual(target.Transactions[i].ToCsv(), lignes[i]);
            }

            m_totalScore += 3;
        }

        /// <summary>
        /// Test pour vérifier le contenu exact des fichiers après modification et Sauvegarde()
        /// </summary>
        [TestMethod()]
        public void A20_SauvegardeContenuApresModificationTest()
        {
            m_maxScore += 4;

            string cheminClients;
            string cheminTransactions;

            ServiceGuichet target = CreerServiceValideAvecFichiersTemporaires(
                out cheminClients,
                out cheminTransactions);

            target.ChargerClients();
            target.ChargerTransactions();

            DateTime date = new DateTime(2026, 03, 15, 9, 45, 0);
            target.CreerTransaction(SorteTransactions.Dépôt, "000001", date, 200);

            bool resultat = target.Sauvegarde();

            Assert.IsTrue(resultat);

            string[] lignesClients = File.ReadAllLines(cheminClients);
            string[] lignesTransactions = File.ReadAllLines(cheminTransactions);

            Assert.AreEqual(target.Clients.Count, lignesClients.Length);
            Assert.AreEqual(target.Transactions.Count, lignesTransactions.Length);

            for (int i = 0; i < target.Clients.Count; i++)
            {
                Assert.AreEqual(target.Clients[i].ToCsv(), lignesClients[i]);
            }

            for (int i = 0; i < target.Transactions.Count; i++)
            {
                Assert.AreEqual(target.Transactions[i].ToCsv(), lignesTransactions[i]);
            }

            Assert.AreEqual("0,000001,2026-03-15 09:45:00,200", lignesTransactions[lignesTransactions.Length - 1]);

            m_totalScore += 4;
        }




#endregion
#endif
    }
}