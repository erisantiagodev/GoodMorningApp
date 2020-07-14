using System.Collections.Generic;

namespace WebApplication1.Models
{
    public interface IWeatherResponse
    {
        public class WeatherResponse
        {
            double Lat { get; set; }
            double Lon { get; set; }
            string timezone { get; set; }
            int timezone_offset { get; set; }
            Current current { get; set; }
            IList<Daily> daily { get; set; }
        }

        public class Daily
        {
            int dt { get; set; }
            int sunrise { get; set; }
            int sunset { get; set; }
            Temp temp { get; set; }
            FeelsLike feels_like { get; set; }
            int pressure { get; set; }
            int humidity { get; set; }
            double dew_point { get; set; }
            double wind_speed { get; set; }
            int wind_deg { get; set; }
            IList<Weather> weather { get; set; }
            int clouds { get; set; }
            double rain { get; set; }
            double uvi { get; set; }
        }

        public class FeelsLike
        {
            double day { get; set; }
            double night { get; set; }
            double eve { get; set; }
            double morn { get; set; }
        }

        public class Current
        {
            int dt { get; set; }
            int sunrise { get; set; }
            int sunset { get; set; }
            double temp { get; set; }
            double feels_like { get; set; }
            int pressure { get; set; }
            int humidity { get; set; }
            double dew_point { get; set; }
            double uvi { get; set; }
            int clouds { get; set; }
            int visibility { get; set; }
            double wind_speed { get; set; }
            int wind_deg { get; set; }
            IList<Weather> weather { get; set; }
        }

        public class Temp
        {
            double day { get; set; }
            double min { get; set; }
            double max { get; set; }
            double night { get; set; }
            double eve { get; set; }
            double morn { get; set; }
        }

        public class Weather
        {
            int id { get; set; }
            string main { get; set; }
            string description { get; set; }
            string icon { get; set; }
        }
    }
}
