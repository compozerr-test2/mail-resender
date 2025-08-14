using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Mail-resender.Services;

namespace Mail-resender.Endpoints.Mail-resender;

public static class Mail-resenderRoute
{
    public static RouteHandlerBuilder AddMail-resenderRoute(this IEndpointRouteBuilder app)
    {
        return app.MapGet("/", (string name, IMail-resenderService mail-resenderService) => new GetMail-resenderResponse($"Hello, {mail-resenderService.GetObfuscatedName(name)}!"));
    }
}