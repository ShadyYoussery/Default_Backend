﻿using Default_Backend.Service.Services.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Default_Backend.Api.Controllers.Base
{
    /// <inheritdoc />
    [Route("[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class BaseController : ControllerBase
    {
        /// <summary>
        /// Token Business Property
        /// </summary>
        protected readonly ITokenService TokenService;
        /// <inheritdoc />
        public BaseController()
        {

        }
        /// <inheritdoc />
        public BaseController(ITokenService tokenService)
        {
            TokenService = tokenService;
        }
    }
}