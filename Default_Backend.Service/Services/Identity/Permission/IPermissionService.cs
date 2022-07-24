using System.Threading.Tasks;
using Default_Backend.Common.Core;
using Default_Backend.Common.DTO.Base;
using Default_Backend.Common.DTO.Identity.Permission;
using Default_Backend.Common.DTO.Identity.Permission.Parameters;
using Default_Backend.Service.Services.Base;

namespace Default_Backend.Service.Services.Identity.Permission
{
    public interface IPermissionService : IBaseService<Entities.Entities.Identity.Permission, AddPermissionDto, PermissionDto , long , long?>
    {
        Task<DataPaging> GetAllPagedAsync(BaseParam<PermissionFilter> filter);
    }
}