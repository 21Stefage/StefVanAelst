using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Festival.Models
{
    public class Song
    {
        public int SongId { get; set; }
        public string Naam { get; set; }
        public int AantalStreams { get; set; }
        public Genre Genre { get; set; }
        public ICollection<ArtiestSong> ArtiestSongs { get; set; }
    }
}
