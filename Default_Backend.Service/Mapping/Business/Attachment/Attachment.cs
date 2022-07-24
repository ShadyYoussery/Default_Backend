
using Default_Backend.Common.DTO.Business.Attachment;
using Default_Backend.Entities.Entities.Business;

// ReSharper disable once CheckNamespace
namespace Default_Backend.Service.Mapping
{
    public partial class MappingService
    {
        public void MapAttachment()
        {
            CreateMap<Attachment, AttachmentDto>()
                .ReverseMap();

            CreateMap<Attachment, AddAttachmentDto>()
                .ReverseMap();
        }
    }
}