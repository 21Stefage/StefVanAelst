using Festival.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Festival.ViewModel
{
    public class DetailsArtiestViewModel
    {
        public int ArtiestId { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Artiestnaam { get; set; }
        public int Leeftijd { get; set; }
        public int DagId { get; set; }
        [ForeignKey("DagId")]
        public Dag Dag { get; set; }
        public int GenreId { get; set; }
        [ForeignKey("GenreId")]
        public Genre Genre { get; set; }

        public int SongId { get; set; }
        [ForeignKey("SongId")]
        public ICollection<ArtiestSong> ArtiestSong { get; set; }

    }
}
