using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    [Table("Razredi")]
    public class Razred
    {
        public int Id { get; set; }
        public string BrojRazreda { get; set; }

        ICollection<Ucenik> Ucenici { get; set; }

        public Razred()
        {
            Ucenici = new Collection<Ucenik>();
        }
    }
}
