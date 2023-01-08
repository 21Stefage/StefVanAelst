using Festival.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Festival.ViewModel
{
    public class DeleteArtiestViewModel
    {
        public int ArtiestId { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Artiestnaam { get; set; }
        public int Leeftijd { get; set; }
        public Dag Dag { get; set; }
        public Genre Genre { get; set; }
    }
}
