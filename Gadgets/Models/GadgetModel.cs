using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gadgets.Models
{
    public class GadgetModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string AppearsIn { get; set; }

        public string WithThisActor { get; set; }

        public GadgetModel()
        {
            Id = -1;
            Name
        }
    }
}