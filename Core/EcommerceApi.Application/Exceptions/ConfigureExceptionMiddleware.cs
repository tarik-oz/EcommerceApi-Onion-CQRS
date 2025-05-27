using EcommerceApi.Application.Exceptions;
using Microsoft.AspNetCore.Builder;

namespace EcommerceApi.Application.Exceptions
{
    public static class ConfigureExceptionMiddleware
    {
        public static void ConfigureExceptionHandlingMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}