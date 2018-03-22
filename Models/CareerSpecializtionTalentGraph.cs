using System;
using System.Collections.Generic;

namespace StarWarsRPG.Models
{
    public partial class CareerSpecializtionTalentGraph
    {
        public int ParentTalentId { get; set; }
        public int ChildTalentId { get; set; }

        public CareerSpecializtionTalent ChildTalent { get; set; }
        public CareerSpecializtionTalent ParentTalent { get; set; }
    }
}
