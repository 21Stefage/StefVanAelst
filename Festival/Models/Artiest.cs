using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Festival.Models
{
    public class Artiest
    {
        [Key]
        public int ArtiestId { get; set; }

        [Required(ErrorMessage = "Het veld 'Voornaam' moet altijd ingevuld zijn.")]
        public string Voornaam { get; set; }

        [Required(ErrorMessage = "Het veld 'Achternaam' moet altijd ingevuld zijn.")]
        public string Achternaam { get; set; }
        [Required(ErrorMessage = "Het veld 'Artiestnaam' moet altijd ingevuld zijn.")]
        public string Artiestnaam { get; set; }
        [Required(ErrorMessage = "Het veld 'Leeftijd' moet altijd ingevuld zijn.")]
        public int Leeftijd { get; set; }

        [Required(ErrorMessage = "Het veld 'Dag' moet altijd ingevuld zijn.")]
        public int DagId { get; set; }
        [ForeignKey("DagId")]
        
        public Dag Dag { get; set; }
        [Required(ErrorMessage = "Het veld 'Genre' moet altijd ingevuld zijn.")]
        public int GenreId { get; set; }
        [ForeignKey("GenreId")]
        
        public Genre Genre { get; set; }
        public ICollection<ArtiestSong> ArtiestSongs { get; set; }
    }
}
