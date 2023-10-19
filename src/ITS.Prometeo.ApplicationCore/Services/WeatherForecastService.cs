namespace ITS.Prometeo.ApplicationCore.Services;

using ITS.Prometeo.ApplicationCore.Entities;
using ITS.Prometeo.ApplicationCore.Persistence;
using System.Collections.Generic;

internal class WeatherForecastService : IWeatherForecastService
{
    private readonly IWeatherForecastRepository _weatherForecastRepository;

    public WeatherForecastService(IWeatherForecastRepository weatherForecastRepository)
    {
        _weatherForecastRepository = weatherForecastRepository;
    }

    public IEnumerable<WeatherForecast> GetWeatherForecast(int count)
    {
        return _weatherForecastRepository.GetList(5);
    }
}
