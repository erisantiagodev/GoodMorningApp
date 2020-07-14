using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public interface ITrafficResponse
    {
        public class TrafficResponse
        {
            string TIMESTAMP { get; set; }
            double VERSION { get; set; }
            TRAFFICITEMS TRAFFIC_ITEMS { get; set; }
            Diagnostic diagnostic { get; set; }
            DateTime TIMESTAMP2 { get; set; }
            string EXTENDED_COUNTRY_CODE { get; set; }
        }

        public class TRAFFICITEMS
        {
            IList<TRAFFICITEM> TRAFFIC_ITEM { get; set; }
        }
        public class Diagnostic
        {
            string info { get; set; }
            string sfile { get; set; }
            string pdd { get; set; }
        }

        public class TRAFFICITEM
        {
            long TRAFFIC_ITEM_ID { get; set; }
            long ORIGINAL_TRAFFIC_ITEM_ID { get; set; }
            string TRAFFIC_ITEM_STATUS_SHORT_DESC { get; set; }
            string TRAFFIC_ITEM_TYPE_DESC { get; set; }
            string START_TIME { get; set; }
            string END_TIME { get; set; }
            string ENTRY_TIME { get; set; }
            CRITICALITY CRITICALITY { get; set; }
            bool VERIFIED { get; set; }
            LOCATION LOCATION { get; set; }
            TRAFFICITEMDETAIL TRAFFIC_ITEM_DETAIL { get; set; }
            IList<TRAFFICITEMDESCRIPTION> TRAFFIC_ITEM_DESCRIPTION { get; set; }
            string mid { get; set; }
            string PRODUCT { get; set; }
        }

        public class LOCATION
        {
            double LENGTH { get; set; }
        }

        public class TRAFFICITEMDESCRIPTION
        {
            string value { get; set; }
            string TYPE { get; set; }
        }

        public class TRAFFICITEMDETAIL
        {
            bool ROAD_CLOSED { get; set; }
        }

        public class CRITICALITY
        {
            string ID { get; set; }
            string DESCRIPTION { get; set; }
        }
    }
}
