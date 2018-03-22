using System;
using System.Collections.Generic;

namespace StarWarsRPG.Models
{
    public partial class Quality
    {
        public int QualityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? Passive { get; set; }
    }
}
