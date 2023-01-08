using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Festival.Models
{
    public class ArtiestSong
    {
        public int ArtiestId { get; set; }
        public Artiest Artiest { get; set; }
        public int SongId { get; set; }
        public Song Song { get; set; }
    }
}
