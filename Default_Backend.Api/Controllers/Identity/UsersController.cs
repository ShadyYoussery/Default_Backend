﻿using System.Threading.Tasks;
using Default_Backend.Api.Controllers.Base;
using Default_Backend.Common.Core;
using Default_Backend.Common.DTO.Base;
using Default_Backend.Common.DTO.Identity.User;
using Default_Backend.Common.DTO.Identity.User.Parameters;
using Default_Backend.Service.Services.Identity.User;
using Microsoft.AspNetCore.Mvc;

namespace Default_Backend.Api.Controllers.Identity
{
    /// <summary>
    /// Users Controller
    /// </summary>
    public class UsersController : BaseController
    {
        private readonly IUserService _userService;
        /// <summary>
        /// Constructor
        /// </summary>
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        /// <summary>
        /// Get By Id 
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IResult> GetAsync(long id)
        {
            var result = await _userService.GetByIdAsync(id);
            return result;
        }

        /// <summary>
        /// Get All 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IResult> GetAllAsync()
        {
            var result = await _userService.GetAllAsync();
            return result;
        }

        /// <summary>
        /// GetAll Data paged
        /// </summary>
        /// <param name="filter">Filter responsible for search and sort</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<DataPaging> GetPagedAsync([FromBody] BaseParam<UserFilter> filter)
        {
            return await _userService.GetAllPagedAsync(filter);
        }

        /// <summary>
        /// Add 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IResult> AddAsync([FromBody] AddUserDto dto)
        {
            var result = await _userService.AddAsync(dto);
            return result;
        }


        /// <summary>
        /// Update  
        /// </summary>
        /// <param name="model">Object content</param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IResult> UpdateAsync(AddUserDto model)
        {

            return await _userService.UpdateAsync(model);
        }
        /// <summary>
        /// Remove  by id
        /// </summary>
        /// <param name="id">PK</param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IResult> DeleteAsync(long id)
        {
            return await _userService.DeleteAsync(id);
        }

        /// <summary>
        /// Soft Remove  by id
        /// </summary>
        /// <param name="id">PK</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IResult> DeleteSoftAsync(long id)
        {
            return await _userService.DeleteSoftAsync(id);
        }


    }
}
