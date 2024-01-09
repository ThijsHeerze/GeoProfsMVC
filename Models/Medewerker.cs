namespace GeoProfs.Models
{
    public class Medewerker
    {
        public int MedewerkerId { get; set; }
        public int AfdelingId { get; set; }
        public string? Naam { get; set; }
        public string? Functie { get; set; }
    }
}