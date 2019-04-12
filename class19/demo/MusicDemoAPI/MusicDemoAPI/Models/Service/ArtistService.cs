using MusicDemoAPI.Data;
using MusicDemoAPI.Models.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MusicDemoAPI.Models.Service
{
    public class ArtistService : IArtist
    {
        private readonly MusicDbContext _context;

        public ArtistService(MusicDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Artist> GetAll()
        {
            return _context.Artists;
        }

        public async Task<Artist> GetByID(int id)
        {
            Artist artist = await _context.Artists.FindAsync(id);
            return artist;


        }

        public async Task AddArtist(Artist artist)
        {
            _context.Artists.Add(artist);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteArtist(int id)
        {
            var artist = await GetByID(id);
            _context.Artists.Remove(artist);
            await _context.SaveChangesAsync();
        }


        public async Task UpdateArtist(int id, Artist artist)
        {
            // Get the artist
            Artist art = await GetByID(id);
            art.Name = artist.Name;
            art.ID = id;

            _context.Artists.Update(art);
            await _context.SaveChangesAsync();
        }
    }
}

