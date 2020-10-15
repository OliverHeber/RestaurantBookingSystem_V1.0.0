using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantBookingSystem_V1._0._0.Data
{
    public class Sitting
    {
        public int SittingId { get; set; }


        //potentially can call this SittingType?
        public string Name { get; set; }

        public string Description { get; set; }


        //denotes a function or special event
        public bool Special { get; set; }

        public TimeSpan SittingDuration { get; set; }

        public List<Area> Areas { get; set; }


        public bool FullyBooked { get; set; }
    }

}
