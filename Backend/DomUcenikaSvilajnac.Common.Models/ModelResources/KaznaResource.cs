using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models.ModelResources
{
    public class KaznaResource
    {
        public int Id { get; set; }
        public string Opis { get; set; }
        public int BodoviKazne { get; set; }

        public int UcenikId { get; set; }
    }
}
