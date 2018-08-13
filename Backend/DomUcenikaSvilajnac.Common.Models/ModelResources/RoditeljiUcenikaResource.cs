using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models.ModelResources
{
    /// <summary>
    /// Sluzi za prikazivanje samo jednog dela podataka o roditelju ucenika. Podaci koji se prikazuju navedeni su ispod u klasi.
    /// </summary>
    public class RoditeljiUcenikaResource
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojTelefona { get; set; }
        public int StepenObrazovanjaId { get; set; }
    }
}
