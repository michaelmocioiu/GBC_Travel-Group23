using System.ComponentModel.DataAnnotations;
namespace GBC_Travel_Group23.Models
{
    public class CarRental : Service
    {
        public int Id { get; set; }

        [Required] public string CarBrand { get; set; }

        [Required] public string CarModel {  get; set; }

        [Required] public string CarYear { get; set; }

        [Required] public double DailyRate { get; set; }
    }
}
