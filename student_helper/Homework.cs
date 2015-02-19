using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_helper
{
    class Homework:Event
    {
        public DateTime EndDate { get; set; }
        public string Comment { get; set; }
    }
}
