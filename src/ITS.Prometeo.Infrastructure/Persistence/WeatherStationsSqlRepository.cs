namespace ITS.Prometeo.Infrastructure.Persistence;

using ITS.Prometeo.ApplicationCore.Entities;
using ITS.Prometeo.ApplicationCore.Persistence;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

internal class WeatherStationsSqlRepository : IWeatherStationsRepository
{
    private string _connectionString;

    public WeatherStationsSqlRepository(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("sql");
    }


    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<WeatherStation?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<WeatherStation>> GetListAsync()
    {
        throw new NotImplementedException();
    }

    public Task InsertAsync(WeatherStation station)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(WeatherStation station)
    {
        throw new NotImplementedException();
    }
}
