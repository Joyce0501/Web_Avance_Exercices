using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_Models.Models
{
    internal class Destination
    {
        [StringLength(30)]
        public String Name { get; set; }

        [StringLength(30)]
        public String Region { get; set; }
    }
}
