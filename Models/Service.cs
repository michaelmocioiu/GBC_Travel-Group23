using System.ComponentModel.DataAnnotations;
namespace GBC_Travel_Group23.Models
{
    public abstract class Service
    {
        public int Id { get; set; }
        [Required] public string LocationCity { get; set; }
        [Required] public string LocationCountry { get; set; }
        [Required] public string ProviderName { get; set; }
        [Required] public string Description { get; set; }
    }
}
