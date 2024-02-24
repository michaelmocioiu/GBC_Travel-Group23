using System.ComponentModel.DataAnnotations;
namespace GBC_Travel_Group23.Models
{
    public abstract class Service
    {
        public int ServiceId { get; set; }
        [Required] public string LocationCity { get; set; }
        [Required] public string LocationCountry { get; set; }
        [Required] public string ProviderName { get; set; }
        [Required] public string Description { get; set; }
        [DataType(DataType.Date)] public DateTime StartDate { get; set; }
        [DataType(DataType.Date)] public DateTime EndDate { get; set; }
    }
}
