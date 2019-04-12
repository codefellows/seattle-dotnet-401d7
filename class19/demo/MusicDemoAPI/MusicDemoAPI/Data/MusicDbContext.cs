using Microsoft.EntityFrameworkCore;
using MusicDemoAPI.Models;

namespace MusicDemoAPI.Data
{
    public class MusicDbContext : DbContext
    {
        public MusicDbContext(DbContextOptions<MusicDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Song>().HasData(
             new Song
             {
                 ID = 1,
                 Title = "Shake it Off",
                 ArtistID = 1,
             },
             new Song
             {
                 ID = 2,
                 Title = "Gorgeous",
                 ArtistID = 1
             },
             new Song
             {
                 ID = 3,
                 Title = "22",
                 ArtistID = 1
             },
             new Song
             {
                 ID = 4,
                 Title = "Thank You, Next",
                 ArtistID = 2
             },
             new Song
             {
                 ID = 5,
                 Title = "7 Rings",
                 ArtistID = 2
             }
             );
            modelBuilder.Entity<Artist>().HasData(
             new Artist
             {
                 ID = 1,
                 Name = "Taylor Swift"
             },
             new Artist
             {
                 ID = 2,
                 Name = "Arianna Grande"
             }
             );
        }

        public DbSet<Song> Songs { get; set; }
        public DbSet<Artist> Artists { get; set; }
    }
}
