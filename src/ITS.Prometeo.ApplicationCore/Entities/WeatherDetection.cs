using ITS.Prometeo.ApplicationCore.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.Prometeo.ApplicationCore.Entities
{
    public class WeatherDetection
    {
        public long Id { get; set; }
        public int WeatherStationId { get; set; }
        public WeatherDetectionTypeEnum Type { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }  
    }
}
