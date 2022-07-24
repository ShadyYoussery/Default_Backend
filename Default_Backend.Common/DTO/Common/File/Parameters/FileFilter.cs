using System;
using Default_Backend.Common.DTO.Base;

namespace Default_Backend.Common.DTO.Common.File.Parameters
{
    public class FileFilter : MainFilter
    {
        public Guid? Id { get; set; }
        public string AppCode { get; set; }
    }
}
