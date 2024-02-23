using System.ComponentModel.DataAnnotations;
namespace GBC_Travel_Group23.Models
{
    public class Service
    {
        public int ServiceId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }
    }
}
