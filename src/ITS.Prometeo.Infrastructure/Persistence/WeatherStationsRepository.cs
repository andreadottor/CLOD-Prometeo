namespace ITS.Prometeo.Infrastructure.Persistence
{
    using ITS.Prometeo.ApplicationCore.Persistence;
    using Microsoft.Extensions.Configuration;
    using Dapper;
    using Npgsql;

    internal class WeatherStationsRepository : IWeatherStationsRepository
    {
        private readonly string _connectionString;

        public WeatherStationsRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("db");
        }


    }
}
