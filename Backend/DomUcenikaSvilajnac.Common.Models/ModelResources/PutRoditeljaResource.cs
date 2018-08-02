using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models.ModelResources
{
    public class PutRoditeljaResource
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int UcenikId { get; set; }
        public string BrojTelefona { get; set; }
        public int StepenObrazovanjaId { get; set; }

    }
}
