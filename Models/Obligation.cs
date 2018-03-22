using System;
using System.Collections.Generic;

namespace StarWarsRPG.Models
{
    public partial class Obligation
    {
        public int ObligationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ObligationTypeId { get; set; }

        public ObligationType ObligationType { get; set; }
    }
}
