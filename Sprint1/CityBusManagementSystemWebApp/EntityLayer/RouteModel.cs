using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class RouteModel
    {
        public int RouteNo { get; set; }
        public int NoOfStops { get; set; }
        public int FareStages { get; set; }
        public string Begin_Stop { get; set; }
        public string End_Stop { get; set; }
        public string Start_Time { get; set; }
        public string End_Time { get; set; }
       
    }
}
