using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantBookingSystem_V1._0._0.Data
{
    public class Guest: Person
    {

        //easiest way to collect contact information, this way a person can enter a phone number or email address, phone or email is a unique identifier, will require the information to be deleted from the database
        //alternatively keep a permenant list of previous guests for look up

            [Key]
        public string Contact { get; set; }
    }
}
