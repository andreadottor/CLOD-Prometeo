namespace ITS.Prometeo.Infrastructure;

using ITS.Prometeo.ApplicationCore.Persistence;
using ITS.Prometeo.Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IWeatherForecastRepository, WeatherForecastRepository>();
        return services;
    }
}
