using Net.WebApi.Globalexcpetions.Exceptions;

namespace Net.WebApi.Globalexcpetions.Configurations;

public static class ApplicationBuilderExtensions
{
    public static IApplicationBuilder AddGlobalErrorHandler(this IApplicationBuilder applicationBuilder)
        => applicationBuilder.UseMiddleware<GlobalErrorHandlingMiddleware>();
}
