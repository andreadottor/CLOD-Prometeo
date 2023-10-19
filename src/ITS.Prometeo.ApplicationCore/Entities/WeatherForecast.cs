namespace ITS.Prometeo.ApplicationCore.Entities;

using System;

public record WeatherForecast(
                DateOnly Date, 
                int TemperatureC, 
                string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
