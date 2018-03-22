using System;
using System.Collections.Generic;

namespace StarWarsRPG.Models
{
    public partial class Weapon
    {
        public int WeaponId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? WeaponTypeId { get; set; }
        public int? SkillId { get; set; }
        public int? WeaponRangeId { get; set; }
        public int? Encumberance { get; set; }
        public int? HardPoints { get; set; }
        public int? Price { get; set; }
        public int? RarityId { get; set; }
        public int? CriticalRating { get; set; }
        public int? Damage { get; set; }
        public bool? Restricted { get; set; }
        public int? MinimumProfileId { get; set; }
        public int? MaximumProfileId { get; set; }
    }
}
