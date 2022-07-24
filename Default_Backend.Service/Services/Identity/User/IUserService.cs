using System;
using System.Threading.Tasks;
using Default_Backend.Common.Core;
using Default_Backend.Common.DTO.Base;
using Default_Backend.Common.DTO.Identity.User;
using Default_Backend.Common.DTO.Identity.User.Parameters;
using Default_Backend.Service.Services.Base;

namespace Default_Backend.Service.Services.Identity.User
{
    public interface IUserService : IBaseService<Entities.Entities.Identity.User, AddUserDto, UserDto , Guid, Guid?>
    {
        /// <summary>
        /// Get All Paged
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        Task<DataPaging> GetAllPagedAsync(BaseParam<UserFilter> filter);
    }
}