using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_helper
{
    public class Schedule:Event
    {
        public string EventType { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime EndDate { get; set; }
        public string Comment { get; set; }
    }
}
