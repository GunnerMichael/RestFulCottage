using Booking.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Contracts
{
    public interface IMakeBooking
    {
        Task<BookingResponseModel> NewBooking(BookingRequestModel request);
    }
}
