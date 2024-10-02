public class Commande
{
    public int Numcde { get; set; }  // Clé primaire
    public decimal Montantcde { get; set; }  // Montant de la commande
    public DateTime Datecde { get; set; }  // Date de la commande

    // Clé étrangère vers le client
    public int Numcli { get; set; }
    public Client Client { get; set; }  // Relation avec la table CLIENT
    
    // Propriété de navigation pour les partitions
    public ICollection<Partition> Partitions { get; set; }
}
