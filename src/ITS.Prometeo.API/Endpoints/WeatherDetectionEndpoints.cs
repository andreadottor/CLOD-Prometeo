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

        group.MapGet("/", GetWeatherDetectionList)
             .WithName(nameof(GetWeatherDetectionList))
             .WithOpenApi();
        group.MapGet("/{id}", GetDetection)
             .WithName(nameof(GetDetection))
             .WithOpenApi();

        return endpoints;
    }

    private static async Task<IResult> InsertWeatherDetection(WeatherDetection detection, IWeatherStationsService weatherStationsService)
    {
        await weatherStationsService.InsertAsync(detection);
        return Results.NoContent();
    }

    private static async Task<IResult> GetWeatherDetectionList(IWeatherStationsService weatherStationsService)
    {
        var list = await weatherStationsService.GetDetectionListAsync();
        return Results.Ok(list);
    }
    private static async Task<IResult> GetDetection(long id, IWeatherStationsService weatherStationsService)
    {
        var station = await weatherStationsService.GetDetectionByIdAsync(id);
        if (station is not null)
            return Results.Ok(station);
        else
            return Results.NotFound();
    }
}
