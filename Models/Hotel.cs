using Microsoft.EntityFrameworkCore;
using Mono.TextTemplating;
using System.ComponentModel.DataAnnotations;
namespace GBC_Travel_Group23.Models
{
    public class Hotel
    {
        [Key] public int Id { get; set; }
        [Required] public string Country { get; set; } = string.Empty;
        [Required] public string City { get; set; } = string.Empty;
        [Required] public string Address { get; set; } = string.Empty;
        [Required] public string[] Amenities { get; set; } = Array.Empty<string>();
    }
}
