using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM_JsonRest.Model
{
    public class WeatherObservation
    {
        public string weatherCondition { get; set; }
        public string ICAO { get; set; }
        public long elevation { get; set; }
        public string countryCode { get; set; }
        public string cloudCode { get; set; }
        public long lng { get; set; }
        public long temperature { get; set; }
        public long dewPoint { get; set; }
        public long windSpeed { get; set; }
        public long humidity { get; set; }
        public string stationName { get; set; }
        public DateTime dateTime { get; set; }
        public long lat { get; set; }
        public long hectoPascAlimeter { get; set; }
    }
}
