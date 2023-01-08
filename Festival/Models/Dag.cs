using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Festival.Models
{
    public class Dag
    {
        public int DagId { get; set; }
        public string DagNaam { get; set; }
        public ICollection<Artiest> Artiesten { get; set; }
    }
}
