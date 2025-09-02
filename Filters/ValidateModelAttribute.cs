// Filters/ValidateModelAttribute.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using WebApplicationETS.Model.otherModel;

public sealed class ValidateModelAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        if (!context.ModelState.IsValid)
        {
            var messages = context.ModelState
                .Where(ms => ms.Value.Errors.Count > 0)
                .SelectMany(kvp => kvp.Value.Errors.Select(e => e.ErrorMessage));

            var msg = string.Join("; ", messages);

            context.Result = new BadRequestObjectResult(
                new ApiResponse<string>(false, null, msg)
            );
        }
    }
}
