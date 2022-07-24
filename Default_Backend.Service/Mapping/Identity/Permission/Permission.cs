using Default_Backend.Common.DTO.Identity.Permission;
using Default_Backend.Entities.Entities.Identity;


// ReSharper disable once CheckNamespace
namespace Default_Backend.Service.Mapping
{
    public partial class MappingService
    {
        public void MapPermission()
        {
            CreateMap<Permission, PermissionDto>()
                .ReverseMap();

            CreateMap<Permission, AddPermissionDto>()
                .ReverseMap();
        }
    }
}