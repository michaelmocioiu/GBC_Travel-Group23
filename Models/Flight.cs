using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GBC_Travel_Group23.Models
{
    public class Flight
    {
        [Key] public int Id { get; set; }
        [Required] public string Airline { get; set; } = string.Empty;
        [Required] public string Plane { get; set; } = string.Empty;
        [Required] public string FlightCode { get; set; } = string.Empty;
        [Required] public string DepartureAirportCode { get; set; } = string.Empty;
        [Required] public string DepartureCity { get; set; } = string.Empty;
        [Required] public string DepartureCountry { get; set; } = string.Empty;
        [Required] public DateTime DepartureDate { get; set; }
        [Required] public string ArrivalAirportCode { get; set; } = string.Empty;
        [Required] public string ArrivalCity { get; set; } = string.Empty;
        [Required] public string ArrivalCountry { get; set; } = string.Empty;
        [Required] public DateTime ArrivalDate { get; set; }
        [Required] public int TotalSeats { get; set; }
        [Required] public double Price { get; set; }

        [InverseProperty("Flight")]
        public ICollection<Booking>? Bookings { get; set; }
    }
}
