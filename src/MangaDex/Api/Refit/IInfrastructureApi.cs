// GENERATED Refit scaffold for InfrastructureApi — prototype, not wired into the build (needs Refit).
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using MangaDex.Model;

namespace MangaDex.Api.Refit
{
    public interface IInfrastructureApi
    {
        [Get("/ping")]
        Task<string> GetPing();

    }
}