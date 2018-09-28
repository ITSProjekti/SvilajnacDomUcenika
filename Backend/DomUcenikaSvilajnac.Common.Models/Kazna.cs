using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    /// <summary>
    /// Klasa Kazna, pravi tabelu "Kazne" u bazi podataka sa poljima koja su navedena kao property u datoj klasi.
    /// </summary>
    [Table("Kazne")]
    public class Kazna
    {
        public int Id { get; set; }
        public string Opis { get; set; }
        public int UcenikId { get; set; }
        public int BodoviKazne { get; set; }
        public Ucenik Ucenik { get; set; }
        public DateTime VremeUpisa { get; set; }
    }
}
