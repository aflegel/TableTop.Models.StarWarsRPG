using System;
using System.Collections.Generic;

namespace StarWarsRPG.Models
{
    public partial class VehicleDocks
    {
        public int VehicleId { get; set; }
        public int VehicleDockId { get; set; }
        public int? Quantity { get; set; }
    }
}
