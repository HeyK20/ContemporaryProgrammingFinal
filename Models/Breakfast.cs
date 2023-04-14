using System.ComponentModel.DataAnnotations;

namespace ContemporaryProgrammingFinal.Models
{
    public class Breakfast
    {
        [Key]
        public string? Name { get; set; }
        public string? Hot { get; set; }
        public string? Cold { get; set; }
        public string? Refridgerated { get; set; }
        public int Calories { get; set; }
        public int FatContent { get; set; }
    }
}

