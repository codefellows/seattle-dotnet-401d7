using Microsoft.EntityFrameworkCore;
using MusicDemoAPI.Data;
using MusicDemoAPI.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MusicDemoAPI.Models.Service
{
    public class SongService : ISong
    {
        private MusicDbContext _context;

        public SongService(MusicDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get all songs from the database
        /// </summary>
        /// <returns>List of songs</returns>
        public IEnumerable<Song> GetAll()
        {
            // retrieve all of the songs in the songs database table
            return _context.Songs;
        }

        public async Task<Song> GetByID(int id)
        {
            Song song = await _context.Songs
                           .Include(s => s.Artist)
                           .FirstOrDefaultAsync(x => x.ID == id);
            return song;
        }

        public async Task AddSong(Song song)
        {
            _context.Songs.Add(song);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteSong(int id)
        {
            var song = await GetByID(id);
            _context.Songs.Remove(song);
            await _context.SaveChangesAsync();
        }



        public async Task UpdateSong(int id, Song song)
        {
            Song s = await GetByID(id);
            s.Title = song.Title;
            s.ArtistID = song.ArtistID;

            _context.Songs.Update(s);
            await _context.SaveChangesAsync();


        }
    }
}
