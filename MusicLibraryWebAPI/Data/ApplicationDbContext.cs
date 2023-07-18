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
                   Id = 13,
                    Title = "Across The Way",
                    Artist = "Hello Moto",
                    Album = "Sea Change",
                    ReleaseDate = DateTime.Now,
                    Genre = "Crunk"
                },
                new Song
                {
                   Id = 12,
                    Title = "Promise Broken",
                    Artist = "Journey",
                    Album = "World's Apart",
                    ReleaseDate = DateTime.Today,
                    Genre = "rock"

                },
                new Song
                {
                   Id = 11,
                    Title = "Paper Tiger",
                    Artist = "Beck",
                    Album = "Falacy",
                    ReleaseDate = DateTime.Today,
                    Genre = "Alternative"
                }
                );
        }
    }
}
