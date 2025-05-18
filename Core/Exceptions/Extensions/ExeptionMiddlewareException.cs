using Microsoft.AspNetCore.Builder;

namespace Core.Exceptions.Extensions
{
    public static class ExeptionMiddlewareException
    {
        public static void ConfigureCustomException(this IApplicationBuilder app) => app.UseMiddleware<ExceptionMiddleware>();
    }
}
