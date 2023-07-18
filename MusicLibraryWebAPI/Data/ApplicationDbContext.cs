using Microsoft.EntityFrameworkCore;
using MusicLibraryWebAPI.Models;

namespace MusicLibraryWebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        { 
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    Id = 1,
                    Title = "Across The Way",
                    Artist = "Hello Moto",
                    Album = "Sea Change",
                    ReleaseDate = DateTime.Now,
                    Genre = "rock"
                },
                new Song
                {
                    Id = 2,
                    Title = "Promise Broken",
                    Artist = "Journey",
                    Album = "World's Apart",
                    ReleaseDate = DateTime.Today,
                    Genre = "rock"

                }
                );
        }
    }
}
