using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace MashService.src
{
    public static class Distilleries
    {
        [FunctionName("Distilleries.Find")]
        public static HttpResponseMessage Find([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "distilleries/find/{substring}")]HttpRequestMessage req, string substring, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            // Fetching the name from the path parameter in the request URL
            return req.CreateResponse(HttpStatusCode.OK, "Hello " + substring);
        }
        [FunctionName("Distilleries.Top")]
        public static HttpResponseMessage Top([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "distilleries")]HttpRequestMessage req, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            // Fetching the name from the path parameter in the request URL
            return req.CreateResponse(HttpStatusCode.OK, "Hello");
        }
        [FunctionName("Distilleries.My")]
        public static HttpResponseMessage My([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "distilleries/my")]HttpRequestMessage req, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            // Fetching the name from the path parameter in the request URL
            return req.CreateResponse(HttpStatusCode.OK, "Hello");
        }
        [FunctionName("Distilleries.Get")]
        public static HttpResponseMessage Get([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "distilleries/{id}")]HttpRequestMessage req, string id, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            // Fetching the name from the path parameter in the request URL
            return req.CreateResponse(HttpStatusCode.OK, "Hello " + id);
        }
    }
}
