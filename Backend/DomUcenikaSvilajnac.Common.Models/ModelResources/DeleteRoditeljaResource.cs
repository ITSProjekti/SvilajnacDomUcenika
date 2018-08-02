using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models.ModelResources
{
    public class DeleteRoditeljaResource
    {

        public int IdMajke { get; set; }
        public int Id { get; set; }

        public string ImeOca { get; set; }
        public string PrezimeOca { get; set; }
        public string ImeMajke { get; set; }
        public string PrezimeMajke { get; set; }

        public string BrojTelefonaMajke { get; set; }
        public string BrojTelefonaOca { get; set; }

        public int UcenikId { get; set; }
    }
}
