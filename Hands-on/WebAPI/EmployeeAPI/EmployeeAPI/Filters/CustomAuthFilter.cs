using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;

namespace EmployeeAPI.Filters
{
    public class CustomAuthFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Request.Headers.ContainsKey("Authorization"))
            {
                StringValues token;
                if (context.HttpContext.Request.Headers.TryGetValue("Authorization", out token))
                {
                    if (token.ToString().StartsWith("Bearer"))
                        base.OnActionExecuting(context);
                    else
                        context.Result = new BadRequestObjectResult("Invalid Request - Token present but bearer unavailable");
                }

            }
            else
                context.Result = new BadRequestObjectResult("Invalid request - No auth token");

            base.OnActionExecuting(context);
        }
    }
}
