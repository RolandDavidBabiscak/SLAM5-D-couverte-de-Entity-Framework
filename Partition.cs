public class Partition
{
    public int Numpart { get; set; }  // Clé primaire
    public string Libpart { get; set; }  // Libellé de la partition
    public decimal Prixpart { get; set; }  // Prix de la partition
    
    // Clé étrangère vers le style de musique
    public int? StyleID { get; set; }
    public Style Style { get; set; }  // Relation avec la table STYLE
}
