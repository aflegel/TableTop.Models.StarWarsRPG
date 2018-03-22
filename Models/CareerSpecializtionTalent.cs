using System;
using System.Collections.Generic;

namespace StarWarsRPG.Models
{
    public partial class CareerSpecializtionTalent
    {
        public CareerSpecializtionTalent()
        {
            CareerSpecializtionTalentGraphChildTalent = new HashSet<CareerSpecializtionTalentGraph>();
            CareerSpecializtionTalentGraphParentTalent = new HashSet<CareerSpecializtionTalentGraph>();
        }

        public int CareerTalentId { get; set; }
        public int? CareerSpecializationId { get; set; }
        public int? Cost { get; set; }
        public int? TalentId { get; set; }

        public CareerSpecialization CareerSpecialization { get; set; }
        public ICollection<CareerSpecializtionTalentGraph> CareerSpecializtionTalentGraphChildTalent { get; set; }
        public ICollection<CareerSpecializtionTalentGraph> CareerSpecializtionTalentGraphParentTalent { get; set; }
    }
}
