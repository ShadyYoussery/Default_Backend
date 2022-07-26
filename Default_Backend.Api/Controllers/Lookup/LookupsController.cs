﻿using System.Threading.Tasks;
using Default_Backend.Api.Controllers.Base;
using Default_Backend.Common.Core;
using Default_Backend.Service.Services.Lookups;
using Microsoft.AspNetCore.Mvc;

namespace Default_Backend.Api.Controllers.Lookup
{
    /// <summary>
    /// Lookups Controller
    /// </summary>
    public class LookupsController : BaseController
    {
        private readonly ILookupService _service;
        /// <summary>
        /// Constructor
        /// </summary>
        public LookupsController(ILookupService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get All Statuses
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IResult> GetStatusesAsync() => await _service.GetStatusesAsync();

        /// <summary>
        /// Get All Actions
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IResult> GetActionsAsync() => await _service.GetStatusesAsync();


    }
}
