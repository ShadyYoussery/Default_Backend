using System;
using Default_Backend.Common.Core;

namespace Default_Backend.Common.DTO.Common.File
{
    public class FileDto :  IEntityDto<Guid?>
    {
        public Guid? Id { get; set; }
        public string Url { private get; set; }
        public string FileSize { get; set; }
        public string Name { get; set; }
        public bool IsPublic { get; set; }
        public string DocumentType { get; set; }
        public string ContentType { get; set; }
        public string AppCode { get; set; }
    }
}
