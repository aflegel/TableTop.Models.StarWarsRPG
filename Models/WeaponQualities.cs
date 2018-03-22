using System;
using System.Collections.Generic;

namespace StarWarsRPG.Models
{
    public partial class WeaponQualities
    {
        public int WeaponId { get; set; }
        public int QualityId { get; set; }
        public int? Quantity { get; set; }
    }
}
