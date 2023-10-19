namespace ITS.Prometeo.API.Endpoints;

public static class WeatherStationsEndpoints
{
    public static IEndpointRouteBuilder MapWeatherStationsEndpoints(this IEndpointRouteBuilder endpoints)
    {
        var group = endpoints.MapGroup("/api/weatherstation");

        return endpoints;
    }
}
