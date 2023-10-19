namespace ITS.Prometeo.ApplicationCore.Services;

using ITS.Prometeo.ApplicationCore.Entities;
using System.Collections.Generic;

public interface IWeatherForecastService
{
    IEnumerable<WeatherForecast> GetWeatherForecast(int count);
}