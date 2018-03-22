using System;
using System.Collections.Generic;

namespace StarWarsRPG.Models
{
    public partial class Attachment
    {
        public Attachment()
        {
            AttachmentModification = new HashSet<AttachmentModification>();
        }

        public int GearAttachmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? GearAttachmentTypeId { get; set; }
        public int? Price { get; set; }
        public int? Encumberance { get; set; }
        public int? HardPointRequirement { get; set; }
        public int? RarityId { get; set; }
        public bool? Restricted { get; set; }
        public int? MinimumProfileId { get; set; }
        public int? MaximumProfileId { get; set; }

        public ICollection<AttachmentModification> AttachmentModification { get; set; }
    }
}
