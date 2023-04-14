using ContemporaryProgrammingFinal.Models;
using Microsoft.EntityFrameworkCore;

namespace ContemporaryProgrammingFinal.Data
{
    public class BreakfastInfoContext : DbContext
    {
        public BreakfastInfoContext(DbContextOptions<BreakfastInfoContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Breakfast>().HasData(
                new Breakfast { Name = "Eggs", Hot = "y", Cold = "n", Refridgerated = "n", Calories = 60 , FatContent = 5 });
        }
        public DbSet<Breakfast> Members { get; set; }

    }
}
