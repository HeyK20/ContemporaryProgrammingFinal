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
                new TeamInfo { Id = 1, FullName = "Tom McReynolds", BirthDate = DateTime.Now, CollegeProgram = "Information Technology", FavoriteSeason = "Summer", YearInProgram = "Senior" },
                new TeamInfo { Id = 2, FullName = "Jackson Pinchot", BirthDate = DateTime.Now, CollegeProgram = "Information Technology", FavoriteSeason = "Winter", YearInProgram = "Sophomore" },
                new TeamInfo { Id = 3, FullName = "Audrey Perdew", BirthDate = DateTime.Now, CollegeProgram = "Software Development", FavoriteSeason = "Fall", YearInProgram = "Senior" });

            builder.Entity<Breakfast>().HasData(
                new Breakfast { Id = 1, Name = "Eggs", Hot = "y", Cold = "n", Refridgerated = "n", Calories = 60, FatContent = 5 });
                    
            builder.Entity<Game>().HasData(        
                new Game { Id = 1, Name = "Monikers", ReleaseYear = 2015, GameCategory = "Party", PlayerMinimum = 4,    
                    PlayerMaximum = 16, PlayTime = "30-60 Minutes", PlayerAges = "17+"},
                new Game { Id = 2, Name = "Cat in the Box", ReleaseYear = 2020, GameCategory = "Card", PlayerMinimum = 3, 
                    PlayerMaximum = 4, PlayTime = "30-45 Minutes", PlayerAges = "10+"},
                new Game { Id = 3, Name = "Splendor", ReleaseYear = 2014, GameCategory = "Board", PlayerMinimum = 2, 
                    PlayerMaximum = 4, PlayTime = "30 Minutes", PlayerAges = "10+"},
                new Game { Id = 4, Name = "Ark Nova", ReleaseYear = 2021, GameCategory = "Board", PlayerMinimum = 1, 
                    PlayerMaximum = 4, PlayTime = "90-150 Minutes", PlayerAges = "14+"},
                new Game { Id = 5, Name = "Werewords", ReleaseYear = 2017, GameCategory = "Party", PlayerMinimum = 4, 
                    PlayerMaximum = 10, PlayTime = "10 Minutes", PlayerAges = "8+"});
        }
        public DbSet<TeamInfo> Members { get; set; }
        public DbSet<Breakfast> Items { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}
