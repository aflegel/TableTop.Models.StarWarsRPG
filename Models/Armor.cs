using System;
using System.Collections.Generic;

namespace StarWarsRPG.Models
{
    public partial class Armor
    {
        public int ArmorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Defense { get; set; }
        public int? Soak { get; set; }
        public int? Price { get; set; }
        public int? Encumberance { get; set; }
        public int? HardPoints { get; set; }
        public int? RarityId { get; set; }
        public int? ArmorTypeId { get; set; }
        public bool? Restricted { get; set; }
    }
}
