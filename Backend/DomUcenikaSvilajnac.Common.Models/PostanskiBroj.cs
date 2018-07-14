using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    /// <summary>
    /// Klasa PostanskiBroj, pravi tabelu "PostanskiBrojevi" u bazi podataka sa poljima koja su navedena kao property u datoj klasi.
    /// </summary>
    [Table("PostanskiBrojevi")]
    public class PostanskiBroj
    {
        public int Id { get; set; }
        public string Broj { get; set; }
        public int OpstinaId { get; set; }

        ICollection<Ucenik> Ucenici { get; set; }

        public PostanskiBroj()
        {
            Ucenici = new Collection<Ucenik>();
        }
    }
}
