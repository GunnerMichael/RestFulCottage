using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestFulCalendar.Model;

namespace RestFulCalendar.Controllers
{
    [Route("api/{propCode}/calendar")]
    [ApiController]
    public class CottageCalendarController : ControllerBase
    {
        public CottageCalendarController(Contracts.ICottageCalendarService calendarService)
        {
            this._calendarService = calendarService;
        }
  
        private Contracts.ICottageCalendarService _calendarService;

        [HttpGet]
        public ActionResult<Model.CottageCalendarModel> Get(string propCode)
        {
            return GetCalendar(propCode);
        }

        private ActionResult<CottageCalendarModel> GetCalendar(string propCode)
        {
            return _calendarService.Get(propCode);
        }
    }
}