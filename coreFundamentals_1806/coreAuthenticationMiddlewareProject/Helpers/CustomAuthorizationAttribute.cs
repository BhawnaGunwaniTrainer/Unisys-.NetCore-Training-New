using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace coreAuthenticationMiddlewareProject.Helpers
{
    public class CustomAuthorizationAttribute: Attribute, IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var httpContext = context.HttpContext;
            if (!httpContext.Request.Headers.ContainsKey("Authorization"))
            {
                context.Result = new UnauthorizedResult();
                return;
            }

            var token = httpContext.Request.Headers["Authorization"].ToString();
            if (token != "mysecrettoken")
            {
                context.Result = new UnauthorizedResult();
                return;
            }


            await next();
        }
    }
}
