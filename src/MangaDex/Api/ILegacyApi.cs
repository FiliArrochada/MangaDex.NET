using System.Threading.Tasks;
using MangaDex.Model;
using Refit;

namespace MangaDex.Api
{
    public interface ILegacyApi
    {
        [Post("/legacy/mapping")]
        [Headers("Content-Type: application/json")]
        Task<MappingIdResponse> PostLegacyMapping([Body] MappingIdBody mappingIdBody = null);
    }
}