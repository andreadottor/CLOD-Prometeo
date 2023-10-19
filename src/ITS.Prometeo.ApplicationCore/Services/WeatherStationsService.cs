namespace ITS.Prometeo.ApplicationCore.Services;

using ITS.Prometeo.ApplicationCore.Persistence;


internal class WeatherStationsService : IWeatherStationsService
{
    private readonly IWeatherStationsRepository _weatherStationsRepository;

    public WeatherStationsService(IWeatherStationsRepository weatherStationsRepository)
    {
        _weatherStationsRepository = weatherStationsRepository;
    }

}
