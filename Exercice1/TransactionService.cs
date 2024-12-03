public class TransactionService
{
    private readonly List<ITransaction> _transactions = new List<ITransaction>();
    public void AjouterTransaction(ITransaction transaction)
    {
        if (transaction == null)
            throw new ArgumentException("La transaction est invalide");

        _transactions.Add(transaction);
    }
    public void execute()
    {
        foreach (ITransaction transaction in _transactions)
            {
                transaction.Valider();
            }
    }

}