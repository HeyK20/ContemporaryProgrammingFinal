using System.ComponentModel.DataAnnotations;

namespace ContemporaryProgrammingFinal.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public string? MakeModel { get; set; }
        public string? TrimLevel { get; set; }
        public string? ManufacturerYear { get; set; }
        public string? Color { get; set; }

        public string? Type { get; set; }
        
    }
}