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
                new TeamInfo { Id = 1, FullName = "Tom McReynolds", BirthDate = DateTime.Now, CollegeProgram = "Information Technology", FavoriteSeason = "Summer", YearInProgram = "Senior" });

            builder.Entity<TeamInfo>().HasData(
                new TeamInfo { Id = 2, FullName = "Jackson Pinchot", BirthDate = DateTime.Parse("05142003"), CollegeProgram = "Information Technology", FavoriteSeason = "Winter", YearInProgram = "Sophomore" });

            builder.Entity<Breakfast>().HasData(
                new Breakfast { Id = 1, Name = "Eggs", Hot = "y", Cold = "n", Refridgerated = "n", Calories = 60, FatContent = 5 });
        }
        public DbSet<TeamInfo> Members { get; set; }
        public DbSet<Breakfast> Items { get; set; }
    }
}
