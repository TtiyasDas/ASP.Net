using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class BusModel
    {
        public string BusName { get; set; }
        public int BusNo { get; set; }
        public int RouteNo { get; set; }
        public string DestinationArraivalTime { get; set; }
        public string DestinationDepartureTime { get; set; }
    }
}
