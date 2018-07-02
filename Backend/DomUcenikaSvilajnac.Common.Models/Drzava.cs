using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    /// <summary>
    /// Klasa Drzava, pravi tabelu "Drzave" u bazi podataka sa poljima koja su navedena kao property u datoj klasi.
    /// </summary>
    [Table("Drzave")]
    public class Drzava
    {
        public int Id { get; set; }
        public string NazivDrzave { get; set; }

        ICollection<Ucenik> Ucenici { get; set; }

        public Drzava()
        {
            Ucenici = new Collection<Ucenik>();
        }


    }
}
