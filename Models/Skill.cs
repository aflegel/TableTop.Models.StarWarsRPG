using System;
using System.Collections.Generic;

namespace StarWarsRPG.Models
{
    public partial class Skill
    {
        public int SkillId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CharacteristicId { get; set; }
        public int? SkillTypeId { get; set; }

        public Characteristic Characteristic { get; set; }
    }
}
