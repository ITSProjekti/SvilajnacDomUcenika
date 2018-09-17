using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models.ModelResources
{
    public class VaspitnaGrupaResource
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public VaspitacResource Vaspitac { get; set; }

    }
}
