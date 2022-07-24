using System;

namespace Default_Backend.Common.Services
{
    public interface IClaimService
    {
        Guid UserId { get; }
        string Token { get; }
    }
}
