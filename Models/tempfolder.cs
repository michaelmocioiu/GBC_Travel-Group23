using GBC_Travel_Group23.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace GBC_Travel_Group23.Models
{
    public class tempfolder
    {
        public double TotalPrice
        {
            get {
                int nightcount = (int)(EndDate - StartDate).TotalDays + (EndDate.TimeOfDay < StartDate.TimeOfDay ? 1 : 0);
                return Math.Round(nightcount * HotelRoom.Rate, 2); 
            }
        }
       


    }
 /*   public class RoomBookingService
    {
        private readonly AppDbContext _context;

        public RoomBookingService(AppDbContext context)
        {
            _context = context;
        }

        public bool IsRoomAvailable(int hotelRoomId, DateTime desiredStartDate, DateTime desiredEndDate)
        {
            var overlappingBookings = _context.RoomBookings
                .Where(rb => rb.HotelRoomId == hotelRoomId &&
                             rb.EndDate >= desiredStartDate &&
                             rb.StartDate <= desiredEndDate)
                .ToList();

            return !overlappingBookings.Any(); // If there are no overlapping bookings, the room is available.
        }

        // Method to book a room, ensuring no overlap and room is available.
        public bool TryBookRoom(int hotelRoomId, DateTime desiredStartDate, DateTime desiredEndDate, int clientId)
        {
            if (IsRoomAvailable(hotelRoomId, desiredStartDate, desiredEndDate))
            {
                var booking = new tempfolder
                {
                    HotelRoomId = hotelRoomId,
                    StartDate = desiredStartDate,
                    EndDate = desiredEndDate,
                    ClientId = clientId
                    // Ensure you have a valid ClientId
                };

                _context.RoomBookings.Add(booking);
                _context.SaveChanges();
                return true;
            }

            return false;
        }
    } */
    public class BookingManager
    {
        public List<Booking> Bookings { get; set; }
        
    }
}
