namespace GeoProfs.Models
{
    public class FakeIdentity
    {
        public class Medewerker
        {
            public int MedewerkerId { get; set; }
            public string Naam { get; set; }
            public string Functie { get; set; }
            public bool IsAfwezig { get; set; } // New property indicating whether the employee is absent or not
            public bool IsGoedgekeurd { get; set; } // New property indicating whether the absence is approved

            public void GoedkeurAfwezigheid()
            {
                // Logic to approve the absence
                IsGoedgekeurd = true;
            }
        }

        public List<Medewerker> GetMedewerkers()
        {
            List<Medewerker> medewerkers = new List<Medewerker>
            {
                new Medewerker { MedewerkerId = 10, Naam = "Jan", Functie = "Manager", IsAfwezig = false, IsGoedgekeurd = false },
                new Medewerker { MedewerkerId = 11, Naam = "Freek", Functie = "Medewerker", IsAfwezig = true, IsGoedgekeurd = false },
                new Medewerker { MedewerkerId = 12, Naam = "Klaas", Functie = "Schoonmaker", IsAfwezig = false, IsGoedgekeurd = false },
                new Medewerker { MedewerkerId = 13, Naam = "Kees", Functie = "Manager", IsAfwezig = true, IsGoedgekeurd = false },
                new Medewerker { MedewerkerId = 14, Naam = "Eva", Functie = "Medewerker", IsAfwezig = true, IsGoedgekeurd = false },
                new Medewerker { MedewerkerId = 15, Naam = "Lisa", Functie = "Medewerker", IsAfwezig = false, IsGoedgekeurd = false },
                new Medewerker { MedewerkerId = 16, Naam = "Fatima", Functie = "Schoonmaker", IsAfwezig = true, IsGoedgekeurd = false },
                new Medewerker { MedewerkerId = 17, Naam = "Anna", Functie = "Schoonmaker", IsAfwezig = false, IsGoedgekeurd = false },
            };

            return medewerkers;
        }
    }
}
