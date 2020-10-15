using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantBookingSystem_V1._0._0.Data
{
    public class Table
    {


        public int TableId { get; set; }

        public bool Booked { get; set; }

        public int Seats { get; set; }

        //potentially keep track of table types? Round, square rectangle, for the purposes of joining tables together

        //public string TableShape { get; set; }

       

    }
}
