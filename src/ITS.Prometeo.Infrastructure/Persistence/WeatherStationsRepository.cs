namespace ITS.Prometeo.Infrastructure.Persistence
{
    using Dapper;
    using ITS.Prometeo.ApplicationCore.Entities;
    using ITS.Prometeo.ApplicationCore.Persistence;
    using Microsoft.Extensions.Configuration;
    using Npgsql;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    internal class WeatherStationsRepository : IWeatherStationsRepository
    {
        private readonly string _connectionString;

        public WeatherStationsRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("db");
        }

        public async Task DeleteAsync(int id)
        {
            const string query = """
                DELETE FROM weatherstation
                WHERE id = @id;
                """;
            using var connection = new NpgsqlConnection(_connectionString);
            await connection.ExecuteAsync(query, new { id });
        }

        public async Task<WeatherStation?> GetByIdAsync(int id)
        {
            const string query = """
                SELECT 
                    id           as Id,
                    name         as Name,
                    altitude     as Altitude,
                    longitude    as Longitude,
                    latitude     as Latitude,
                    station_type as StationType
                FROM weatherstation
                WHERE
                    id = @id
                """;
            using var connection = new NpgsqlConnection(_connectionString);
            return await connection.QueryFirstOrDefaultAsync<WeatherStation>(query, new {id});

        }

        public async Task<IEnumerable<WeatherStation>> GetListAsync()
        {
            const string query = """
                SELECT 
                    id           as Id,
                    name         as Name,
                    altitude     as Altitude,
                    longitude    as Longitude,
                    latitude     as Latitude,
                    station_type as StationType
                FROM weatherstation
                """;
            using var connection = new NpgsqlConnection(_connectionString);
            return await connection.QueryAsync< WeatherStation>(query);
        }

        public async Task InsertAsync(WeatherStation station)
        {
            const string query = """
                INSERT INTO weatherstation (
                    name,
                    altitude,
                    longitude,
                    latitude,
                    station_type)
                VALUES (
                    @Name,
                    @Altitude,
                    @Longitude,
                    @Latitude,
                    @StationType);
                """;

            using var connection = new NpgsqlConnection(_connectionString);
            await connection.ExecuteAsync(query, station);
        }

        public async Task UpdateAsync(WeatherStation station)
        {
            const string query = """
                UPDATE weatherstation 
                SET
                    name =          @Name,
                    altitude =      @Altitude,
                    longitude =     @Longitude,
                    latitude =      @Latitude,
                    station_type =  @StationType
                WHERE
                    id = @Id
                """;

            using var connection = new NpgsqlConnection(_connectionString);
            await connection.ExecuteAsync(query, station);
        }
    }
}
