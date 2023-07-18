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
                    Genre = "Crunk"
                },
                new Song
                {
                    Id = 2,
                    Title = "Promise Broken",
                    Artist = "Journey",
                    Album = "World's Apart",
                    ReleaseDate = DateTime.Today,
                    Genre = "rock"

                },
                new Song
                {
                    Id = 3,
                    Title = "Paper Tiger",
                    Artist = "Beck",
                    Album = "Sea Change",
                    ReleaseDate = DateTime.Today,
                    Genre = "Alternative"
                }
                );
        }
    }
}
