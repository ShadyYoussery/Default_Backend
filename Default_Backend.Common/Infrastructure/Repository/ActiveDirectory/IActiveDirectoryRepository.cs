using Default_Backend.Common.DTO.Identity.Login;
using Default_Backend.Common.DTO.Identity.User;

namespace Default_Backend.Common.Infrastructure.Repository.ActiveDirectory
{
    public interface IActiveDirectoryRepository
    {
        ActiveDirectoryUserDto LoginAsync(LoginParameters parameters);
    }
}
