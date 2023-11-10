using GeoProfs.Models;
using System.ComponentModel.DataAnnotations;
namespace GeoProfs.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
    public class Verlof
    {
        public int Id { get; set; }
        public int WerknemerId { get; set; }
        public int ManagerId { get; set; }
        public string? RedenVerlof { get; set; }
        public int UrenGebruikt { get; set; }
        public int UrenOver { get; set; }
        public int Afdeling { get; set; }

        [Display(Name = "Datum")]
        [DataType(DataType.Date)]
        public DateTime Datum { get; set; }

        [Column(TypeName = "Naam")] 
        public string Naam { get; set; }
    }