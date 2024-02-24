using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace GBC_Travel_Group23.Models
{
    public class RoomBooking
    {
        public int RoomBookingId { get; set; }
        public int HotelRoomId { get; set; }
        public HotelRoom HotelRoom { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        // Consider including a reference to the Client/Guest who made the booking.
        public int ClientId { get; set; }
        public Client Client { get; set; }

       

    }

}
