using Core.Feature;
using Microsoft.Extensions.DependencyInjection;
using Mail-resender.Services;

namespace Mail-resender;

public class Mail-resenderFeature : IFeature
{

    void IFeature.ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<IMail-resenderService, Mail-resenderService>();
    }
}