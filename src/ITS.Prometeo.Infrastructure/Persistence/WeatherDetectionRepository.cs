
using Dapper;
using ITS.Prometeo.ApplicationCore.Entities;
using ITS.Prometeo.ApplicationCore.Persistence;
using Microsoft.Extensions.Configuration;
using Npgsql;
using static System.Collections.Specialized.BitVector32;

namespace ITS.Prometeo.Infrastructure.Persistence;

internal class WeatherDetectionRepository : IWeatherDetectionRepository
{
    private readonly string _connectionString;

    public WeatherDetectionRepository(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("db");
    }
    public async Task InsertAsync(WeatherDetection detection)
    {
        const string query = """
                INSERT INTO weatherdetection (
                    weather_station_id,
                    detection_type,
                    value,
                    date)
                VALUES (
                    @WeatherStationId,
                    @Type,
                    @Value,
                    @Date);
                """;

        using var connection = new NpgsqlConnection(_connectionString);
        await connection.ExecuteAsync(query, detection);
    }
}
