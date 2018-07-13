using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    /// <summary>
    /// Klasa Smer, pravi tabelu "Smerovi" u bazi podataka sa poljima koja su navedena kao property u datoj klasi.
    /// </summary>
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
