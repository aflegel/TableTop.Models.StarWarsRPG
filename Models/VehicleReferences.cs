using System;
using System.Collections.Generic;

namespace StarWarsRPG.Models
{
    public partial class VehicleReferences
    {
        public int VehicleId { get; set; }
        public int BookId { get; set; }
        public int? Page { get; set; }

        public Book Book { get; set; }
    }
}
