using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestFulCottage.Model;

namespace RestFulCottage.Demo
{
    public class DemoCalendarService : Contracts.ICottageCalendarService
    {
        public CottageCalendarModel Get(string propertyCode)
        {
            CottageCalendarModel cm = new CottageCalendarModel();

            DateTime start = new DateTime(2019, 1, 1);

            while (start <= new DateTime(2019, 12, 31))
            {
                var day = new CalendarDayModel();
                day.Date = start;

                cm.Days.Add(day);

                start = start.AddDays(1);
            }

            return cm;
        }

        public CottageCalendarModel Get(string propertyCode, DateTime start)
        {
            throw new NotImplementedException();
        }

        public CottageCalendarModel Get(string propertyCode, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }
    }
}
