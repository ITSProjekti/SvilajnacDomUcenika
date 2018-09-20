using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models.ModelResources
{
    public class SastanakResource
    {
        public int Id { get; set; }
        public int Dan { get; set; }
        public int Mesec { get; set; }
        public int Godina { get; set; }
        public int BrojPrisutnihUcenika { get; set; }
        public int UkupanBrojPrisutnihUcenika { get; set; }
        public GetSastanakVasptinaGrupaResource VaspitnaGrupa { get; set; }
    }
}
