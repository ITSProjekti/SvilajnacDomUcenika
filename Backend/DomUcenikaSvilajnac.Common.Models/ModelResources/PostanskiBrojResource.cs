using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models.ModelResources
{
    public class PostanskiBrojResource
    {
        public int Id { get; set; }
        public string Broj { get; set; }

        public int OpstinaId { get; set; }

    }
}
