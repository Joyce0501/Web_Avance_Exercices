using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_Models.Models
{
    internal class Travel
    {
        [StringLength(25)]
        public String Name { get; set; }

        [DataType(DataType.Text)]
        public String Description { get; set; }

        public double price { get; set; }

        [DataType(DataType.Date)]
        public DateTime DepartureDate { get; set; }

        [Range(7, 21)]
        public int Duration { get; set; }

    }
}
