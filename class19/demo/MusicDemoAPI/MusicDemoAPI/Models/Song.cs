using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicDemoAPI.Models
{
    public class Song
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int ArtistID { get; set; }

        public Artist Artist { get; set; }
    }
}
