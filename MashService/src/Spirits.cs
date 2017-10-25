using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace MashService.src
{
    public static class Spirits
    {
        [FunctionName("Spirits.Find")]
        public static HttpResponseMessage Find([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "spirits/find/{substring}")]HttpRequestMessage req, string substring, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            // Fetching the name from the path parameter in the request URL
            return req.CreateResponse(HttpStatusCode.OK, "Hello " + substring);
        }
        [FunctionName("Spirits.Top")]
        public static HttpResponseMessage Top([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "spirits")]HttpRequestMessage req, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            // Fetching the name from the path parameter in the request URL
            return req.CreateResponse(HttpStatusCode.OK, "Hello");
        }
        [FunctionName("Spirits.My")]
        public static HttpResponseMessage My([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "spirits/my")]HttpRequestMessage req, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            // Fetching the name from the path parameter in the request URL
            return req.CreateResponse(HttpStatusCode.OK, "Hello");
        }
        [FunctionName("Spirits.Get")]
        public static HttpResponseMessage Get([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "spirits/{id}")]HttpRequestMessage req, string id, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            // Fetching the name from the path parameter in the request URL
            return req.CreateResponse(HttpStatusCode.OK, "Hello " + id);
        }
    }
}
