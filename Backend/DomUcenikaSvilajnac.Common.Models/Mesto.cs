using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    /// <summary>
    /// Klasa Mesto, pravi tabelu "Mesta" u bazi podataka sa poljima koja su navedena kao property u datoj klasi.
    /// </summary>
    [Table("Mesta")]
    public class Mesto
    {
        public int Id { get; set; }
        public string NazivMesta { get; set; }
        //Za spajanje dva puta na ucenika


        [InverseProperty("MestoRodjenja")]
        ICollection<Ucenik> MestaUcenika { get; set; }

        [InverseProperty("MestoPrebivalista")]
        ICollection<Ucenik> MestaPrebivalistaUcenika { get; set; }

        [InverseProperty("MestoZavrseneSkole")]
        ICollection<Ucenik> MestaZavrseneSkole { get; set; }
    }
}
