namespace GeoProfs.Models
{
    public class FakeIdentity
    {
        public class Medewerker
        {
            public int MedewerkerId { get; set; }
            public string Naam { get; set; }
            public string Functie { get; set; }
        }

        public List<Medewerker> GetMedewerkers()
        {
            List<Medewerker> medewerkers = new List<Medewerker>
            {
                new Medewerker { MedewerkerId = 10, Naam = "Jan", Functie = "Manager" },
                new Medewerker { MedewerkerId = 11, Naam = "Piet", Functie = "Medewerker" },
                new Medewerker { MedewerkerId = 12, Naam = "Klaas", Functie = "Schoonmaker" },
                new Medewerker { MedewerkerId = 13, Naam = "Kees", Functie = "Schoonmaker" },
                new Medewerker { MedewerkerId = 14, Naam = "freek", Functie = "Manager" },
                new Medewerker { MedewerkerId = 15, Naam = "Joran", Functie = "Manager" },
                new Medewerker { MedewerkerId = 16, Naam = "Leon", Functie = "Manager" },
                new Medewerker { MedewerkerId = 17, Naam = "Milan", Functie = "Manager" }
            };

            return medewerkers;
        }
    }
}
