using System;
using System.Collections.Generic;

namespace StarWarsRPG.Models
{
    public partial class Rarity
    {
        public int RarityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CostMultiplier { get; set; }
    }
}
