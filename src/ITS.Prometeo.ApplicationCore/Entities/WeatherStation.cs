namespace ITS.Prometeo.ApplicationCore.Entities;

public class WeatherStation
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
    public double? Altitude { get; set; }
    public string? StationType { get; set; }
}
