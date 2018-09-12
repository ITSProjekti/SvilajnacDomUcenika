using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    public class DrzavaKontinent
    {
        public int DrzavaId { get; set; }
        public int KontinentId { get; set; }
        public Drzava Drzava { get; set; }
        public Kontinent Kontinent { get; set; }
    }
}
