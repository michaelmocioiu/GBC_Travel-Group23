using System.ComponentModel.DataAnnotations;
namespace GBC_Travel_Group23.Models
{
    public class FlightCabin
    {
        public int Id { get; set; }
        [Required] public int FlightId { get;}
        [Required] public string CabinType { get; set; }
        [Required] public int MaxSeating { get; set; }
        [Required] public int AvailableSeating { get ; private set; }
        [Required] public double SeatPrice { get; set; }
        public FlightCabin()
        {
            AvailableSeating = MaxSeating;
        }
        public void BookSeat()
        {
            if (AvailableSeating > 0) AvailableSeating--;
        }
    }
}
