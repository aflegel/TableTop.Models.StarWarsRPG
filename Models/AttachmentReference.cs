using System;
using System.Collections.Generic;

namespace StarWarsRPG.Models
{
    public partial class AttachmentReference
    {
        public int AttachmentId { get; set; }
        public int BookId { get; set; }
        public int? Page { get; set; }
    }
}
