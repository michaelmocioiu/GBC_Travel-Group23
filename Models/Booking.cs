using System;
using System.ComponentModel.DataAnnotations;
namespace GBC_Travel_Group23.Models
{
    public class Booking
    {
        public int BookingId { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public Service Service { get; set; }
    }
}
