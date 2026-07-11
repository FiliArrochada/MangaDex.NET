using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using MangaDex.Model;

namespace MangaDex.Api
{
    public interface IInfrastructureApi
    {
        [Get("/ping")]
        Task<string> GetPing();

    }
}