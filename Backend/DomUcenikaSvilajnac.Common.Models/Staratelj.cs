using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    /// <summary>
    /// Klasa Staratelj, pravi tabelu "Staratelji" u bazi podataka sa poljima koja su navedena kao property u datoj klasi.
    /// </summary>
    [Table("Staratelji")]
    public class Staratelj
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public int UcenikId { get; set; }
        public Ucenik Ucenik { get; set; }


    }
}
