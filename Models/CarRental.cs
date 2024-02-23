using System.ComponentModel.DataAnnotations;
namespace GBC_Travel_Group23.Models
{
    public class CarRental : Service
    {
        [Required]
        public string CarBrand { get; set; }

        [Required]
        public string CarModel {  get; set; }

        [Required]
        public string CarYear { get; set; }

        [Required]
        public string TransmissionType { get; set; }

        [Required]
        public string FuelType { get; set; }

        [Required]
        public double DailyRate { get; set; }
    }
}
