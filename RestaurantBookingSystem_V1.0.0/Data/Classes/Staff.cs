using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantBookingSystem_V1._0._0.Data
{
    public class Staff:Person
    {

        [Key] [Required]
        public int StaffId { get; set; }

        public string ContactPhone { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }


    }
}
