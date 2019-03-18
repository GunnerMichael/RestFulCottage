using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestFulCalendar.Contracts
{
    public interface ICottageCalendarService
    {
        Model.CottageCalendarModel Get(string propertyCode);
        Model.CottageCalendarModel Get(string propertyCode, DateTime start);

        Model.CottageCalendarModel Get(string propertyCode, DateTime start, DateTime end);
    }
}
