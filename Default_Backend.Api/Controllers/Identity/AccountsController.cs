using System.Threading.Tasks;
using Default_Backend.Api.Controllers.Base;
using Default_Backend.Common.Core;
using Default_Backend.Common.DTO.Identity.Login;
using Default_Backend.Service.Services.Base;
using Default_Backend.Service.Services.Identity.Login;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Default_Backend.Api.Controllers.Identity
{
    /// <summary>
    /// Accounts Controller
    /// </summary>
    public class AccountsController : BaseController
    {
        private readonly IAccountService _accountService;
        /// <inheritdoc />
        public AccountsController(IAccountService accountService, ITokenService tokenService) : base(tokenService)
        {
            _accountService = accountService;
        }
        /// <summary>
        /// Login 
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task<IResult> Login(LoginParameters parameter)
        {
            return await _accountService.Login(parameter);
        }
    }
}
