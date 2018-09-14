using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    public class Pohvala
    {
        public int Id { get; set; }
        public string Opis { get; set; }
        public int UcenikId { get; set; }
        public int BodoviPohvale { get; set; }
        public Ucenik Ucenik { get; set; }
    }
}
