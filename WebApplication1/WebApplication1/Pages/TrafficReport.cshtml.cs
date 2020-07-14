using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1
{
    public class TrafficReportModel : PageModel
    {
        private readonly ILogger<TrafficReportModel> _logger;
        private readonly ITrafficResponse _trafficResponse;

        public TrafficReportModel(ILogger<TrafficReportModel> logger, ITrafficResponse trafficResponse)
        {
            _logger = logger;
            _trafficResponse = trafficResponse;
        }
        public TrafficResponse trafficResponse { get; set; }

        public async Task OnGetAsync()
        {
            var apiWrapper = new APIWrapper();

            try
            {
                trafficResponse = await apiWrapper.GetTrafficData();
            }

            catch
            {

            }
        }
    }
}