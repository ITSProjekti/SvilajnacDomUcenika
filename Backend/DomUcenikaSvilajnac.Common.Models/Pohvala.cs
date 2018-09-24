using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    /// <summary>
    /// Klasa Pohvala, pravi tabelu "Pohvale" u bazi podataka sa poljima koja su navedena kao property u datoj klasi.
    /// </summary>
    [Table("Pohvale")]
    public class Pohvala
    {
        public int Id { get; set; }
        public string Opis { get; set; }
        public int UcenikId { get; set; }
        public int BodoviPohvale { get; set; }
        public Ucenik Ucenik { get; set; }
    }
}
