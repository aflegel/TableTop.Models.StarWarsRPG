using System;
using System.Collections.Generic;

namespace StarWarsRPG.Models
{
    public partial class TalentReference
    {
        public int TalentReferenceId { get; set; }
        public int BookId { get; set; }
        public int? Page { get; set; }
    }
}
