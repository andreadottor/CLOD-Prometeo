namespace ITS.Prometeo.ApplicationCore;

using ITS.Prometeo.ApplicationCore.Services;
using Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationCore(this IServiceCollection services)
    {
        services.AddScoped<IWeatherForecastService, WeatherForecastService>();
        return services;
    }
}
