using Default_Backend.Common.DTO.Lookup.Action;
using Default_Backend.Entities.Entities.Lookup;


// ReSharper disable once CheckNamespace
namespace Default_Backend.Service.Mapping
{
    public partial class MappingService
    {
        public void MapAction()
        {
            CreateMap<Action, ActionDto>()
                .ReverseMap();

            CreateMap<Action, AddActionDto>()
                .ReverseMap();
        }
    }
}