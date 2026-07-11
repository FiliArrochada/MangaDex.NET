using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using MangaDex.Model;

namespace MangaDex.Api
{
    public interface IUploadApi
    {
        [Delete("/upload/{uploadSessionId}")]
        Task<Response> AbandonUploadSession(Guid uploadSessionId);

        [Post("/upload/begin/{chapterId}")] [Headers("Content-Type: application/json")]
        Task<UploadSession> BeginEditSession(Guid chapterId, [Body] BeginEditSession beginEditSession = null);

        [Post("/upload/begin")] [Headers("Content-Type: application/json")]
        Task<UploadSession> BeginUploadSession([Body] BeginUploadSession beginUploadSession = null);

        [Post("/upload/check-approval-required")] [Headers("Content-Type: application/json")]
        Task<UploadCheckApprovalRequired200Response> UploadCheckApprovalRequired([Body] UploadCheckApprovalRequiredRequest uploadCheckApprovalRequiredRequest = null);

        [Post("/upload/{uploadSessionId}/commit")] [Headers("Content-Type: application/json")]
        Task<Chapter> CommitUploadSession(Guid uploadSessionId, [Body] CommitUploadSession commitUploadSession = null);

        [Delete("/upload/{uploadSessionId}/{uploadSessionFileId}")]
        Task<Response> DeleteUploadedSessionFile(Guid uploadSessionId, Guid uploadSessionFileId);

        [Delete("/upload/{uploadSessionId}/batch")] [Headers("Content-Type: application/json")]
        Task<Response> DeleteUploadedSessionFiles(Guid uploadSessionId, [Body] List<Guid> requestBody = null);

        [Get("/upload")]
        Task<UploadSession> GetUploadSession();

        [Post("/upload/{uploadSessionId}")] [Multipart]
        Task<PutUploadSessionFile200Response> PutUploadSessionFile(Guid uploadSessionId, [AliasAs("file")] StreamPart file);

    }
}