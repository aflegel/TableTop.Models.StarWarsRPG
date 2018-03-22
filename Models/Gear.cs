using System;
using System.Collections.Generic;

namespace StarWarsRPG.Models
{
    public partial class Gear
    {
        public int GearId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Price { get; set; }
        public int? Encumberance { get; set; }
        public int? RarityId { get; set; }
        public bool? Restricted { get; set; }
    }
}
