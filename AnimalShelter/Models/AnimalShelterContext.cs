using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Animal>()
                .HasData(
                    new Animal { AnimalId = 1, Name = "Fifi", Species = "Mutt", Age = 3, Gender = "Female" },
                    new Animal { AnimalId = 2, Name = "Bobo", Species = "Lizard", Age = 1, Gender = "Unknown" },
                    new Animal { AnimalId = 3, Name = "Smol", Species = "Bunny", Age = 1, Gender = "Female" },
                    new Animal { AnimalId = 4, Name = "vSmol", Species = "Bunny", Age = 1, Gender = "Male" },
                    new Animal { AnimalId = 5, Name = "Gus", Species = "Bunny", Age = 22, Gender = "Male" }
                );
        }
        public DbSet<Animal> Animals { get; set; }
    }
}

//where we set up the database, and so where we can populate 