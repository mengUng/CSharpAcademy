using System.Threading.Channels;

public class Credit : ITransaction
{
    private const double montantMax = 10000f;
    private Donnees _donnees;

    public Credit(Donnees donnees)
    {
        this._donnees = donnees;
    }
    public void Valider()
    {
        if (_donnees == null)
            throw new ArgumentNullException("La transaction n'est pas valide");



        if (_donnees.Montant <= montantMax)
        {
            Console.WriteLine("Credit - {0} est valide", _donnees.Description);
        }
        else
        { 
            Console.WriteLine("Credit - {0} n'est pas valide. Le montant de la transaction ne peut pas dépasser {1} Euros", _donnees.Description, montantMax);
        }

    }

    public Donnees GetDonnees()
    {
        return _donnees;
    }
}

