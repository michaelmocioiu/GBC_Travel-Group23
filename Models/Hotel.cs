using Mono.TextTemplating;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
namespace GBC_Travel_Group23.Models
{
    public class Hotel : Service
    {
        public int Id { get; set; }
        [Required] public string Name { get; set; }
        [Required] public string Country { get; set; }
        [Required] public string City { get; set; }
        [Required] public string Address { get; set; }
        [Required] public string[] Amenities { get; set; }
        [Required] public string RoomInfoJson { get; set; }
        public List<HotelRoom> Rooms
        {
            get { return JsonConvert.DeserializeObject<List<HotelRoom>>(RoomInfoJson)!; }
        }

        public string SerializeRoomInfo()
        {
            return JsonConvert.SerializeObject(Rooms);
        }
        public HotelRoom? GetPriciestAvailableRoom()
        {
            return Rooms
                .Where(room => room.IsAvailable)
                .OrderByDescending(seat => seat.NightlyRate)
                .FirstOrDefault();
        }

        public HotelRoom? GetCheapestAvailableRoom()
        {
            return Rooms
                .Where(room => room.IsAvailable)
                .OrderBy(seat => seat.NightlyRate)
                .FirstOrDefault();
        }
    }

    public class HotelRoom
    {
        public int RoomNumber { get; set; }
        [Required]
        public bool IsAvailable { get; set; }

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
