namespace GeoProfs.Models
{
    public class FakeIdentity
    {
        public class Medewerker
        {
            public int MedewerkerId { get; set; }
            public string Naam { get; set; }
            public string Functie { get; set; }
            public bool IsAfwezig { get; set; } 
        }

        public List<Medewerker> GetMedewerkers()
        {
            List<Medewerker> medewerkers = new List<Medewerker>
            {
                new Medewerker { MedewerkerId = 10, Naam = "Jan", Functie = "Manager", IsAfwezig = false },
                new Medewerker { MedewerkerId = 11, Naam = "Piet", Functie = "Medewerker", IsAfwezig = true },
                new Medewerker { MedewerkerId = 12, Naam = "Klaas", Functie = "Schoonmaker", IsAfwezig = false },
                new Medewerker { MedewerkerId = 13, Naam = "Kees", Functie = "Schoonmaker", IsAfwezig = true },
                new Medewerker { MedewerkerId = 14, Naam = "Eva", Functie = "Manager", IsAfwezig = true },
                new Medewerker { MedewerkerId = 15, Naam = "Lisa", Functie = "Medewerker", IsAfwezig = false },
                new Medewerker { MedewerkerId = 16, Naam = "Tom", Functie = "Schoonmaker", IsAfwezig = true },
                new Medewerker { MedewerkerId = 17, Naam = "Anna", Functie = "Schoonmaker", IsAfwezig = false },
            };

            return medewerkers;
        }
    }
}
