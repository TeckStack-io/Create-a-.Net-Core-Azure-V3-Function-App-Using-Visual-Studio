using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace TutorialFunc
{
    public static class TutorialFunc
    {
        [FunctionName("tutorialfunc")]
        [return: Queue("tutorialqueue", Connection = "AzureWebJobsStorage")]
        public static string Run([TimerTrigger("0 */1 * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            return "ok";
        }
    }
}
