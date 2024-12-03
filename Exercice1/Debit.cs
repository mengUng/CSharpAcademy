public class Debit : ITransaction
{
    private const double solde = -5000f;
    private Donnees _donnees;
    public Debit(Donnees donnees)
    {
        _donnees = donnees;
    }
    public void Valider()
    {
        if (_donnees == null)
            throw new ArgumentNullException("La transaction n'est pas valide");


        if (_donnees.Montant > solde)
        {
            Console.WriteLine("Debit - {0} est valide", _donnees.Description);
        }
        else
        {
            Console.WriteLine("Debit - {0} n'est pas valide. Le solde de la transaction ne peut être inférieur à {1}", _donnees.Description, solde);
        }
    }

    public Donnees GetDonnees()
    {
        return _donnees;
    }
}
