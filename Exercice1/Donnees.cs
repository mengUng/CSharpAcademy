public class Donnees
{
    public DateTime DateTransaction { get; set; }
    public float Montant { get; set; }
    public Type Type { get; set; }
    public string Description { get; set; }

    public Donnees(DateTime date, float montant, Type type, string description)
    {
        this.DateTransaction = date;
        this.Montant = montant;
        this.Type = type;
        this.Description = description;
    }
}
