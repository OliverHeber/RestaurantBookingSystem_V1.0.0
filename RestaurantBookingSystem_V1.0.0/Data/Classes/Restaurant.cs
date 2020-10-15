using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantBookingSystem_V1._0._0.Data.Classes
{
    public class Restaurant
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public List<Area> Areas { get; set; }

        public bool Available { get; set; }

        public List<Staff> Staff { get; set; }

        public List<Member> Members { get; set; }




    }
}
