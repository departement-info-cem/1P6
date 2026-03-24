//#define TestClasseClient
using Models;

namespace Models.Tests
{
    [TestClass()]
    public class CorrecteurClient
    {
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
            using StreamWriter ficScore = new StreamWriter("../../../ScoreClient.txt");
            ficScore.Write(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            ficScore.Write($"\nScore : {m_totalScore}/{m_maxScore}");
        }
#if TestClasseClient
        #region Tests Constructeurs

        [TestMethod()]
        public void Client_Constructeur6Param_Valide()
        {
            m_maxScore += 3;

            Client client = new Client("123456", "Jean Tremblay", "abc123", Roles.Client, SorteComptes.Épargne, 500);

            Assert.AreEqual("123456", client.NumClient);
            Assert.AreEqual("Jean Tremblay", client.Nom);
            Assert.AreEqual("abc123", client.MotDePasse);
            Assert.AreEqual(Roles.Client, client.Role);
            Assert.AreEqual(SorteComptes.Épargne, client.SorteCompte);
            Assert.AreEqual(500, client.Solde);
            Assert.IsFalse(client.IsAdmin);
            Assert.IsNotNull(client.Transactions);
            Assert.AreEqual(0, client.Transactions.Count);

            m_totalScore += 3;
        }

        [TestMethod()]
        public void Client_Constructeur1Param_Valide()
        {
            m_maxScore += 3;

            string csv = "654321,Marie Gagnon,xyz789,1,0,750";
            Client client = new Client(csv);

            Assert.AreEqual("654321", client.NumClient);
            Assert.AreEqual("Marie Gagnon", client.Nom);
            Assert.AreEqual("xyz789", client.MotDePasse);
            Assert.AreEqual((Roles)1, client.Role);
            Assert.AreEqual((SorteComptes)0, client.SorteCompte);
            Assert.AreEqual(750, client.Solde);
            Assert.IsFalse(client.IsAdmin);
            Assert.IsNotNull(client.Transactions);
            Assert.AreEqual(0, client.Transactions.Count);

            m_totalScore += 3;
        }

        [TestMethod()]
        public void Client_NumClient_NullOuIncorrect_DevraitLever()
        {
            m_maxScore += 2;

            Assert.ThrowsException<ArgumentNullException>(() => new Client(null, "Jean", "abc", Roles.Client, SorteComptes.Épargne, 0));
            Assert.ThrowsException<ArgumentException>(() => new Client("123", "Jean", "abc", Roles.Client, SorteComptes.Épargne, 0));
            Assert.ThrowsException<ArgumentException>(() => new Client("abcdef", "Jean", "abc", Roles.Client, SorteComptes.Épargne, 0));

            m_totalScore += 2;
        }

        [TestMethod()]
        public void Client_Nom_NullOuTropCourt_DevraitLever()
        {
            m_maxScore += 2;

            Assert.ThrowsException<ArgumentNullException>(() => new Client("123456", null, "abc", Roles.Client, SorteComptes.Épargne, 0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Client("123456", "Jo", "abc", Roles.Client, SorteComptes.Épargne, 0));

            m_totalScore += 2;
        }

        #endregion

        #region Tests Deposer / Retirer

        [TestMethod()]
        public void Deposer_Valide()
        {
            m_maxScore += 3;

            Client client = new Client("123456", "Jean", "abc", Roles.Client, SorteComptes.Épargne, 100);
            client.Deposer(50);
            Assert.AreEqual(150, client.Solde);

            m_totalScore += 3;
        }

        [TestMethod()]
        public void Deposer_Invalide()
        {
            m_maxScore += 3;

            Client client = new Client("123456", "Jean", "abc", Roles.Client, SorteComptes.Épargne, Client.MAX_SOLDE);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => client.Deposer(0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => client.Deposer(-10));
            Assert.ThrowsException<InvalidOperationException>(() => client.Deposer(1));

            m_totalScore += 3;
        }

        [TestMethod()]
        public void Retirer_Valide()
        {
            m_maxScore += 3;

            Client client = new Client("123456", "Jean", "abc", Roles.Client, SorteComptes.Épargne, 500);
            client.Retirer(100);
            Assert.AreEqual(400, client.Solde);

            m_totalScore += 3;
        }

        [TestMethod()]
        public void Retirer_Invalide()
        {
            m_maxScore += 3;

            Client client = new Client("123456", "Jean", "abc", Roles.Client, SorteComptes.Épargne, 100);
           
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => client.Retirer(0));
           
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => client.Retirer(-5));
           
            Assert.ThrowsException<InvalidOperationException>(() => client.Retirer(101));

            m_totalScore += 3;
        }

        #endregion

        #region Tests Transactions

        [TestMethod()]
        public void AjouterTransaction_Null_DevraitLever()
        {
            m_maxScore += 2;

            Client client = new Client("123456", "Jean", "abc", Roles.Client, SorteComptes.Épargne, 100);
            Assert.ThrowsException<ArgumentNullException>(() => client.AjouterTransaction(null));

            m_totalScore += 2;
        }

        [TestMethod()]
        public void AjouterTransaction_Valide()
        {
            m_maxScore += 3;

            Client client = new Client("123456", "Jean", "abc", Roles.Client, SorteComptes.Épargne, 100);
            Transaction t = new Transaction(SorteTransactions.Dépôt, "123456", DateTime.Now, 50);

            client.AjouterTransaction(t);

            Assert.AreEqual(1, client.Transactions.Count);
            Assert.AreSame(t, client.Transactions[0]);

            m_totalScore += 3;
        }

        [TestMethod()]
        public void AjouterTransaction_DejaExistante_DevraitLever()
        {
            m_maxScore += 2;

            Client client = new Client("123456", "Jean", "abc", Roles.Client, SorteComptes.Épargne, 100);
            Transaction t = new Transaction(SorteTransactions.Dépôt, "123456", DateTime.Now, 50);
            client.AjouterTransaction(t);

            Assert.ThrowsException<InvalidOperationException>(() => client.AjouterTransaction(t));

            m_totalScore += 2;
        }

        #endregion
#endif
    }
}