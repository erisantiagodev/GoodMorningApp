using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using TrafficAPI;

namespace WebApplication1.Models
{
    public class APIWrapper
    {
        //optional api call// http://api.openweathermap.org/data/2.5/weather?lat=45.4889&lon=-122.8014&exclude=minutely,hourly&units=imperial&appid=8837cf36ec3e1b3c0b8c780d25da38e5 //

        //8837cf36ec3e1b3c0b8c780d25da38e5//
        public string weatherKey = "8837cf36ec3e1b3c0b8c780d25da38e5";
        //CeQNMNtDuai958OWb2wC5ctwjJ6BBM9Jr39c_V_w0ZY//
        public string trafficKey = "CeQNMNtDuai958OWb2wC5ctwjJ6BBM9Jr39c_V_w0ZY";
        public string weatherUrl { get; set; }
        public string trafficUrl { get; set; }

        public double latitude = 45.4889;
        public double longitude = -122.8014;
        public double radius = 10000;

        HttpClient ApiClient = new HttpClient();

        public async Task<WeatherResponse> GetWeatherData()
        {
            WeatherResponse weatherObject = new WeatherResponse();
            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                weatherUrl = $"http://api.openweathermap.org/data/2.5/onecall?lat={latitude}&lon={longitude}&exclude=minutely,hourly&units=imperial&appid={weatherKey}";

                string weatherResponse = await ApiClient.GetStringAsync(weatherUrl);

                weatherObject = JsonConvert.DeserializeObject<WeatherResponse>(weatherResponse);

                string weatherInfo = ($"is {weatherObject.current.weather.FirstOrDefault().main} with some {weatherObject.current.weather.FirstOrDefault().description}.").ToLower();
                string tempInfo = ($"current temperature is {weatherObject.current.temp}").ToLower();

                string midInfo = $"The current weather in Beaverton {weatherInfo} The {tempInfo} °F";

                weatherObject.weatherAndTemp = midInfo;
            }

            catch
            {
                //report.Text = "LOAD DATA";
            }

            return weatherObject;
        }

        public async Task<TrafficResponse> GetTrafficData()
        {
            TrafficResponse trafficObject = new TrafficResponse();
            var traffic = new TrafficParameters();

            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                trafficUrl = $"https://traffic.ls.hereapi.com/traffic/6.2/incidents.json?apiKey={trafficKey}&prox={latitude},{longitude},{radius}&sort={traffic.sort}&verified={traffic.verified}&maxresults={traffic.maxresults}";

                string response = await ApiClient.GetStringAsync(trafficUrl);

                trafficObject = JsonConvert.DeserializeObject<TrafficResponse>(response);

                string trafficDescription = trafficObject.TRAFFIC_ITEMS.TRAFFIC_ITEM.FirstOrDefault().TRAFFIC_ITEM_TYPE_DESC.ToLower();
                string trafficStartTime = trafficObject.TRAFFIC_ITEMS.TRAFFIC_ITEM.FirstOrDefault().START_TIME;
                string trafficEndTime = trafficObject.TRAFFIC_ITEMS.TRAFFIC_ITEM.FirstOrDefault().END_TIME;
                string trafficItemDesc = trafficObject.TRAFFIC_ITEMS.TRAFFIC_ITEM.FirstOrDefault().TRAFFIC_ITEM_DESCRIPTION.FirstOrDefault().value;

                string reportDetails = $"Traffic Item description: {trafficDescription}, Start Time: {trafficStartTime}, End Time: {trafficEndTime}, Description: {trafficItemDesc}";

                trafficObject.totalReport = reportDetails;
            }

            catch
            {

            }

            return trafficObject;
        }
    }
}
