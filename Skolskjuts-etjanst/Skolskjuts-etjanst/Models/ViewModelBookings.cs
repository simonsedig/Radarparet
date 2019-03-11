using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Skolskjuts_etjanst.Models
{
    public class ViewModelBookings
    {
        public List<Bookings> AllBookingsList { get; set; }
        public List<Bookings> CustomerCurrentBookingList { get; set; }

        public Bookings newBooking { get; set; }
        public List<DateTime> timeOfBooking { get; set; }

        public ViewModelBookings()
        {
            // initate lists to AVOID NULL ERROR
            AllBookingsList = new List<Bookings>();
            CustomerCurrentBookingList = new List<Bookings>();
            timeOfBooking = new List<DateTime>();
        }
    }

}