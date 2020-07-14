using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Octokit;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IWeatherResponse _weatherResponse;

        public IndexModel(ILogger<IndexModel> logger, IWeatherResponse weatherResponse)
        {
            _logger = logger;
            _weatherResponse = weatherResponse;
        }

        public WeatherResponse weatherResponse { get; set; }

        public async Task OnGetAsync()
        {
            var apiWrapper = new APIWrapper();

            try
            {
                weatherResponse = await apiWrapper.GetWeatherData();
            }

            catch
            {

            }
        }
    }
}
