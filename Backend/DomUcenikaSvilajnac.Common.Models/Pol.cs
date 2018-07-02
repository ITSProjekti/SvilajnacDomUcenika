using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    [Table("Polovi")]
    public class Pol
    {
        public int Id { get; set; }
        public string NazivPola { get; set; }
        ICollection<Ucenik> Ucenici { get; set; }

        public Pol()
        {
            Ucenici = new Collection<Ucenik>();
        }

    }
}
