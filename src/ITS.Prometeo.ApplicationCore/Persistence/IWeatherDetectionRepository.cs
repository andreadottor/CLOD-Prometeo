using ITS.Prometeo.ApplicationCore.Entities;

namespace ITS.Prometeo.ApplicationCore.Persistence;

public interface IWeatherDetectionRepository
{
    Task InsertAsync(WeatherDetection detection);
}
