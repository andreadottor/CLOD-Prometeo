namespace ITS.Prometeo.API.Endpoints;

using ITS.Prometeo.ApplicationCore.Entities;
using ITS.Prometeo.ApplicationCore.Services;
using Microsoft.AspNetCore.Mvc;

public static class WeatherForecastEndpoints
{
    public static IEndpointRouteBuilder MapWeatherForecastEndpoints(this IEndpointRouteBuilder endpoints)
    {
        var group = endpoints.MapGroup("/api/weatherforecast");

        group.MapGet("/", GetWeatherForecast)
             .WithName(nameof(GetWeatherForecast))
             .WithOpenApi();

        return endpoints;
    }

    internal static IEnumerable<WeatherForecast> GetWeatherForecast([FromServices]IWeatherForecastService weatherForecastService)
    {
        var forecast = weatherForecastService.GetWeatherForecast(5);
        return forecast;
    }
}


