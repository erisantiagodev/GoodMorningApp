using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class TrafficResponse : ITrafficResponse
    {
        public string TIMESTAMP { get; set; }
        public double VERSION { get; set; }
        public TRAFFICITEMS TRAFFIC_ITEMS { get; set; }
        public Diagnostic diagnostic { get; set; }
        public DateTime TIMESTAMP2 { get; set; }
        public string totalReport { get; set; }
        public string EXTENDED_COUNTRY_CODE { get; set; }
    }

    public class TRAFFICITEMS
    {
        public IList<TRAFFICITEM> TRAFFIC_ITEM { get; set; }
    }
    public class Diagnostic
    {
        public string info { get; set; }
        public string sfile { get; set; }
        public string pdd { get; set; }
    }

    public class TRAFFICITEM
    {
        public long TRAFFIC_ITEM_ID { get; set; }
        public long ORIGINAL_TRAFFIC_ITEM_ID { get; set; }
        public string TRAFFIC_ITEM_STATUS_SHORT_DESC { get; set; }
        public string TRAFFIC_ITEM_TYPE_DESC { get; set; }
        public string START_TIME { get; set; }
        public string END_TIME { get; set; }
        public string ENTRY_TIME { get; set; }
        public CRITICALITY CRITICALITY { get; set; }
        public bool VERIFIED { get; set; }
        public LOCATION LOCATION { get; set; }
        public TRAFFICITEMDETAIL TRAFFIC_ITEM_DETAIL { get; set; }
        public IList<TRAFFICITEMDESCRIPTION> TRAFFIC_ITEM_DESCRIPTION { get; set; }
        public string mid { get; set; }
        public string PRODUCT { get; set; }
    }

    public class LOCATION
    {
        public double LENGTH { get; set; }
    }

    public class TRAFFICITEMDESCRIPTION
    {
        public string value { get; set; }
        public string TYPE { get; set; }
    }

    public class TRAFFICITEMDETAIL
    {
        public bool ROAD_CLOSED { get; set; }
    }

    public class CRITICALITY
    {
        public string ID { get; set; }
        public string DESCRIPTION { get; set; }
    }
}
