namespace ITS.Prometeo.Infrastructure;

using ITS.Prometeo.ApplicationCore.Persistence;
using ITS.Prometeo.Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IWeatherForecastRepository, WeatherForecastRepository>();
        //services.AddScoped<IWeatherStationsRepository, WeatherStationsNpgsqlRepository>();
        services.AddScoped<IWeatherStationsRepository, WeatherStationsSqlRepository>();
        //services.AddScoped<IWeatherDetectionRepository, WeatherDetectionNpgsqlRepository>();
        services.AddScoped<IWeatherDetectionRepository, WeatherDetectionSqlRepository>();
        
        return services;
    }
}
