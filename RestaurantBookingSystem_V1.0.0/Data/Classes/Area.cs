using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantBookingSystem_V1._0._0.Data
{
    public class Area
    {
        [Key]
        public int AreaId { get; set; }

        public string AreaName { get; set; }

        public List<Table> Tables { get; set; }

        public bool FullyBooked { get; set; }
    }
}
