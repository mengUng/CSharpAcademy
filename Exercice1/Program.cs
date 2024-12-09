

using System.Reflection.Metadata;
internal partial class Program
{
    private static void Main(string[] args)
    {

        TransactionService service = new TransactionService();
        service.AjouterTransaction(new Credit(new Donnees(DateTime.Now, 11000, Type.Credit, "Transaction No 1")));
        service.AjouterTransaction(new Debit(new Donnees(DateTime.Now, -6000, Type.Debit, "Transaction No 2")));
        service.AjouterTransaction(new Cloture(new Donnees(DateTime.Now, 100, Type.Cloture, "Transaction No 3")));

        service.AjouterTransaction(new Credit(new Donnees(DateTime.Now, 150, Type.Credit, "Transaction No 4")));
        service.AjouterTransaction(new Debit(new Donnees(DateTime.Now, -2000, Type.Debit, "Transaction No 5")));
        service.AjouterTransaction(new Cloture(new Donnees(DateTime.Now, 0, Type.Debit, "Transaction No 6")));
        service.execute();

    }
}
