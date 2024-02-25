using System.ComponentModel.DataAnnotations;
namespace GBC_Travel_Group23.Models
{
    public class Flight : Service
    {
        public string Manufacturer { get; set; }
        public string Make { get; set; }
        [Required] public string DepartureAirportCode { get; set; }
        [Required] public string DepartureCity { get; set; }
        [Required] public string DepartureCountry { get; set; }
        [Required] public string ArrivalAirportCode { get; set; }
        [Required] public string ArrivalCity { get; set; }
        [Required] public string ArrivalCountry { get; set; }
        [Required] public List<FlightCabin> Cabins { get; set; }
        public int TotalSeats
        {
            get { return Cabins.Sum(cabin => cabin.MaxSeating); }
        }
    }
}
