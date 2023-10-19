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
}
