using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Festival.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        public string GenreNaam { get; set; }
        public ICollection<Artiest> Artiesten { get; set; }
    }
}
