using System.ComponentModel.DataAnnotations;

namespace ContemporaryProgrammingFinal.Models
{
    public class TeamInfo
    {
        [Key]
        public int Id { get; set; }
        public string? FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string? CollegeProgram { get; set; }
        public string? YearInProgram { get; set; }
        public string? FavoriteSeason { get; set; }
    }
}
