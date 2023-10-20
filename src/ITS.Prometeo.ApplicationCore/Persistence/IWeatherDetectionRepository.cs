using ITS.Prometeo.ApplicationCore.Entities;

namespace ITS.Prometeo.ApplicationCore.Persistence;

public interface IWeatherDetectionRepository
{
    Task InsertAsync(WeatherDetection detection);
    Task<IEnumerable<WeatherDetection>> GetListAsync();
    Task<WeatherDetection?> GetByIdAsync(long id);
    Task DeleteAsync(long id);

}
