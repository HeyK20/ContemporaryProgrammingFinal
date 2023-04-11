using ContemporaryProgrammingFinal.Models;
using Microsoft.EntityFrameworkCore;

namespace ContemporaryProgrammingFinal.Data
{
    public class TeamInfoContext : DbContext
    {
        public TeamInfoContext(DbContextOptions<TeamInfoContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TeamInfo>().HasData(
                new TeamInfo { FullName = "Tom McReynolds", BirthDate = DateTime.Now, CollegeProgram = "Information Technology", FavoriteSeason = "Summer", YearInProgram = "Senior" });
        }
        public DbSet<TeamInfo> Members { get; set; }

    }
}
