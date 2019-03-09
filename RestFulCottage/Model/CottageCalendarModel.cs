using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestFulCottage.Model
{
    public class CottageCalendarModel
    {
        private List<CalendarDayModel> _days = new List<CalendarDayModel>();

        public List<CalendarDayModel> Days
        {
            get
            {
                return _days;
            }
        }

    }
}
