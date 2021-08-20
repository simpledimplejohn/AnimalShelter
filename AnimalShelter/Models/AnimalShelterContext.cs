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
                    new Animal { AnimalId = 1, Name = "Fifi", Species = "Holland Lop", Age = 1, Gender = "Female" },
                    new Animal { AnimalId = 2, Name = "Bobo", Species = "Lizard", Age = 1, Gender = "Unknown" },
                    new Animal { AnimalId = 3, Name = "Smol", Species = "Holland Lop", Age = 1, Gender = "Female" },
                    new Animal { AnimalId = 4, Name = "vSmol", Species = "Holland Lop", Age = 1, Gender = "Male" },
                    new Animal { AnimalId = 5, Name = "Gus", Species = "Holland Lop", Age = 2, Gender = "Male" }
                    new Animal { AnimalId = 6, Name = "Commando", Species = "Holland Lop", Age = 3, Gender = "Female" },
                    new Animal { AnimalId = 7, Name = "Bubba", Species = "Lizard", Age = 1, Gender = "Unknown" },
                    new Animal { AnimalId = 8, Name = "The Onion", Species = "Bunny", Age = 1, Gender = "Female" },
                    new Animal { AnimalId = 9, Name = "Big Nose", Species = "Bunny", Age = 1, Gender = "Male" },
                    new Animal { AnimalId = 10, Name = "Hungry", Species = "Bunny", Age = 2, Gender = "Male" }
                    new Animal { AnimalId = 11, Name = "Muffin", Species = "Holland Lop", Age = 3, Gender = "Female" },
                    new Animal { AnimalId = 12, Name = "Dumbo", Species = "Holland Lop", Age = 1, Gender = "Unknown" },
                    new Animal { AnimalId = 13, Name = "Potato", Species = "Bunny", Age = 1, Gender = "Female" },
                    new Animal { AnimalId = 14, Name = "Matchstick", Species = "Bunny", Age = 1, Gender = "Unknown" },
                    new Animal { AnimalId = 15, Name = "Orion", Species = "Bunny", Age = 1, Gender = "Male" },
                    new Animal { AnimalId = 16, Name = "Peggy", Species = "Holland Lop", Age = 3, Gender = "Female" },
                    new Animal { AnimalId = 17, Name = "Herb", Species = "Holland Lop", Age = 1, Gender = "Unknown" },
                    new Animal { AnimalId = 18, Name = "Kevin", Species = "Bunny", Age = 1, Gender = "Male" },
                    new Animal { AnimalId = 19, Name = "Daniel", Species = "Bunny", Age = 1, Gender = "Male" },
                    new Animal { AnimalId = 20, Name = "Steve", Species = "Bunny", Age = 2, Gender = "Male" }
                );
        }
        public DbSet<Animal> Animals { get; set; }
    }
}

//where we set up the database, and so where we can populate 