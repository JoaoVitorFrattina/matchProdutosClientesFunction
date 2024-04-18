using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace matchProdutosClientesFunction
{
    public static class Function1
    {
        [FunctionName("GetProbabilidades")]
        public static async Task<JsonReturn> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string name = req.Query["name"];

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            List<JsonModel> probs = JsonConvert.DeserializeObject<List<JsonModel>>(requestBody);

            probs = probs.OrderByDescending(p => p.probability).ToList();

            return new JsonReturn() { tag = probs[0].tagName };
        }
    }
}
