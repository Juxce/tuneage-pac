using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Threading.Tasks;

namespace juxce.tuneage.devops.canary
{

    public static class CanaryHelper
    {
        public static string Help()
        {
            return "Me";
        }
    }

    public static class Canary
    {
        [FunctionName("Canary")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]
            HttpRequest req,
            ILogger log)
        {
            log.LogInformation("start canary");

            string name = req.Query["name"];

            log.LogInformation(name);

            //string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            //dynamic data = JsonConvert.DeserializeObject(requestBody);
            //name = name ?? data?.name;

            //log.LogInformation("returning:", returnVal.GetType());
            log.LogInformation("end canary");

            //var returnVal = name != null
            return name != null
                ? (ActionResult) new OkObjectResult($"Hello, {name}")
                : new BadRequestObjectResult("Please pass a name on the query string");
            //: new BadRequestObjectResult("Please pass a name on the query string (?name=Al) or in the request body");

            //return returnVal;
        }
    }
}