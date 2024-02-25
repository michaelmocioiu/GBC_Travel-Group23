using Microsoft.EntityFrameworkCore;
using Mono.TextTemplating;
using System.ComponentModel.DataAnnotations;
namespace GBC_Travel_Group23.Models
{
    public class Hotel : Service
    {
        [Required] public string Country { get; set; } = string.Empty;
        [Required] public string City { get; set; } = string.Empty;
        [Required] public string Address { get; set; } = string.Empty;
        [Required] public string[] Amenities { get; set; } = Array.Empty<string>();
        [Required] public List<HotelRoom> Rooms { get; set; } = new List<HotelRoom>();
        public HotelRoom GetPriciestRoom()
        {
            if (Rooms != null && Rooms.Any())
            {
                return Rooms
                .OrderByDescending(seat => seat.Rate)
                .First();
            }
            throw new InvalidOperationException("Hotel has no rooms");
        }

        public HotelRoom GetCheapestRoom()
        {
            if (Rooms != null && Rooms.Any())
            {
                return Rooms
                .OrderBy(seat => seat.Rate)
                .First();
            }
            throw new InvalidOperationException("Hotel has no rooms");
        }
    }
}
