using Microsoft.EntityFrameworkCore;
using Mono.TextTemplating;
using System.ComponentModel.DataAnnotations;
namespace GBC_Travel_Group23.Models
{
    public class Hotel : Service
    {
        public int Id { get; set; }
        [Required] public string Country { get; set; }

        [Required] public string City { get; set; }

        [Required] public string Address { get; set; }

        [Required] public string[] Amenities { get; set; }
        [Required] public List<HotelRoom> Rooms { get; set; }
        public HotelRoom? GetPriciestRoom()
        {
            return Rooms
                .OrderByDescending(seat => seat.Rate)
                .FirstOrDefault();
        }

        public HotelRoom? GetCheapestRoom()
        {
            return Rooms
                .OrderBy(seat => seat.Rate)
                .FirstOrDefault();
        }
    }

    public class HotelRoom
    {
        [Required] public int RoomNumber { get; set; }
        [Required] public int BedCount { get; set; }
        [Required] public int BathCount { get; set; }
        [Required] public int Capacity { get; set; }//added capacity to the rooms
        [Required] public string[] Amenities { get; set; }
        [Required] public double Rate { get; set; }


        

    }
}
