namespace NZWalks.Api.Configuration;

public static class ApplicationBuilderException
{
    public static IApplicationBuilder AddGlobalErrorhandler(this IApplicationBuilder applicationBuilder)
        => applicationBuilder.UseMiddleware<GlobalExceptionHandling>();
}
