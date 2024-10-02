public class Client
{
    public int Numcli { get; set; }  // Clé primaire
    public string Nomcli { get; set; }  // Nom du client
    public string Prenomcli { get; set; }  // Prénom du client
    public string Adressecli { get; set; }  // Adresse
    public string Tel { get; set; }  // Téléphone (champ ajouté)
    
    // Propriété de navigation pour les commandes associées
    public ICollection<Commande> Commandes { get; set; }
}
