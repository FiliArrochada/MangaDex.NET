using System.Threading.Tasks;
using Refit;

namespace MangaDex.Api
{
    public interface IInfrastructureApi
    {
        [Get("/ping")]
        Task<string> GetPing();
    }
}