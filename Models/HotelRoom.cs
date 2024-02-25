using System.ComponentModel.DataAnnotations;
namespace GBC_Travel_Group23.Models
{
    public class HotelRoom
    {
        public int Id { get; set; }
        [Required] public int RoomNumber { get; set; }
        [Required] public string[] Beds { get; set; }
        [Required] public int BathCount { get; set; }
        [Required] public int Capacity { get; set; }
        [Required] public string[] Amenities { get; set; }
        [Required] public double Rate { get; set; }
    }
}
