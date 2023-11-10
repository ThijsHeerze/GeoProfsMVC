namespace GeoProfs.Models
{
    public class User
    {
        //gemaakt door milan verwijder maar als het fuck met shit
        
        public string? Name { get; set; }
        public string? Department { get; set; }
        public bool Aanwezig { get; set; }

        List<User> userList = new List<User>
        {
            new User { Name = "John Doe", Department = "HR", Aanwezig = true },
            new User { Name = "Jane Smith", Department = "Finance", Aanwezig = false },
            new User { Name = "Bob Johnson", Department = "IT", Aanwezig = true },
            new User { Name = "Alice Brown", Department = "Marketing", Aanwezig = false },
            new User { Name = "Charlie Davis", Department = "Engineering", Aanwezig = true }
        };

    }
}
