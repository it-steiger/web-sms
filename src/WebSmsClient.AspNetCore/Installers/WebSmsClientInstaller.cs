using Microsoft.Extensions.DependencyInjection;
using WebSmsClient.Models;
using WebSmsClient.Services;

namespace WebSmsClient.AspNetCore.Installers;

public static class WebSmsClientInstaller
{
    public static IServiceCollection AddWebSmsClient(this IServiceCollection services, Action<WebSmsServiceConfiguration> options)
    {
        
        if(options == null)
            throw new ArgumentNullException(nameof(options), "WebSmsClientOptions cannot be null");

        var config = new WebSmsServiceConfiguration();
        options.Invoke(config);
        
        services.AddSingleton(config);
        services.AddSingleton<IWebSmsService, WebSmsService>();
        return services;
    }
} 