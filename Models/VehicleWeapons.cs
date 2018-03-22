using System;
using System.Collections.Generic;

namespace StarWarsRPG.Models
{
    public partial class VehicleWeapons
    {
        public int VehicleId { get; set; }
        public int WeaponId { get; set; }
        public int? Quantity { get; set; }
        public int? ArcTypeId { get; set; }
    }
}
