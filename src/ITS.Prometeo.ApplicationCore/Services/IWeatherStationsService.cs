using ITS.Prometeo.ApplicationCore.Entities;

namespace ITS.Prometeo.ApplicationCore.Services;


public interface IWeatherStationsService
{
    Task InsertAsync(WeatherStation station);
}
