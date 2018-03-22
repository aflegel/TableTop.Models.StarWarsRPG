using System;
using System.Collections.Generic;

namespace StarWarsRPG.Models
{
    public partial class SkillReference
    {
        public int SkillId { get; set; }
        public int BookId { get; set; }
        public int? Page { get; set; }
    }
}
