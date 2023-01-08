using Festival.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Festival.ViewModel
{
    public class ArtiestListViewModel
    {
        
        public List<Artiest> Artiesten { get; set; }
        

        public string ArtiestSearch { get; set; }

        public string ArtiestGenre { get; set; }
        public string ArtiestDag { get; set; }
        public SelectList? Genres { get; set; }

        public int DagId { get; set; }
        [ForeignKey("DagId")]
        public Dag Dag { get; set; }
    }
}
