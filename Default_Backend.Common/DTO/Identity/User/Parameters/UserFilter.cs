using System;
using Default_Backend.Common.DTO.Base;

namespace Default_Backend.Common.DTO.Identity.User.Parameters
{
    public class UserFilter : MainFilter
    {
        public Guid Id { get; set; }
    }
}
