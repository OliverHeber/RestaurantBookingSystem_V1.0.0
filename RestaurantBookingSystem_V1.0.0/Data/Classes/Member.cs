using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantBookingSystem_V1._0._0.Data
{
    public class Member: Person
    {
        public int Id { get; set; }

        public string ContactNumber { get; set; }

        public string Email { get; set; }

        public DateTime DoB { get; set; }



    }
}
