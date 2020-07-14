using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficAPI
{
    public class TrafficParameters
    {
        public string units = "imperial"; //specifies units measured
        public string criticality { get; set; } //specifies the incident reports according to criticality
        public string type { get; set; } //specifies the type of items to include in the response
        public string status { get; set; } //specifies status of the incident

        public string sort = "criticalityDesc"; //sorts traffic incidents according to criticality

        public bool localtime = true; //traffic incident data should be in the local time of the incident

        public bool verified = true; //traffic incident should be confirmed

        public int maxresults = 15; //specifies the maximum number of incidents to be included in the response
        public double longitude { get; set; }
        public double latitude { get; set; }
        public double radius { get; set; }
    }
}
