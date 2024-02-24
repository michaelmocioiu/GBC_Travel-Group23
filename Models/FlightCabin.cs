namespace GBC_Travel_Group23.Models
{
    public class FlightCabin
    {
        public string CabinType { get; set; }
        public int MaxSeating { get; set; }
        public int AvailableSeating { get; set; }
        public double SeatPrice { get; set; }
        public void BookSeat()
        {
            if (AvailableSeating > 0)AvailableSeating--;
        }
    }
}
