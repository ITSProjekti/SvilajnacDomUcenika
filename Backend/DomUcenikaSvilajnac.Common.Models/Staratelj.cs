using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    public class Staratelj
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public int UcenikId { get; set; }
        public Ucenik Ucenik { get; set; }


    }
}
