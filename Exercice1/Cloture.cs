public class Cloture : ITransaction
{
    private const double solde = 0f;
    private Donnees _donnees;

    public Cloture(Donnees donnees)
    {
        this._donnees = donnees;
    }
    public void Valider()
    {
        if (_donnees == null)
            throw new ArgumentNullException("La transaction n'est pas valide");


        if (_donnees.Montant == 0f)
        {
            Console.WriteLine("Cloture -  {0} est valide", _donnees.Description);
        }
        else
        {
            Console.WriteLine("Cloture - {0} n'est pas valide. Le solde doit être égal à {1} Euros", _donnees.Description, solde);
        }
    }

    public Donnees GetDonnees()
    {
        return _donnees;
    }
}

