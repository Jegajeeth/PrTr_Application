
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using ProgressTracker.Storage;

namespace ProgressTracker.Server.Functions;

public class GetPlans(IBlobPlansRepository PlansRepository)
{
    [Function("GetPlans")]
    public async Task<IActionResult> GetPlansFunction(
        [HttpTrigger(AuthorizationLevel.Function, "GET", Route = "plans")] HttpRequestData req)
    {
        var plans = await PlansRepository.ListPlansAsync();
        return new OkObjectResult(plans);
    }
}