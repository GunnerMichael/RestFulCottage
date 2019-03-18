using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestFulCalendar.Model
{
    public class CalendarDayModel
    {
        public DateTime Date { get; set; }

        public bool Booked { get; set;  }
    }
}
