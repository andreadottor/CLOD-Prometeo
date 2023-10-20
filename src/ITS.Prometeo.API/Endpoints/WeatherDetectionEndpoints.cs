using ITS.Prometeo.ApplicationCore.Entities;
using ITS.Prometeo.ApplicationCore.Services;

namespace ITS.Prometeo.API.Endpoints;

public static class WeatherDetectionEndpoints
{
    public static IEndpointRouteBuilder MapWeatherDetectionsEndpoints(this IEndpointRouteBuilder endpoints)
    {
        var group = endpoints.MapGroup("/api/detections");

        group.MapPost("/", InsertWeatherDetection)
             .WithName(nameof(InsertWeatherDetection))
             .WithOpenApi();

        return endpoints;
    }

    private static async Task<IResult> InsertWeatherDetection(WeatherDetection detection, IWeatherStationsService weatherStationsService)
    {
        await weatherStationsService.InsertAsync(detection);
        return Results.NoContent();
    }
}
