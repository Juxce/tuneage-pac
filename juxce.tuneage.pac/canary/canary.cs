//-----------------------------------------------------------------------
// <copyright file="canary.cs" company="Juxce">
//     Copyright (c) Juxce. All rights reserved.
// </copyright>
// <author>John Michael Miller</author>
//-----------------------------------------------------------------------
namespace Juxce.Tuneage.PaC.Canary
{

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Azure.WebJobs;
    using Microsoft.Azure.WebJobs.Extensions.Http;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// A simple class containing a function used to flesh out the pipeline
    /// </summary>
    public static class Canary
    {
        /// <summary>
        /// A simple function used to flesh out the pipeline
        /// </summary>
        /// <param name="req">The http request</param>
        /// <param name="log">A logger</param>
        /// <returns>The response</returns>
        [FunctionName("Canary")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]
            HttpRequest req,
            ILogger log)
        {
            log.LogInformation("start canary");

            string name = req.Query["name"];

            log.LogInformation(name);

            ////string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            ////dynamic data = JsonConvert.DeserializeObject(requestBody);
            ////name = name ?? data?.name;

            ////log.LogInformation("returning:", returnVal.GetType());
            log.LogInformation("end canary");

            ////var returnVal = name != null
            return name != null
                ? (ActionResult) new OkObjectResult($"Hello, {name}")
                : new BadRequestObjectResult("Please pass a name on the query string");
            ////: new BadRequestObjectResult("Please pass a name on the query string (?name=Al) or in the request body");

            ////return returnVal;
        }

        /// <summary>
        /// Helper class for pipeline unit testing.
        /// </summary>
        public static class CanaryHelper
        {
            /// <summary>
            /// Simple method that returns a value
            /// </summary>
            /// <returns>The string "Me"</returns>
            public static string Help()
            {
                return "Me";
            }
        }

    }
}