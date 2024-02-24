using System.ComponentModel.DataAnnotations;

namespace GBC_Travel_Group23.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Required]public string FirstName { get; set; }
        [Required]public string LastName { get; set; }
        [EmailAddress]public string Email { get; set; }
        [Phone] public string Phone { get; set; }
    }
}
