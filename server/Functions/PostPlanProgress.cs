
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using ProgressTracker.Models;
using ProgressTracker.Storage;

namespace ProgressTracker.Server.Functions;

public class PostPlanProgress(ITableProgressRepository ProgressRepository)
{
    [Function("PostPlanProgress")]
    public async Task<IActionResult> PostPlanProgressFunction(
        [HttpTrigger(AuthorizationLevel.Function, "POST", Route = "plan/{planId}/progress")] HttpRequestData req, string planId, [Microsoft.AspNetCore.Mvc.FromBody] ProgressModel progressRequestBody)
    {
        ProgressModel progress = progressRequestBody ?? new ProgressModel();
        await ProgressRepository.SaveProgressAsync(planId, progress);
        return new OkObjectResult(new { saved = true });
    }
}