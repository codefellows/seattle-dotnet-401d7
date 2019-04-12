using Microsoft.AspNetCore.Mvc;
using MusicDemoAPI.Models;
using MusicDemoAPI.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicDemoAPI.Controllers
{
    // Customize your route
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private readonly ISong _song;

        public SongsController(ISong song)
        {
            _song = song;
        }

        // Get
        [HttpGet]
        public ActionResult<IEnumerable<Song>> Get()
        {
            return _song.GetAll().ToList();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            Song song = await _song.GetByID(id);
            if (song == null)
            {
                return NotFound();
            }

            return Ok(song);
        }



        // Put
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Song song)
        {
            Song ss = await _song.GetByID(id);
            if (song != null)
            {
                await _song.UpdateSong(id, song);
            }
            else
            {
                Post(song);
            }
            return RedirectToAction("Get", new { id = song.ID });
        }


        // Post
        [HttpPost]
        public ActionResult Post([FromBody]Song song)
        {
            if (song.ID <= 0)
            {
                _song.AddSong(song);
            }

            return RedirectToAction("Get", new { id = song.ID });

        }

        // Delete
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _song.DeleteSong(id);
            return Ok();
        }
    }
}