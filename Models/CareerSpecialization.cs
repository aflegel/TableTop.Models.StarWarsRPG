using System;
using System.Collections.Generic;

namespace StarWarsRPG.Models
{
    public partial class CareerSpecialization
    {
        public CareerSpecialization()
        {
            CareerSpecializtionTalent = new HashSet<CareerSpecializtionTalent>();
        }

        public int CareerSpecializationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CareerId { get; set; }
        public int? BookId { get; set; }
        public int? Page { get; set; }

        public Career Career { get; set; }
        public ICollection<CareerSpecializtionTalent> CareerSpecializtionTalent { get; set; }
    }
}
