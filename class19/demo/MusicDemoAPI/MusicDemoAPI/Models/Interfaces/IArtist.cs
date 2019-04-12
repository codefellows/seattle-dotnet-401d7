using System.Collections.Generic;
using System.Threading.Tasks;

namespace MusicDemoAPI.Models.Interfaces
{
    public interface IArtist
    {
        IEnumerable<Artist> GetAll();
        Task<Artist> GetByID(int id);

        Task AddArtist(Artist artist);
        Task UpdateArtist(int id, Artist artist);

        Task DeleteArtist(int id);
    }
}
