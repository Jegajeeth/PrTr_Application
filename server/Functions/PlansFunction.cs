
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using ProgressTracker.Models;
using ProgressTracker.Storage;
using FromBodyAttribute = Microsoft.Azure.Functions.Worker.Http.FromBodyAttribute;

namespace ProgressTracker.Functions;
public class PlansFunction (IBlobPlansRepository PlansRepository, ITableProgressRepository ProgressRepository)
{
    [Function("GetPlans")]
    public async Task<IActionResult> GetPlans([HttpTrigger(AuthorizationLevel.Function, "GET", Route = "plans")] HttpRequestData req)
    {
        var plans = await PlansRepository.ListPlansAsync();
        return new OkObjectResult(plans);
    }

    [Function("GetPlan")]
    public async Task<IActionResult> GetPlan([HttpTrigger(AuthorizationLevel.Function, "GET", Route = "plan/{planId}")] HttpRequestData req, string planId)
    {
        var content = await PlansRepository.GetPlanContentAsync(planId);
        if (content is null)
            return new NotFoundObjectResult($"Plan '{planId}' not found.");

        var plan = PlanParser.Parse(planId, content);
        return new OkObjectResult(plan);
    }

    [Function("GetPlanProgress")]
    public async Task<IActionResult> GetPlanProgress([HttpTrigger(AuthorizationLevel.Function, "GET", Route = "plan/{planId}/progress")] HttpRequestData req, string planId)
    {
        var progress = await ProgressRepository.GetProgressAsync(planId);
        return new OkObjectResult(progress);
    }

    [Function("PostPlanProgress")]
    public async Task<IActionResult> PostPlanProgress([HttpTrigger(AuthorizationLevel.Function, "POST", Route = "plan/{planId}/progress")] HttpRequestData req, string planId, [FromBody] ProgressModel progressRequestBody)
    {
        ProgressModel progress = progressRequestBody ?? new ProgressModel();
        await ProgressRepository.SaveProgressAsync(planId, progress);
        return new OkObjectResult(new { saved = true });
    }
}