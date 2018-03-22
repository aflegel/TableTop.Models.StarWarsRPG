using System;
using System.Collections.Generic;

namespace StarWarsRPG.Models
{
    public partial class Career
    {
        public Career()
        {
            CareerSpecialization = new HashSet<CareerSpecialization>();
        }

        public int CareerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? BookId { get; set; }
        public int? Page { get; set; }

        public ICollection<CareerSpecialization> CareerSpecialization { get; set; }
    }
}
