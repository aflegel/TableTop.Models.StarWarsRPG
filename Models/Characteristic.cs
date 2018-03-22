using System;
using System.Collections.Generic;

namespace StarWarsRPG.Models
{
    public partial class Characteristic
    {
        public Characteristic()
        {
            Skill = new HashSet<Skill>();
        }

        public int CharacteristicId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CharacteristicTypeId { get; set; }

        public CharacteristicType CharacteristicType { get; set; }
        public ICollection<Skill> Skill { get; set; }
    }
}
