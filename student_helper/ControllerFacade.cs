using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_helper
{
    class ControllerFacade
    {
        DatabaseController DB = new DatabaseController();
        public bool SaveEvent(DateTime starttid, DateTime sluttid, string comment, string eventtype)
        {
            return DB.AddEventToDb(starttid, sluttid, comment, eventtype);
        }
    }
}
