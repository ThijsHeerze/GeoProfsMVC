using System.ComponentModel.DataAnnotations;
namespace GeoProfs.Models
{

    public class VerlofManager
        {
        public int Id { get; set; }

        [Required]
        public string EmployeeName { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Required]
        public string Reason { get; set; }

        [Display(Name = "Manager Approval")]
        public bool IsApproved { get; set; }

        [Display(Name = "Manager Comments")]
        public string ManagerComments { get; set; }

    }
}