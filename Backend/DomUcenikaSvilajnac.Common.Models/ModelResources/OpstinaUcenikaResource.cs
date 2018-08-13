using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models.ModelResources
{
    /// <summary>
    /// Sluzi za prikazivanje samo jednog dela podataka o opstini ucenika. Podaci koji se prikazuju navedeni su ispod u klasi.
    /// </summary>
    public class OpstinaUcenikaResource
    {
        public int Id { get; set; }

        public string NazivOpstine { get; set; }
    }
}
