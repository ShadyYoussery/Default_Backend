using Default_Backend.Common.DTO.Identity.Login;
using Default_Backend.Common.DTO.Identity.User;

namespace Default_Backend.Service.Services.Base
{
    public interface ITokenService
    {
        UserLoginReturn GenerateJsonWebToken(UserDto userInfo, string role);
    }
}