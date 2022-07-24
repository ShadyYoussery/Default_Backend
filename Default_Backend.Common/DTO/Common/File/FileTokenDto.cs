using System;

namespace Default_Backend.Common.DTO.Common.File
{
    public class FileTokenDto
    {
        public Guid Id { get; set; }
        public string Token { get; set; }
        public string Extension { get; set; }
    }
}
