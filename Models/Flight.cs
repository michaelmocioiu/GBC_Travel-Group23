using System;
using System.ComponentModel.DataAnnotations;
namespace GBC_Travel_Group23.Models
{
    public class Flight : Service
    {
        [Required]
        public string DepartureCity { get; set; }

        [Required]
        public string ArrivalCity { get; set; }

        [Required]
        public List<FlightSeat> Seats { get; set; }

        public FlightSeat? GetPriciestAvailableSeat()
        {
            return Seats
                .Where(seat => seat.IsAvailable)
                .OrderByDescending(seat => seat.Price)
                .FirstOrDefault();
        }

        public FlightSeat? GetCheapestAvailableSeat()
        {
            return Seats
                .Where(seat => seat.IsAvailable)
                .OrderBy(seat => seat.Price)
                .FirstOrDefault();
        }

    }

    public class FlightSeat
    {
        public int SeatNumber { get; set; }
        public string SeatClass { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
    }
}
