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
                new TeamInfo { Id = 1, FullName = "Tom McReynolds", BirthDate = Convert.ToDateTime("06/01/2000"), CollegeProgram = "Information Technology", FavoriteSeason = "Summer", YearInProgram = "Senior" },
                new TeamInfo { Id = 2, FullName = "Jackson Pinchot", BirthDate = Convert.ToDateTime("05/14/2003"), CollegeProgram = "Information Technology", FavoriteSeason = "Winter", YearInProgram = "Sophomore" },
                new TeamInfo { Id = 3, FullName = "Audrey Perdew", BirthDate = Convert.ToDateTime("04/29/1992"), CollegeProgram = "Software Development", FavoriteSeason = "Fall", YearInProgram = "Senior" },
                 new TeamInfo { Id = 4, FullName = "Anna Finkelman", BirthDate = Convert.ToDateTime("05/30/1986"), CollegeProgram = "Information Technology", FavoriteSeason = "Summer", YearInProgram = "Sophmore" });

            builder.Entity<TeamInfo>().HasData(
                new TeamInfo { Id = 2, FullName = "Jackson Pinchot", BirthDate = DateTime.Parse("05142003"), CollegeProgram = "Information Technology", FavoriteSeason = "Winter", YearInProgram = "Sophomore" });

            builder.Entity<Breakfast>().HasData(

                new Breakfast { Id = 1, Name = "Eggs", Hot = "y", Cold = "n", Refridgerated = "n", Calories = 60, FatContent = 5 },
                new Breakfast { Id = 2, Name = "Pancakes", Hot = "y", Cold = "n", Refridgerated = "n", Calories = 100, FatContent = 4 },
                new Breakfast { Id = 3, Name = "Bacon", Hot = "y", Cold = "n", Refridgerated = "n", Calories = 70, FatContent = 7 },
                new Breakfast { Id = 4, Name = "Cereal", Hot = "n", Cold = "y", Refridgerated = "n", Calories = 150, FatContent = 3 },
                new Breakfast { Id = 5, Name = "Sausage", Hot = "y", Cold = "n", Refridgerated = "n", Calories = 85, FatContent = 4 });

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
