using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    /// <summary>
    /// Klasa Status prijave, pravi tabelu "StatusPrijave" u bazi podataka sa poljima koja su navedena kao property u datoj klasi.
    /// </summary>
    [Table("StatusiPrijave")]
    public class StatusPrijave
    {
        public int Id { get; set; }
        public string Status { get; set; }

        ICollection<Ucenik> Ucenici { get; set; }

        public StatusPrijave()
        {
            Ucenici = new Collection<Ucenik>();
        }
    }
}
