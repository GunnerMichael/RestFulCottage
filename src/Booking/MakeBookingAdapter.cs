using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Booking.Model;

namespace Booking
{
    public class MakeBookingAdapter : Contracts.IMakeBooking
    {
        public async Task<BookingResponseModel> NewBooking(BookingRequestModel request)
        {
            BookingResponseModel response = new BookingResponseModel();

            response.BookingReference = 12345;

            return response;
        }
    }
}
