using Microsoft.AspNetCore.Mvc;
using MusicDemoAPI.Models;
using MusicDemoAPI.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicDemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistsController : ControllerBase
    {
        private readonly IArtist _artist;

        public ArtistsController(IArtist artist)
        {
            _artist = artist;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Artist>> Get()
        {
            return _artist.GetAll().ToList();

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Artist>> Get(int id)
        {
            Artist artist = await _artist.GetByID(id);
            if (artist == null)
            {
                return NotFound();
            }

            return Ok(artist);
        }


        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Artist artist)
        {
            if (artist.ID <= 0)
            {
                await _artist.AddArtist(artist);
            }
            else
            {
                await Put(artist.ID, artist);
            }

            return RedirectToAction("Get", new { id = artist.ID });

        }

        // Put
        [HttpPut]
        public async Task<IActionResult> Put(int id, [FromBody] Artist artist)
        {
            Artist art = await _artist.GetByID(id);
            if (art != null)
            {
                await _artist.UpdateArtist(id, art);
            }
            else
            {
                await Post(art);
            }
            return RedirectToAction("Get", new { id = art.ID });
        }

        // Delete
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _artist.DeleteArtist(id);
            return Ok();
        }


    }
}