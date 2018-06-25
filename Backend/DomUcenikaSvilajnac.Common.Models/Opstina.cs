using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    [Table("Opstine")]
    public class Opstina
    {
        public int Id { get; set; }

        public string NazivOpstine { get; set; }

        ICollection<Ucenik> Ucenici { get; set; }
        public Opstina()
        {
            Ucenici = new Collection<Ucenik>();
        }
    }
}
