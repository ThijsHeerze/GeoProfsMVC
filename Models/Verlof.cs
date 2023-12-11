using GeoProfs.Models;
using System.ComponentModel.DataAnnotations;
namespace GeoProfs.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
    public class Verlof
    {
        public int VerlofId { get; set; }
        public int WerknemerId { get; set; }
        public string? RedenVerlof { get; set; }
        public string? Beschrijving { get; set; }
        public DateTime StartDatum { get; set; }
        public DateTime EindDatum { get; set; }
        public int Status { get; set; }
    }
