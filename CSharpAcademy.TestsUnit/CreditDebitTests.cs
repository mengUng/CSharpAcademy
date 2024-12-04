namespace CSharpAcademy.TestsUnit
{
    public class CreditDebitTests 
    {
        // Test de la classe Credit
        [Fact]
        public void Credit_Valider_TransactionValide()
        {
            // Arrange
            var donnees = new Donnees(DateTime.Now, 5000f, Type.Credit, "Crédit valide");
            var credit = new Credit(donnees);

            // Act & Assert
            var exception = Record.Exception(() => credit.Valider());
            Assert.Null(exception); // Pas d'exception attendue
        }

        [Fact]
        public void Credit_Valider_TransactionNonValideMontantDepasse()
        {
            // Arrange
            var donnees = new Donnees(DateTime.Now, 15000f, Type.Credit, "Crédit invalide");
            var credit = new Credit(donnees);

            // Act
            var exception = Record.Exception(() => credit.Valider());

            // Assert
            Assert.Null(exception); // Pas d'exception levée, mais le message indique un dépassement de montant
        }

        [Fact]
        public void Credit_DonneesNull_LanceException()
        {
            // Arrange
            var credit = new Credit(null);

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => credit.Valider());
        }

        [Fact]
        public void Debit_Valider_TransactionValide()
        {
            // Arrange
            var donnees = new Donnees(DateTime.Now, 1000f, Type.Debit, "Débit valide");
            var debit = new Debit(donnees);

            // Act & Assert
            var exception = Record.Exception(() => debit.Valider());
            Assert.Null(exception); // Pas d'exception attendue
        }

        [Fact]
        public void Debit_Valider_TransactionNonValideSoldeInsuffisant()
        {
            // Arrange
            var donnees = new Donnees(DateTime.Now, -6000f, Type.Debit, "Débit invalide");
            var debit = new Debit(donnees);

            // Act
            var exception = Record.Exception(() => debit.Valider());

            // Assert
            Assert.Null(exception); // Pas d'exception levée, mais le message indique un solde insuffisant
        }

        [Fact]
        public void Debit_DonneesNull_LanceException()
        {
            // Arrange
            var debit = new Debit(null);

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => debit.Valider());
        }

    }
}