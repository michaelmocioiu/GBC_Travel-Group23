using System.ComponentModel.DataAnnotations;
namespace GBC_Travel_Group23.Models
{
    public class Hotel : Service
    {
        [Required]
        public int RoomCount { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string[] Amenities { get; set; }
        [Required]
        public List<HotelRoom> Rooms { get; set; }
        
    }

    public class HotelRoom
    {
        public int RoomNumber { get; set; }

        [Required]
        public int BedCount { get; set; }
        [Required]
        public int BathCount { get; set; }
        [Required]
        public string[] Amenities { get; set; }
        [Required]
        public double NightlyRate { get; set; }
    }
}
