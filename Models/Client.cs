using System.ComponentModel.DataAnnotations;

namespace GBC_Travel_Group23.Models
{
    public class Client
    {
        [Key] public int Id { get; set; }
        [Required] public string FullName { get; set; } = string.Empty;
        [EmailAddress] public string Email { get; set; } = string.Empty;
        [Phone] public string Phone { get; set; } = string.Empty;
    }
}
