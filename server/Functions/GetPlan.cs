
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using ProgressTracker.Storage;

namespace ProgressTracker.Server.Functions;

public class GetPlan(IBlobPlansRepository PlansRepository)
{
    [Function("GetPlan")]
    public async Task<IActionResult> GetPlanFunction(
        [HttpTrigger(AuthorizationLevel.Function, "GET", Route = "plan/{planId}")] HttpRequestData req, string planId)
    {
        var content = await PlansRepository.GetPlanContentAsync(planId);
        if (content is null)
            return new NotFoundObjectResult($"Plan '{planId}' not found.");

        var plan = PlanParser.Parse(planId, content);
        return new OkObjectResult(plan);
    }
}