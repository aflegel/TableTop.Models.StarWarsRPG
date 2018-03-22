using System;
using System.Collections.Generic;

namespace StarWarsRPG.Models
{
    public partial class AttachmentModification
    {
        public int AttachmentModificationId { get; set; }
        public int? AttachmentId { get; set; }
        public int? Quantity { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Attachment Attachment { get; set; }
    }
}
