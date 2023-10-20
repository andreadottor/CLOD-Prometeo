using ITS.Prometeo.ApplicationCore.Entities;

namespace ITS.Prometeo.ApplicationCore.Persistence;


public interface IWeatherStationsRepository
{
    Task InsertAsync(WeatherStation station);
    Task<IEnumerable<WeatherStation>> GetListAsync();
    Task<WeatherStation?> GetByIdAsync(int id);
    Task UpdateAsync(WeatherStation station);
    Task DeleteAsync(int id);

}


