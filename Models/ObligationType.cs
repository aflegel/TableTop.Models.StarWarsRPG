using System;
using System.Collections.Generic;

namespace StarWarsRPG.Models
{
    public partial class ObligationType
    {
        public ObligationType()
        {
            Obligation = new HashSet<Obligation>();
        }

        public int ObligationTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Obligation> Obligation { get; set; }
    }
}
