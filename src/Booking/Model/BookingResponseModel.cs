using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Model
{
    public class BookingResponseModel
    {
        bool Success { get; set; }

        public int BookingReference { get; set; }
    }
}
