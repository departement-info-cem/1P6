// Décommenter les lignes suivantes pour activer les tests
//#define TestClasseTransaction

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using System;
using System.IO;

namespace Models.Tests
{
#if TestClasseTransaction
    /// <summary>
    /// Classe de test pour Models, destinée à contenir tous
    /// les tests unitaires de la classe Transaction
    /// </summary>
    [TestClass()]
    public class CorrecteurTransaction
    {
        public static string m_version = "Correcteur Transaction H26.4.0";

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
            StreamWriter ficScore = new StreamWriter("../../../ScoreTransaction.txt");
            ficScore.Write(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            ficScore.Write("\nRésultat de la correction (" + m_version + ")\nScore : " + m_totalScore + "/" + m_maxScore);
            ficScore.Close();
        }

        #endregion

        #region Méthodes utilitaires

        private bool InstancierTransactionAvecArgumentOutOfRange(
            SorteTransactions pSorte,
            string pNumClient,
            DateTime pDate,
            int pMontant)
        {
            try
            {
                Transaction t = new Transaction(pSorte, pNumClient, pDate, pMontant);
                return false;
            }
            catch (ArgumentOutOfRangeException)
            {
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool InstancierTransactionAvecArgumentNullException(
            SorteTransactions pSorte,
            string pNumClient,
            DateTime pDate,
            int pMontant)
        {
            try
            {
                Transaction t = new Transaction(pSorte, pNumClient, pDate, pMontant);
                return false;
            }
            catch (ArgumentNullException)
            {
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool InstancierTransactionAvecArgumentException(
            SorteTransactions pSorte,
            string pNumClient,
            DateTime pDate,
            int pMontant)
        {
            try
            {
                Transaction t = new Transaction(pSorte, pNumClient, pDate, pMontant);
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

        #endregion

        #region Tests de la classe Transaction


        /// <summary>
        /// Test pour le constructeur Transaction
        /// Test aussi les getters
        /// </summary>
        [TestMethod()]
        public void A01_TransactionConstructeurValide()
        {
            m_maxScore += 3;

            DateTime date = new DateTime(2026, 03, 12, 14, 30, 45);

            Transaction target = new Transaction(
                SorteTransactions.Dépôt,
                "000001",
                date,
                100);

            Assert.AreEqual(SorteTransactions.Dépôt, target.SorteTransaction);
            Assert.AreEqual("000001", target.NumClient);
            Assert.AreEqual(date, target.Date);
            Assert.AreEqual(100, target.Montant);

            m_totalScore += 3;
        }

        /// <summary>
        /// Test pour le constructeur Transaction avec montant invalide
        /// </summary>
        [TestMethod()]
        public void A02_TransactionConstructeurMontantInvalide()
        {
            m_maxScore += 2;

            DateTime date = DateTime.Now;

            Assert.IsTrue(InstancierTransactionAvecArgumentOutOfRange(
                SorteTransactions.Dépôt, "000001", date, 0));

            Assert.IsTrue(InstancierTransactionAvecArgumentOutOfRange(
                SorteTransactions.Dépôt, "000001", date, -1));

            m_totalScore += 2;
        }

        /// <summary>
        /// Test pour ToCsv
        /// </summary>
        [TestMethod()]
        public void A03_ToCsvTest()
        {
            m_maxScore += 3;

            DateTime date = new DateTime(2026, 03, 12, 14, 30, 45);

            Transaction target = new Transaction(
                SorteTransactions.Dépôt,
                "000001",
                date,
                250);

            string attendu =
                (int)SorteTransactions.Dépôt + ","
                + "000001,"
                + "2026-03-12 14:30:45,250";

            Assert.AreEqual(attendu, target.ToCsv());

            m_totalScore += 3;
        }

        /// <summary>
        /// Test avec une autre sorte de transaction
        /// </summary>
        [TestMethod()]
        public void A04_TransactionConstructeurAutreSorte()
        {
            m_maxScore += 2;

            DateTime date = new DateTime(2026, 04, 01, 8, 15, 0);

            Transaction target = new Transaction(
                SorteTransactions.Retrait,
                "999999",
                date,
                50);

            Assert.AreEqual(SorteTransactions.Retrait, target.SorteTransaction);
            Assert.AreEqual("999999", target.NumClient);
            Assert.AreEqual(date, target.Date);
            Assert.AreEqual(50, target.Montant);

            m_totalScore += 2;
        }

        /// <summary>
        /// Test si NumClient est null
        /// </summary>
        [TestMethod()]
        public void A05_TransactionConstructeurNumClientNull()
        {
            m_maxScore += 2;

            DateTime date = DateTime.Now;

            Assert.IsTrue(InstancierTransactionAvecArgumentNullException(
                SorteTransactions.Dépôt, null, date, 100));

            m_totalScore += 2;
        }

        /// <summary>
        /// Test si NumClient ne contient pas exactement 6 chiffres
        /// </summary>
        [TestMethod()]
        public void A06_TransactionConstructeurNumClientLongueurInvalide()
        {
            m_maxScore += 2;

            DateTime date = DateTime.Now;

            Assert.IsTrue(InstancierTransactionAvecArgumentException(
                SorteTransactions.Dépôt, "12345", date, 100));

            Assert.IsTrue(InstancierTransactionAvecArgumentException(
                SorteTransactions.Dépôt, "1234567", date, 100));

            m_totalScore += 2;
        }

        /// <summary>
        /// Test si NumClient contient des caractères non numériques
        /// </summary>
        [TestMethod()]
        public void A07_TransactionConstructeurNumClientNonNumerique()
        {
            m_maxScore += 2;

            DateTime date = DateTime.Now;

            Assert.IsTrue(InstancierTransactionAvecArgumentException(
                SorteTransactions.Dépôt, "12A456", date, 100));

            Assert.IsTrue(InstancierTransactionAvecArgumentException(
                SorteTransactions.Dépôt, "ABCDEF", date, 100));

            m_totalScore += 2;
        }

        /// <summary>
        /// Test si NumClient avec espaces autour est accepté après Trim()
        /// </summary>
        [TestMethod()]
        public void A08_TransactionConstructeurNumClientAvecEspaces()
        {
            m_maxScore += 2;

            DateTime date = new DateTime(2026, 05, 10, 9, 0, 0);

            Transaction target = new Transaction(
                SorteTransactions.Dépôt,
                " 123456 ",
                date,
                75);

            Assert.AreEqual("123456", target.NumClient);

            m_totalScore += 2;
        }


        #endregion
    }
#endif
}