using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models.ModelResources
{
    /// <summary>
    /// Sluzi za put(update) majke, salju se podaci koji su navedeni ispod.
    /// </summary>
    public class MajkaResource
    {
        public int IdMajke { get; set; }
        public int Id { get; set; }

        public string ImeOca { get; set; }
        public string PrezimeOca { get; set; }
        public string ImeMajke { get; set; }
        public string PrezimeMajke { get; set; }
        public int StrucnaSpremaMajkeId { get; set; }
        public int StrucnaSpremaOcaId { get; set; }

        public string BrojTelefonaMajke { get; set; }
        public string BrojTelefonaOca { get; set; }

        public int UcenikId { get; set; }
    }
}
