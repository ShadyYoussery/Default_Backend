using System.ComponentModel.DataAnnotations;
using Default_Backend.Common.Core;

namespace Default_Backend.Common.DTO.Base
{
    public class LookupDto<T> : IEntityDto<T>
    {
        public T Id { get; set; }
        [Required]
        public string NameEn { get; set; }
        [Required]
        public string NameAr { get; set; }
        [Required]
        public string Code { get; set; }
    }
}
