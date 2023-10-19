namespace ITS.Prometeo.ApplicationCore.Persistence;

using ITS.Prometeo.ApplicationCore.Entities;

public interface IWeatherForecastRepository
{
    IEnumerable<WeatherForecast> GetList(int count);
}
