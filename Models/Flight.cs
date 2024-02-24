using Microsoft.Extensions.Primitives;
using System;
using System.ComponentModel.DataAnnotations;
namespace GBC_Travel_Group23.Models
{
    public class Flight : Service
    {
        [Required] public string DepartureAirportCode { get; set; }
        [Required] public string DepartureCity { get; set; }
        [Required] public string DepartureCountry { get; set; }
        [Required] public string ArrivalAirportCode { get; set; }
        [Required] public string ArrivalCity { get; set; }
        [Required] public string ArrivalCountry { get; set;}
        [Required] public List<FlightCabin> Cabins { get; set; }

        public int MaxSeating
        {
            get { return Cabins.Sum(cabin => cabin.MaxSeating); }
        }
        public int AvailableSeats
        {
            get { return Cabins.Sum(cabin => cabin.AvailableSeating); }
        }

        public void BookSeat(string type)
        {
            var targeCabin = Cabins.FirstOrDefault(cabin => cabin.CabinType == type);
            targeCabin?.BookSeat();
            //Safelycall BookSeat only if targetCabin is not null


            /*
            FlightCabin targetCabin = Cabins.FirstOrDefault(cabin => cabin.CabinType == type)!;

            if (targetCabin != null && targetCabin.AvailableSeating > 0)
            {
                targetCabin.BookSeat();
            }
            */
        }

    }
}
