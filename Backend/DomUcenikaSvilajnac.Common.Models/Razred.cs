using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    /// <summary>
    /// Klasa Razred, pravi tabelu "Razredi" u bazi podataka sa poljima koja su navedena kao property u datoj klasi.
    /// </summary>
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
