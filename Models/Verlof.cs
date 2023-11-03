using System.ComponentModel.DataAnnotations;
namespace GeoProfs.Models
{
    public class Verlof
    {
        public int Id { get; set; }
        public int WerknemerId { get; set; }
        public string? RedenVerlof { get; set; }

        public int VerlofurenGebruikt { get; set; }


        public int VerlofurenOver { get; set; }

        [DataType(DataType.Date)]
        public DateTime Datum { get; set; }
    }
}