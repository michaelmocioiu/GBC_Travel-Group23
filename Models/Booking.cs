using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
namespace GBC_Travel_Group23.Models
{
    public abstract class Booking
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public class FlightBooking : Booking
    {
        public int TicketCount { get; set; }
        public int FlightId { get; set; }
        public int CabinId { get; set; }
    }

    public class CarRentalBooking : Booking
    {
        public CarRental CarRental { get; set; }

    }
}
