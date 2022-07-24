using AutoMapper;
using Default_Backend.Common.Core;
using Default_Backend.Common.Infrastructure.UnitOfWork;
using Default_Backend.Integration.CacheRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Default_Backend.Service.Services.Base
{
    public interface IServiceBaseParameter<T> where T : class
    {
        IMapper Mapper { get; set; }
        IUnitOfWork<T> UnitOfWork { get; set; }
        IResponseResult ResponseResult { get; set; }
        IHttpContextAccessor HttpContextAccessor { get; set; }
        IConfiguration Configuration { get; set; }
        ICacheRepository CacheRepository { get; set; }
    }
}