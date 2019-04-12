using System.Collections.Generic;
using System.Threading.Tasks;

namespace MusicDemoAPI.Models.Interfaces
{
    public interface ISong
    {
        IEnumerable<Song> GetAll();
        Task<Song> GetByID(int id);

        Task AddSong(Song song);
        Task UpdateSong(int id, Song song);

        Task DeleteSong(int id);
    }
}
