using Default_Backend.Common.DTO.Common.File;
using Default_Backend.Entities.Entities.Common;

// ReSharper disable once CheckNamespace
namespace Default_Backend.Service.Mapping
{
    public partial class MappingService
    {
        public void MapFile()
        {
            CreateMap<File, FileDto>()
                .ReverseMap();

            CreateMap<File, AddFileDto>()
                .ReverseMap();

            CreateMap<File, DownLoadDto>().ReverseMap();
        }
    }
}