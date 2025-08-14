using Carter;
using Microsoft.AspNetCore.Routing;

namespace Mail-resender.Endpoints.Mail-resender;

public class Mail-resenderGroup : CarterModule
{
    public Mail-resenderGroup() : base("/mail-resender")
    {
        WithTags(nameof(Mail-resender));
    }

    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.AddMail-resenderRoute();
    }
}