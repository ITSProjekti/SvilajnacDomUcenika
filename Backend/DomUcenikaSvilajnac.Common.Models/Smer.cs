using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    [Table("Smerovi")]
    public class Smer
    {
        public int Id { get; set; }
        public string NazivSmera { get; set; }

        ICollection<Ucenik> Ucenici { get; set; }

        public Smer()
        {
            Ucenici = new Collection<Ucenik>();
        }

    }
}
