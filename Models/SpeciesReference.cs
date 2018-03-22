using System;
using System.Collections.Generic;

namespace StarWarsRPG.Models
{
    public partial class SpeciesReference
    {
        public int SpeciesId { get; set; }
        public int BookId { get; set; }
        public int? Page { get; set; }

        public Book Book { get; set; }
    }
}
