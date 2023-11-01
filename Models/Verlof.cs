using System.ComponentModel.DataAnnotations;
namespace GeoProfs.Models
{
    public class Verlof
    {
        public int Id { get; set; }
        public int WerknemerId { get; set; }
        public string? RedenVerlof { get; set; }

        [DataType(DataType.Date)]
        public DateTime Datum { get; set; }
    }
}
