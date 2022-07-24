﻿using System;
using Default_Backend.Entities.Entities.Base;

namespace Default_Backend.Entities.Entities.Common
{
    public class File : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string StorageType { get; set; }
        public string DocumentType { get; set; }
        public string Url { get; set; }
        public string FileSize { get; set; }
        public bool IsPublic { get; set; }
        public string ContentType { get; set; }
        public long? UserId { get; set; }
        public string AppCode { get; set; }
    }
}