using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using SD.API.Repository.Core;
using SD.Shared.Core.Models;
using System.Net;

namespace SD.API.Functions
{
    public class WatchedListFunction
    {
        private readonly IRepository _repo;

        public WatchedListFunction(IRepository repo)
        {
            _repo = repo;
        }

        //[OpenApiOperation("WatchedListGet", "Azure (Cosmos DB)")]
        //[OpenApiResponseWithBody(HttpStatusCode.OK, "application/json", typeof(WatchedList))]
        [Function("WatchedListGet")]
        public async Task<WatchedList?> Get(
            [HttpTrigger(AuthorizationLevel.Anonymous, Method.GET, Route = "WatchedList/Get")] HttpRequestData req, CancellationToken cancellationToken)
        {
            try
            {
                var userId = req.GetUserId();

                return await _repo.Get<WatchedList>(DocumentType.WatchedList + ":" + userId, new PartitionKey(userId), cancellationToken);
            }
            catch (Exception ex)
            {
                req.ProcessException(ex);
                throw new UnhandledException(ex.BuildException());
            }
        }

        //[OpenApiOperation("WatchedListAdd", "Azure (Cosmos DB)")]
        //[OpenApiResponseWithBody(HttpStatusCode.OK, "application/json", typeof(WatchedList))]
        [Function("WatchedListAdd")]
        public async Task<WatchedList?> Add(
            [HttpTrigger(AuthorizationLevel.Anonymous, Method.POST, Route = "WatchedList/Add/{MediaType}/{TmdbId}")] HttpRequestData req,
            string MediaType, string TmdbId, CancellationToken cancellationToken)
        {
            try
            {
                var userId = req.GetUserId();

                var obj = await _repo.Get<WatchedList>(DocumentType.WatchedList + ":" + userId, new PartitionKey(userId), cancellationToken);

                if (obj == null)
                {
                    obj = new();

                    obj.Initialize(userId);
                }
                else
                {
                    obj.Update();
                }

                var ids = TmdbId.Split(',');
                obj.AddItem((MediaType)Enum.Parse(typeof(MediaType), MediaType), new HashSet<string>(ids));

                return await _repo.Upsert(obj, cancellationToken);
            }
            catch (Exception ex)
            {
                req.ProcessException(ex);
                throw new UnhandledException(ex.BuildException());
            }
        }

        //[OpenApiOperation("WatchedListRemove", "Azure (Cosmos DB)")]
        //[OpenApiResponseWithBody(HttpStatusCode.OK, "application/json", typeof(WatchedList))]
        [Function("WatchedListRemove")]
        public async Task<WatchedList?> Remove(
            [HttpTrigger(AuthorizationLevel.Anonymous, Method.POST, Route = "WatchedList/Remove/{MediaType}/{TmdbId}")] HttpRequestData req,
            string MediaType, string TmdbId, CancellationToken cancellationToken)
        {
            try
            {
                var userId = req.GetUserId();

                var obj = await _repo.Get<WatchedList>(DocumentType.WatchedList + ":" + userId, new PartitionKey(userId), cancellationToken);

                if (obj == null)
                {
                    obj = new();

                    obj.Initialize(userId);
                }
                else
                {
                    obj.Update();
                }

                obj.RemoveItem((MediaType)Enum.Parse(typeof(MediaType), MediaType), TmdbId);

                return await _repo.Upsert(obj, cancellationToken);
            }
            catch (Exception ex)
            {
                req.ProcessException(ex);
                throw new UnhandledException(ex.BuildException());
            }
        }
    }
}