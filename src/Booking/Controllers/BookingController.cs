using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Booking.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Controllers
{
    [Route("api/{propCode}/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private IMakeBooking _makeBooking;
        
        public BookingController(IMakeBooking makeBooking)
        {
            _makeBooking = makeBooking;
        }

        [HttpGet("{bookingId:int}")]
        public async Task<ActionResult<Model.BookingDetails>> GetBooking(int bookingId)
        {
            var booking = new Model.BookingDetails() { BookingId = bookingId };

            return booking;
        }

        // POST api/values
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult> MakeBookingAsync(string propCode, [FromBody] Model.BookingRequestModel request)
        {
            if (request == null)
            {
                return BadRequest();
            }

            var response = await _makeBooking.NewBooking(request);

            int bookingReference = response.BookingReference;

            var targetPath = String.Format($"~/api/{propCode}/booking/{bookingReference}");

            return AcceptedAtAction(nameof(GetBooking), new { propCode = propCode, bookingId = bookingReference }, null);
        }

    }
}
