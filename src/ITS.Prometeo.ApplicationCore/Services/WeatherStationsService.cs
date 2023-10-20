namespace ITS.Prometeo.ApplicationCore.Services;

using ITS.Prometeo.ApplicationCore.Entities;
using ITS.Prometeo.ApplicationCore.Persistence;
using System.Collections.Generic;
using System.Threading.Tasks;

internal class WeatherStationsService : IWeatherStationsService
{
    private readonly IWeatherStationsRepository _weatherStationsRepository;
    private readonly IWeatherDetectionRepository _weatherDetectionsRepository;

    public WeatherStationsService(IWeatherStationsRepository weatherStationsRepository, IWeatherDetectionRepository weatherDetectionsRepository)
    {
        _weatherStationsRepository = weatherStationsRepository;
        _weatherDetectionsRepository = weatherDetectionsRepository;
    }

    public Task DeleteAsync(int id)
    {
        return _weatherStationsRepository.DeleteAsync(id);
    }

    public Task<WeatherStation?> GetByIdAsync(int id)
    {
       return _weatherStationsRepository.GetByIdAsync(id);
    }

    public Task<WeatherDetection?> GetDetectionByIdAsync(long id)
    {
        return _weatherDetectionsRepository.GetByIdAsync(id);
    }

    public Task<IEnumerable<WeatherDetection>> GetDetectionListAsync()
    {
        return _weatherDetectionsRepository.GetListAsync();
    }

    public Task<IEnumerable<WeatherStation>> GetListAsync()
    {
        return _weatherStationsRepository.GetListAsync();
    }

    public Task InsertAsync(WeatherStation station)
    {
        return _weatherStationsRepository.InsertAsync(station);
    }

    public Task InsertAsync(WeatherDetection detection)
    {
        return _weatherDetectionsRepository.InsertAsync(detection);
    }

    public Task UpdateAsync(WeatherStation station)
    {
        return _weatherStationsRepository.UpdateAsync(station);
    }

    public Task DeleteDetectionAsync(long id)
    {
        return _weatherDetectionsRepository.DeleteAsync(id);
    }
}
