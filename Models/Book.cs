using System;
using System.Collections.Generic;

namespace StarWarsRPG.Models
{
    public partial class Book
    {
        public Book()
        {
            ArmorReference = new HashSet<ArmorReference>();
            GearAttachmentReference = new HashSet<GearAttachmentReference>();
            GearQualityReference = new HashSet<GearQualityReference>();
            GearReference = new HashSet<GearReference>();
            SpeciesReference = new HashSet<SpeciesReference>();
            VehicleReferences = new HashSet<VehicleReferences>();
            WeaponReferences = new HashSet<WeaponReferences>();
        }

        public int BookId { get; set; }
        public string Name { get; set; }

        public ICollection<ArmorReference> ArmorReference { get; set; }
        public ICollection<GearAttachmentReference> GearAttachmentReference { get; set; }
        public ICollection<GearQualityReference> GearQualityReference { get; set; }
        public ICollection<GearReference> GearReference { get; set; }
        public ICollection<SpeciesReference> SpeciesReference { get; set; }
        public ICollection<VehicleReferences> VehicleReferences { get; set; }
        public ICollection<WeaponReferences> WeaponReferences { get; set; }
    }
}
