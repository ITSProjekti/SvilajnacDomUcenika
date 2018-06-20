using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    [Table("Mesta")]
    public class Mesto
    {
        public int Id { get; set; }
        
        public string Naziv { get; set; }

        ICollection<Ucenik>Ucenici { get; set; }

        public Mesto()
        {
            Ucenici = new Collection<Ucenik>();
        }
    }
}
