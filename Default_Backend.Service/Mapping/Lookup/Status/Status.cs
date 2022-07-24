using Default_Backend.Common.DTO.Lookup.Status;
using Default_Backend.Entities.Entities.Lookup;


// ReSharper disable once CheckNamespace
namespace Default_Backend.Service.Mapping
{
    public partial class MappingService
    {
        public void MapStatus()
        {
            CreateMap<Status, AddStatusDto>()
                .ReverseMap();

            CreateMap<Status, StatusDto>()
                .ReverseMap();
        }
    }
}