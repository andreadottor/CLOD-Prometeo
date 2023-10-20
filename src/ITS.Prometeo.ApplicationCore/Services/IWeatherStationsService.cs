using ITS.Prometeo.ApplicationCore.Entities;

namespace ITS.Prometeo.ApplicationCore.Services;


public interface IWeatherStationsService
{
    Task InsertAsync(WeatherStation station);
    Task<IEnumerable<WeatherStation>> GetListAsync();
    Task<WeatherStation?> GetByIdAsync(int id);
    Task UpdateAsync(WeatherStation station);
    Task DeleteAsync(int id);
    Task InsertAsync(WeatherDetection detection);
    Task<IEnumerable<WeatherDetection>> GetDetectionListAsync();
    Task<WeatherDetection?> GetDetectionByIdAsync(long id);

    Task DeleteDetectionAsync(long id);


}
