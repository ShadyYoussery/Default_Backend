using System.Threading.Tasks;
using Default_Backend.Common.Core;
using Default_Backend.Common.DTO.Identity.Login;

namespace Default_Backend.Service.Services.Identity.Login
{
    public interface IAccountService
    {
        Task<IResult> Login(LoginParameters parameters);
        Task<IResult> AdLogin(LoginParameters parameters);
    }
}