using System;
using System.Collections.Generic;

namespace StarWarsRPG.Models
{
    public partial class Species
    {
        public int SpeciesId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Brawn { get; set; }
        public int? Agility { get; set; }
        public int? Intellect { get; set; }
        public int? Cunning { get; set; }
        public int? Willpower { get; set; }
        public int? Presence { get; set; }
        public int? WoundThreshold { get; set; }
        public int? Experience { get; set; }
        public int? StrainThreshold { get; set; }
    }
}
