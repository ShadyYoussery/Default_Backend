using System;
using Default_Backend.Entities.Entities.Base;

namespace Default_Backend.Entities.Entities.Business
{
    public class Attachment : BaseEntity<Guid>
    {
        public Guid FileId { get; set; }
        public string FileName { get; set; }
        public string Extension { get; set; }
        public string Size { get; set; }
        public bool IsPublic { get; set; }
        public string AttachmentDisplaySize { get; set; }
    }
}
