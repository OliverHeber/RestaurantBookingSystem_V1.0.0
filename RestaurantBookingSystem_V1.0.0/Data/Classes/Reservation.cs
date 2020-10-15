using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantBookingSystem_V1._0._0.Data
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        public DateTime StartTime { get; set; }

        public TimeSpan Duration { get; set; }

        public string ReservationSource { get; set; }

       



        ////optional fields, food for thought

        ////for private functions or bookings

        //public bool SpecialReservation { get; set; }


        ////if person wants to book a whole area of the restaurant, they can book all tables in an area
        //public bool BookEntireArea { get; set; }






        //method to calculate duration
        //will require customers or staff to enter start and finish times in the booking process, potentially make it optional?

        private TimeSpan CalculateDuration(DateTime start, DateTime finish)
        {
            return start - finish;
        }
    }
}
