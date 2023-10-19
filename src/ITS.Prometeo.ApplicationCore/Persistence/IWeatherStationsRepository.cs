using ITS.Prometeo.ApplicationCore.Entities;

namespace ITS.Prometeo.ApplicationCore.Persistence;


public interface IWeatherStationsRepository
{
    Task InsertAsync(WeatherStation station);
    Task<IEnumerable<WeatherStation>> GetListAsync();
}

