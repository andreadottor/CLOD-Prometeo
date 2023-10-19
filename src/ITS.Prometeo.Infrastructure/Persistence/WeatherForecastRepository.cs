namespace ITS.Prometeo.Infrastructure.Persistence;

using ITS.Prometeo.ApplicationCore.Entities;
using ITS.Prometeo.ApplicationCore.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;

internal class WeatherForecastRepository : IWeatherForecastRepository
{
    public IEnumerable<WeatherForecast> GetList(int count)
    {
        var summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        var forecast =  Enumerable.Range(1, 5).Select(index =>
                    new WeatherForecast
                    (
                        DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                        Random.Shared.Next(-20, 55),
                        summaries[Random.Shared.Next(summaries.Length)]
                    )).ToArray();
        return forecast;
    }
}
