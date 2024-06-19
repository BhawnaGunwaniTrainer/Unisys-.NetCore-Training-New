using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace coreAuthenticationMiddlewareProject.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class CustomAuthenticationMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomAuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            if (!httpContext.Request.Headers.ContainsKey("Authorization"))
            {
                httpContext.Response.StatusCode = 401;  // UnAuthorized
                await httpContext.Response.WriteAsync("Authorization Header is Missing (Middleware).");
                return;
            }

            var token = httpContext.Request.Headers["Authorization"].ToString();
            if(token != "mysecrettoken")
            {
                httpContext.Response.StatusCode = 401;  // UnAuthorized
                await httpContext.Response.WriteAsync("Invalid Token");
                return;
            }

            // if the token is valid, conitnue to the next middleware
            await _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class CustomAuthenticationMiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomAuthenticationMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomAuthenticationMiddleware>();
        }
    }
}
