using System.ComponentModel.DataAnnotations;
namespace GBC_Travel_Group23.Models
{
    public class HotelRoom
    {
        [Key] public int Id { get; set; }
        [Required] public int HotelId { get; set; }
        [Required] public string RoomName { get; set; } = string.Empty;
        [Required] public int MaxOccupants { get; set; }
        [Required] public string[] Amenities { get; set; } = [];
        [Required] public int RoomCount { get; set; }
        [Required] public double Rate { get; set; }
    }
}
