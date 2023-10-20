using ITS.Prometeo.ApplicationCore.Entities;
using ITS.Prometeo.ApplicationCore.Services;

namespace ITS.Prometeo.API.Endpoints;

public static class WeatherStationsEndpoints
{
    public static IEndpointRouteBuilder MapWeatherStationsEndpoints(this IEndpointRouteBuilder endpoints)
    {
        var group = endpoints.MapGroup("/api/weatherstation");

        group.MapPost("/", InsertWeatherStation)
             .WithName(nameof(InsertWeatherStation))
             .WithOpenApi();
        group.MapGet("/", GetWeatherStationList)
             .WithName(nameof(GetWeatherStationList))
             .WithOpenApi();
        group.MapGet("/{id}", GetWeatherStation)
             .WithName(nameof(GetWeatherStation))
             .WithOpenApi();
        return endpoints;
    }

    private static async Task<IResult> InsertWeatherStation(WeatherStation station, IWeatherStationsService weatherStationsService)
    {
        await weatherStationsService.InsertAsync(station);
        return Results.NoContent();
    }

    private static async Task<IResult> GetWeatherStationList(IWeatherStationsService weatherStationsService)
    {
        var list = await weatherStationsService.GetListAsync();
        return Results.Ok(list);
    }
    private static async Task<IResult> GetWeatherStation(int id, IWeatherStationsService weatherStationsService)
    {
        var station = await weatherStationsService.GetByIdAsync(id);
        if (station is not null)
            return Results.Ok(station);
        else
            return Results.NotFound();
    }
}
