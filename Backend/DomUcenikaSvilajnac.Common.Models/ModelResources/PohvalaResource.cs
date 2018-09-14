using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models.ModelResources
{
    public class PohvalaResource
    {
        public int Id { get; set; }
        public string Opis { get; set; }
        public int UcenikId { get; set; }

        public int BodoviPohvale { get; set; }
    }
}
