namespace CSharpAcademy.TestsUnit
{
    public class TransactionServiceTests
    {
        [Fact]
        public void TransactionService_Execute_ValideToutesLesTransactions()
        {
            // Arrange
            var service = new TransactionService();
            var transaction1 = new Credit(new Donnees(DateTime.Now, 5000, Type.Credit, "Credit valide"));
            var transaction2 = new Debit(new Donnees(DateTime.Now, 1000, Type.Debit, "Debit valide"));

            service.AjouterTransaction(transaction1);
            service.AjouterTransaction(transaction2);

            // Act
            var exception = Record.Exception(() => service.execute());

            // Assert
            Assert.Null(exception); // Pas d'exception levée
        }

        [Fact]
        public void TransactionService_AjouterTransaction_Null_LanceException()
        {
            // Arrange
            var service = new TransactionService();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => service.AjouterTransaction(null));
        }

    }
}