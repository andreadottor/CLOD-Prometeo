namespace ITS.Prometeo.Infrastructure.Persistence
{
    using Dapper;
    using ITS.Prometeo.ApplicationCore.Entities;
    using ITS.Prometeo.ApplicationCore.Persistence;
    using Microsoft.Extensions.Configuration;
    using Npgsql;
    using System.Threading.Tasks;

    internal class WeatherStationsRepository : IWeatherStationsRepository
    {
        private readonly string _connectionString;

        public WeatherStationsRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("db");
        }

        public async Task InsertAsync(WeatherStation station)
        {
            const string query = """
                INSERT INTO weatherstation (
                    name,
                    altitude,
                    longitude,
                    latitude,
                    station_type
                    )
                    VALUES (
                    @Name,
                    @Altitude,
                    @Longitude,
                    @Latitude,
                    @StationType
                    );
                """;

            using var connection = new NpgsqlConnection(_connectionString);
            await connection.ExecuteAsync(query, station);
        }
    }
}
