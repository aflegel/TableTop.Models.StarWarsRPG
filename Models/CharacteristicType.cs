using System;
using System.Collections.Generic;

namespace StarWarsRPG.Models
{
    public partial class CharacteristicType
    {
        public CharacteristicType()
        {
            Characteristic = new HashSet<Characteristic>();
        }

        public int CharacteristicTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<Characteristic> Characteristic { get; set; }
    }
}
