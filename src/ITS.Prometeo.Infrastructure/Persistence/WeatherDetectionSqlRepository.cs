namespace ITS.Prometeo.Infrastructure.Persistence;

using ITS.Prometeo.ApplicationCore.Entities;
using ITS.Prometeo.ApplicationCore.Persistence;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

internal class WeatherDetectionSqlRepository : IWeatherDetectionRepository
{
    private readonly string _connectionString;

    public WeatherDetectionSqlRepository(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("sql");
    }

    public Task DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<WeatherDetection?> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<WeatherDetection>> GetListAsync()
    {
        throw new NotImplementedException();
    }

    public Task InsertAsync(WeatherDetection detection)
    {
        throw new NotImplementedException();
    }
}
