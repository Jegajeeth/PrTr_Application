
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using ProgressTracker.Storage;

namespace ProgressTracker.Server.Functions;

public class GetPlanProgress(ITableProgressRepository ProgressRepository)
{
    [Function("GetPlanProgress")]
    public async Task<IActionResult> GetPlanProgressFunction(
        [HttpTrigger(AuthorizationLevel.Function, "GET", Route = "plan/{planId}/progress")] HttpRequestData req, string planId)
    {
        var progress = await ProgressRepository.GetProgressAsync(planId);
        return new OkObjectResult(progress);
    }
}