using System.Threading.Tasks;
using Default_Backend.Common.Caching.Redis;
using Default_Backend.Common.Helpers.HttpClient.RestSharp;

namespace Default_Backend.Integration.CacheRepository
{
    public class CacheRepository : ICacheRepository
    {
        private readonly IRestSharpContainer _restSharpContainer;
        public CacheRepository(IRestSharpContainer restSharpContainer)
        {
            _restSharpContainer = restSharpContainer;
        }

        #region Public Methods
        /// <summary>
        /// Get Employee From Cache By National Id
        /// </summary>
        /// <param name="nationalId"></param>
        /// <returns></returns>
        public async Task<object> GetEmployeeAsync(string nationalId)
        {
            var employee = RedisCacheHelper.GetT<object>(nationalId);
            return employee;
        }

        #endregion
    }
}
