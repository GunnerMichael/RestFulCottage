using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Model
{
    public class BookingRequestModel
    {
        public DateTime StartDate { get; set; }

        public short Nights { get; set; }
    }
}
