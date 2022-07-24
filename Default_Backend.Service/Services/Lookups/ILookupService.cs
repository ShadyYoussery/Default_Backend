using System.Threading.Tasks;
using Default_Backend.Common.Core;
using Default_Backend.Common.DTO.Lookup.Status;
using Default_Backend.Entities.Entities.Lookup;
using Default_Backend.Service.Services.Base;

namespace Default_Backend.Service.Services.Lookups
{
    public interface ILookupService : IBaseService<Status , AddStatusDto , StatusDto , long , long?>
    {
        Task<IResult> GetStatusesAsync();
        Task<IResult> GetActionsAsync();
    }
}
